using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Klas.Models
{
    [Table("DierenLijst")]
    public class Dier
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Benaming { get; set; }
        //[StringLength(40, ErrorMessage = "Het aantal karakters moet tussen 1 en 40 liggen", MinimumLength = 1)] 
        [ForeignKey("Familie")]
        public int FamilieID { get; set; }
        [Range(1, 1000)]
        public int AantalPoten { get; set; }
        public Familie Familie { get; set; }
        [Column("GevaarlijkNaam")]
        public bool Gevaarlijk { get; set; }
        [Column("GeslachtNaam")]
        public string Geslacht { get; set; }
        public string Kleur { get; set; }
    }
}
