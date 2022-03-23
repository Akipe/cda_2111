using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCereals.Models
{
    public class Cereal
    {
        private const short NULL_VALUE = -1;
        private short? _carbo;
        private short? _sugars;
        private short? _potass;

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [StringLength(64, MinimumLength = 3)]
        //[Index]
        //[RegularExpression(@"^\p{L}{2,32}$")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le champs Calorise est requis")]
        [Range(1, 400)]
        public byte Calories { get; set; }

        [Required(ErrorMessage = "Le champs Protein est requis")]
        [Range(1, 6)]
        public byte Protein { get; set; }

        [Required(ErrorMessage = "Le champs Sodium est requis")]
        [Range(0, 400)]
        public ushort Sodium { get; set; }

        [Required(ErrorMessage = "Le champs Fiber est requis")]
        [Range(0, 20)]
        public byte Fiber { get; set; }


        [Range(-1, 500)]
        public short? Carbo {
            get
            {
                return _carbo ?? NULL_VALUE;
            }
            set
            {
                _carbo = value ?? NULL_VALUE;
            }
        }
        
        [Range(-1, 50)]
        public short? Sugars {
            get
            {
                return _sugars ?? NULL_VALUE;
            }
            set
            {
                _sugars = value ?? NULL_VALUE;
            }
        
        }
        
        [Range(-1, 500)]
        public short? Potass {
            get
            {
                return _potass ?? NULL_VALUE;
            }
            set
            {
                _potass = value ?? NULL_VALUE;
            }
        }

        [Required(ErrorMessage = "Le champs Vitamins est requis")]
        [Range(0, 200)]
        public ushort Vitamins { get; set; }

        [Required(ErrorMessage = "Le champs Rating est requis")]
        [Range(0.0, 100.0)]
        public float Rating { get; set; }
    }
}
