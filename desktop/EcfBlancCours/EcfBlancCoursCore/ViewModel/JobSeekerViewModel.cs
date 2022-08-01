using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EcfBlancCoursCore.ViewModel
{
    public class JobSeekerViewModel: JobSeeker
    { 
        private readonly Regex regexNames = new Regex(@"^[a-zA-Z]+(?:\s[a-zA-Z]+)*$");
        private readonly Regex regexDiploma = new Regex(@"^[^\?<>]+$");

        public bool IsValid()
        {
            RegistrationYear = DateTime.Now.Year;

            if (IsValidLastDiplomaName() && IsValidLastDiplomaYear())
            {
                if (String.IsNullOrEmpty(LastDiplomaName) && LastDiplomaYear is not null)
                {
                    throw new InvalidDataException("Le nom du diplome est requis si l'année du diplome est défini.");
                }
                if (!String.IsNullOrEmpty(LastDiplomaName) && LastDiplomaYear is null)
                {
                    throw new InvalidDataException("L'année du diplome est requis si le nom du diplome est défini.");
                }
            }

            return 
                IsValidFirstName() &&
                IsValidLastName() &&
                IsValidLastDiplomaYear() &&
                IsValidLastDiplomaYear()
            ;
        }

        public bool IsValidFirstName()
        {
            return regexNames.IsMatch(FirstName);
        }

        public bool IsValidLastName()
        {
            return regexNames.IsMatch(LastName);
        }

        public bool IsValidLastDiplomaYear()
        {
            return LastDiplomaYear is null || (
                LastDiplomaYear > RegistrationYear - 60
                && LastDiplomaYear < RegistrationYear + 2)
            ;
        }

        public bool IsValidLastDiplomaName()
        {
            return String.IsNullOrEmpty(LastDiplomaName) || regexDiploma.IsMatch(LastDiplomaName);
        }
    }
}
