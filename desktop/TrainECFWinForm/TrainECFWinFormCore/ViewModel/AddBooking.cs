using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainECFWinFormCore.ModelView
{
    public class AddBooking
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string lastName { get; set; }

        [Required]
        [MinLength(2)]
        public string bookStart { get; set; }

        [Required]
        [MinLength(2)]
        public string bookEnd { get; set; }

        [Required]
        [MinLength(2)]
        public string price { get; set; }
    }
}
