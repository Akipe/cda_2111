using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Persons
{
    public class JobSeeker : Person
    {
        public readonly int registrationYear;
        public Formation formation;
        public string diplomaName;
        public int diplomaYear;

        public JobSeeker(
            string firstName,
            string lastName,
            int registrationYear,
            Formation formation,
            string diplomaName,
            int diplomaYear
        ) : base(firstName, lastName) 
        {
            this.registrationYear = registrationYear;
            this.formation = formation;
            this.diplomaName = diplomaName;
            this.diplomaYear = diplomaYear;

            GenerateID();
        }

        public Guid Id
        {
            get; private set;
        }

        private void GenerateID()
        {
            Guid uuid = Guid.NewGuid();

            Id = uuid;
        }
    }
}
