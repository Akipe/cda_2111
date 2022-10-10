using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcfBlancCoursCore
{
    public enum Levels
    {
        [Display(Name = "Sans displome" )]
        InfoBac = 30,
        Bac = 40,
        BacPlus1 = 50,
        BacPlus2 = 60,
        BacPlus3 = 70,
        BacPlus4 = 80,
        BacPlus5 = 90,
        BacPlusPlus5 = 100,
    }
}
