using System;

namespace ex_2_7_2_calculation_persons
{
    public class CounterAgePerson
    {
        /*
         * Algorithm for count young people.
         * 1) Save user entry for all people.
         * 2) For each people, ask age, and save it to an array.
         * 3) After,make a loop for all ages.
         * 4) If a person has less than 20 years old, increase to one a counter of young people.
         * 5) If a person has 20 years old, increase to one a counter of people who are 20 years old.
         * 6) If a person has more than 20 years old, increase to one a counter of adult persons.
         * 7) If the counter of young people is same as the number of people, show "All people are less than 20 years old"
         * 8) If the counter of adult persons is same as the number of people, show "All people are more than 20 years old"
         * 9) After the loop, show how many people are young with "- than 20",
         *      how many people are 20 years old with "= than 20",
         *      and how many people are adults with "+ than 20".
         */
        
        private const int MINIMAL_AGE_ALLOW = 1;
        private const int MAXIMAL_AGE_ALLOW = 120;
        private const int LIMIT_AGE_YOUNG_ADULT = 20;
        
        private int[] _agePeople;
        private bool _countHasBeenDone;
        private int _youngPeople;
        private int _twentyYearsOldPeople;
        private int _adultPeople;
        
        public CounterAgePerson()
        {
            this._agePeople = new int[] {0};
            this._countHasBeenDone = false;
            this.InitializeCounters();
        }

        public void AddPerson(int age)
        {
            this.ThrowErrorIfLowerThanMinimumAgeAccepted(age);
            this.ThrowErrorIfBiggerThanMaximalAgeAccepted(age);
            
            if (!this.IsThereAlreadyRegisteredPerson())
            {
                this._agePeople[0] = age;
            }
            else
            {
                int[] agePeopleIncrease = new int[this.GetHowManyPeople() + 1];
                
                Array.Copy(this._agePeople, agePeopleIncrease, this._agePeople.Length);

                this._agePeople = agePeopleIncrease;
                this._agePeople[^1] = age;
            }

            this.ResetCounterHasBeenDone();
        }

        public int GetHowManyYoungPeople()
        {
            this.MakeAgeCountIfHasNotBeenDone();

            return this._youngPeople;
        }

        public int GetHowManyTwentyYearsOldPeople()
        {
            this.MakeAgeCountIfHasNotBeenDone();

            return this._twentyYearsOldPeople;
        }

        public int GetHowManyAdults()
        {
            this.MakeAgeCountIfHasNotBeenDone();

            return this._adultPeople;
        }

        public bool AreAllTwentyYearsOldOrMore()
        {
            this.MakeAgeCountIfHasNotBeenDone();
            
            return this.GetHowManyYoungPeople() == 0 &
                   (this.GetHowManyAdults() > 0 | this.GetHowManyTwentyYearsOldPeople() > 0);
        }
        
        public bool AreAllYoung()
        {
            this.MakeAgeCountIfHasNotBeenDone();

            return this.GetHowManyYoungPeople() == this.GetHowManyPeople();
        }

        private void MakeAgeCount()
        {
            this.InitializeCounters();
            
            foreach (int agePerson in _agePeople)
            {
                if (IsYoung(agePerson))
                {
                    this._youngPeople++;
                }

                if (IsAdult(agePerson))
                {
                    this._adultPeople++;
                }

                if (IsTwentyYearsOld(agePerson))
                {
                    this._twentyYearsOldPeople++;
                }
            }
        }

        private void ThrowErrorIfLowerThanMinimumAgeAccepted(int age)
        {
            if (age < CounterAgePerson.MINIMAL_AGE_ALLOW)
            {
                throw new ArgumentException(
                    $"You must enter a age equal or bigger than {CounterAgePerson.MINIMAL_AGE_ALLOW}.");
            }
        }

        private void ThrowErrorIfBiggerThanMaximalAgeAccepted(int age)
        {
            if (age > CounterAgePerson.MAXIMAL_AGE_ALLOW)
            {
                throw new ArgumentException(
                    $"You must enter an age bellow or equal than {CounterAgePerson.MAXIMAL_AGE_ALLOW}.");
            }
        }

        private bool IsThereAlreadyRegisteredPerson()
        {
            return this._agePeople[0] != 0;
        }

        private void MakeAgeCountIfHasNotBeenDone()
        {
            if (!this._countHasBeenDone)
            {
                this.MakeAgeCount();
            }
        }
        private void ResetCounterHasBeenDone()
        {
            this._countHasBeenDone = false;
        }

        private bool IsAdult(int age)
        {
            return age > CounterAgePerson.LIMIT_AGE_YOUNG_ADULT;
        }
        
        private bool IsYoung(int age)
        {
            return age < CounterAgePerson.LIMIT_AGE_YOUNG_ADULT;
        }
        private bool IsTwentyYearsOld(int age)
        {
            return age == CounterAgePerson.LIMIT_AGE_YOUNG_ADULT;
        }

        private void InitializeCounters()
        {
            this._youngPeople = 0;
            this._twentyYearsOldPeople = 0;
            this._adultPeople = 0;
        }

        private int GetHowManyPeople()
        {
            return this._agePeople.Length;
        }
    }
}