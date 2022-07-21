using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Persons
{
    public class JobSeeker : Person
    {
        private int RegistrationYear;
        private Formation Formation;
        private int DiplomaName;
        private int DiplomaYear;

        public int Id
        {
            get => default;
            set
            {
            }
        }
    }
}
