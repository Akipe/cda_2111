using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCereals.Models
{
    public class Cereal
    {
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

        [Required(ErrorMessage = "Le champs Carbo est requis")]
        [Range(-10, 500)]
        public short Carbo { get; set; }
        
        [Required(ErrorMessage = "Le champs Sugars est requis")]
        [Range(-10, 50)]
        public short Sugars { get; set; }
        
        [Required(ErrorMessage = "Le champs Potass est requis")]
        [Range(-10, 500)]
        public short Potass { get; set; }

        [Required(ErrorMessage = "Le champs Vitamins est requis")]
        [Range(0, 200)]
        public ushort Vitamins { get; set; }

        [Required(ErrorMessage = "Le champs Rating est requis")]
        [Range(0.0, 100.0)]
        public float Rating { get; set; }
    }
}
