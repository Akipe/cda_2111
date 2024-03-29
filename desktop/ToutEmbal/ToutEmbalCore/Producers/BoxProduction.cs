﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore.Producers
{
    public class BoxProduction : IProducer
    {
        private static Random? _rnd = null;

        private const int DEFECT_RATE_MIN = 0;
        private const int DEFECT_RATE_MAX = 1000;

        private int _productivityPerHour;
        private int _nbDone;
        private IProducerState _state;

        public event EventHandler? OnMaxProduction;
        public event EventHandler? OnStateChanged;
        public event EventHandler? OnCreateOne;

        private static Random GetRandom()
        {
            if (_rnd is null)
            {
                _rnd = new Random();
            }

            return _rnd;
        }

        public int RateDefectPercent
        {
            get; private set;
        }

        public int NbDone
        {
            get
            {
                return _nbDone;
            }

            private set
            {
                if (value > MaxWanted)
                {
                    throw new Exception(
                        "You can't create more box than the limit : " + MaxWanted.ToString()
                    );
                }

                _nbDone = value;

                if (_nbDone == MaxWanted)
                {
                    State = ProducerState.SHUTDOWN;
                    ExecOnMaxProduction();
                }
            }
        }

        public List<IProducerDefect> Defects
        {
            get; private set;
        }

        public int ProductivityPerHour
        {
            get
            {
                return _productivityPerHour;
            }

            set
            {
                _productivityPerHour = value;
                MilisecondsForOneProduct = (int)((3600d / (double)value) * 1000d);
            }
        }

        public int MaxWanted
        {
            get; set;
        }

        public IProducerState State
        {
            get
            {
                return _state;
            }
            private set
            {
                _state = value;

                ExecOnStateChanged();
            }
        }

        public string Name
        {
            get; set;
        }

        public int MilisecondsForOneProduct
        {
            get; set;
        }

        public BoxProduction(
            string name,
            int productivityPerHour,
            int maxWanted,
            int rateDefectPerThousand
        )
        {
            if (
                rateDefectPerThousand < DEFECT_RATE_MIN &&
                rateDefectPerThousand > DEFECT_RATE_MAX
            )
            {
                throw new Exception(
                    "You have to set an rate defect between " +
                    $"{DEFECT_RATE_MIN} and {DEFECT_RATE_MAX} " +
                    "(for a per thousand)"
                );
            }

            Name = name;
            ProductivityPerHour = productivityPerHour;
            MaxWanted = maxWanted;
            RateDefectPercent = rateDefectPerThousand;

            OnMaxProduction = null;
            OnStateChanged = null;
            OnCreateOne = null;

            NbDone = 0;
            Defects = new List<IProducerDefect>();
            State = ProducerState.CREATED;
        }

        public double GetTotalRateDefect()
        {
            if (NbDone == 0)
            {
                return 0.0;
            }

            return Defects.Count / (double)NbDone;
        }

        public double GetLastHourRateDefect()
        {
            int countDefect = 0;
            TimeSpan oneHour = TimeSpan.FromHours(1);

            foreach (IProducerDefect defect in Defects)
            {
                if (defect.GetWhenOccurred() > DateTime.Now - oneHour)
                {
                    countDefect++;
                }
            }

            return countDefect / (double)ProductivityPerHour;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetProduction()
        {
            return NbDone;
        }

        public void Launch()
        {
            if (State != ProducerState.CREATED)
            {
                return;
            }

            State = ProducerState.STARTED;

            while (State != ProducerState.SHUTDOWN)
            {
                if (State == ProducerState.STARTED)
                {
                    Thread.Sleep(MilisecondsForOneProduct);

                    if (IsBoxDefect())
                    {
                        Defects.Add(new ProduceDefect());
                    }
                    else
                    {
                        NbDone++;
                    }

                    OnCreateOne?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void Start()
        {
            if (
                State != ProducerState.SHUTDOWN &&
                State != ProducerState.CREATED)
            {
                State = ProducerState.STARTED;
            }
        }

        public void Stop()
        {
            if (
                State != ProducerState.SHUTDOWN &&
                State != ProducerState.CREATED
            )
            {
                State = ProducerState.STOPPED;
            }
        }

        public void Shutdown()
        {
            /*if (State != ProducerState.created)
            {*/
            State = ProducerState.SHUTDOWN;
            /*}*/
        }

        private bool IsBoxDefect()
        {
            int luck = GetRandom().Next(
                DEFECT_RATE_MIN,
                DEFECT_RATE_MAX + 1
            );

            return RateDefectPercent > luck;
        }

        public int GetMilisecondsForCreateOne()
        {
            return MilisecondsForOneProduct;
        }

        public int GetNbWanted()
        {
            return MaxWanted;
        }

        public IProducerState GetState()
        {
            return State;
        }

        private void ExecOnMaxProduction()
        {
            if (OnMaxProduction is not null)
            {
                try
                {
                    OnMaxProduction.Invoke(this, EventArgs.Empty);
                }
                catch (Exception)
                {
                    OnMaxProduction(this, EventArgs.Empty);
                }
            }
        }

        private void ExecOnStateChanged()
        {
            if (OnStateChanged is not null)
            {
                if (
                    _state == ProducerState.STARTED ||
                    _state == ProducerState.STOPPED
                )
                {
                    try
                    {
                        OnStateChanged.Invoke(this, EventArgs.Empty);
                    }
                    catch (Exception)
                    {
                        OnStateChanged(this, EventArgs.Empty);
                    }
                }
                else
                {
                    OnStateChanged(this, EventArgs.Empty);
                }
            }
        }
    }
}