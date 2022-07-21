using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.Core.Persons;

namespace TrouveEmploi.Core.Validator
{
    public static class IdValidator
    {
        public static bool HasValidId(JobSeeker jobSeeker)
        {
            foreach(JobSeeker alreadyStore in JobSeekerManager.users)
            {
                if (String.Equals(
                    jobSeeker.Id.ToString(),
                    alreadyStore.Id.ToString()
                ))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
