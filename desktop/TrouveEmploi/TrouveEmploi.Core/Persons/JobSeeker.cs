using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.Core.Education;

namespace TrouveEmploi.Core.Persons
{
    public class JobSeeker : Person
    {
        public const int MAX_YEAR_FROM_NOW = 60;

        public readonly int registrationYear;
        public Formation formation;
        private int? _diplomaYear;

        public Guid Id
        {
            get; private set;
        }

        public Diploma? Diploma
        {
            get; private set;
        }

        public int? DiplomaYear
        {
            get
            {
                return _diplomaYear;
            }
            private set
            {
                if (
                    value is not null &&
                    value > int.Parse(DateTime.Now.ToString("yyyy")
                ))
                {
                    throw new Exception("You can't have a diploma in the future");
                }

                _diplomaYear = value;
            }
        }

        public JobSeeker(
            string firstName,
            string lastName,
            int registrationYear,
            Formation formation
        ) : base(firstName, lastName)
        {
            this.registrationYear = registrationYear;
            this.formation = formation;

            GenerateID();
            RemoveDiploma();
        }

        public JobSeeker(
            string firstName,
            string lastName,
            int registrationYear,
            Formation formation,
            Diploma diploma,
            int diplomaYear
        ) : this(
            firstName,
            lastName,
            registrationYear,
            formation
        )
        {
            SetDiploma(diploma, diplomaYear);
        }

        public void SetDiploma(Diploma diploma, int year)
        {
            Diploma = diploma;
            DiplomaYear = year;
        }

        public void RemoveDiploma()
        {
            Diploma = null;
            DiplomaYear = null;
        }

        private void GenerateID()
        {
            Guid uuid = Guid.NewGuid();

            Id = uuid;
        }
    }
}
