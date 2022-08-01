using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcfBlancCoursCore
{
    public class JobSeeker // Modèle
    {
        private static int lastId = 0;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Levels Level { get; set; }

        public int RegistrationYear { get; set; }

        public string? LastDiplomaName { get; set; }

        public int? LastDiplomaYear { get; set; }

        public string Employability { get { return ((int)Level) + "%"; } }


        public JobSeeker()
        {
            Id = ++lastId;
        }

        public JobSeeker(JobSeeker other)
        {
            FirstName = other.FirstName;
            LastName = other.LastName;
            RegistrationYear = other.RegistrationYear;
            Level = other.Level;
            LastDiplomaName = other.LastDiplomaName;
            LastDiplomaYear = other.LastDiplomaYear;
            Id = other.Id;
        }
    }
}