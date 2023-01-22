using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Klas.Models
{
    public class Familie
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }
        //[StringLength(30, MinimumLength = 10)]
        [ForeignKey("Orde")]
        public int OrdeID { get; set; }
        public Orde Orde { get; set; }
        [Display(Name = "Klasse naam")]
        [ForeignKey("Klasse")]
        public int KlasseID { get; set; }
        public Klasse Klasse { get; set; }
        [Range(1 ,10)]
        public int FamilieScore { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}
