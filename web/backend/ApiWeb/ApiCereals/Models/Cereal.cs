using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCereals.Models
{
    public class Cereal
    {
        private const int NULL_VALUE = -1;
        private const int MIN_SPEC_VALUE = NULL_VALUE;
        private const int MAX_SPEC_VALUE = 500;

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 3)]
        //[Index]
        [RegularExpression(@"^[^_]+$", ErrorMessage = "Le format du nom ne doit pas contenir les caractères '_'")]
        public string Name { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Calories { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Protein { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Sodium { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Fiber { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Carbo { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Sugars { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Potass { get; set; }

        [Required]
        [Range(MIN_SPEC_VALUE, MAX_SPEC_VALUE)]
        public int Vitamins { get; set; }

        [Required]
        [Range(0.0, 100.0)]
        public double Rating { get; set; }
    }
}
