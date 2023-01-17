using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Dier
    {
        [Required(AllowEmptyStrings = false)]
        public string Benaming { get; set; }
        [StringLength(40, ErrorMessage = "Het aantal karakters moet tussen 1 en 40 liggen", MinimumLength = 1)] 
        public string Familie { get; set; }
        [Range(1, 1000)]
        public int AantalPoten { get; set; }
        public Familie FamilieObject { get; set; }
        public bool Gevaarlijk { get; set; }
    }
}
