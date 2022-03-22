using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCereals.Models
{
    [Table("tata")]
    public class Cereal
    {
        [Key]
        public int Id { get; set; } // Norme MS

        [Required(ErrorMessage = "Le champs est requis")]
        [StringLength(32, MinimumLength = 2)]
        [RegularExpression(@"^\p{L}{2,32}$")]
        public string Name { get; set; }
    }
}
