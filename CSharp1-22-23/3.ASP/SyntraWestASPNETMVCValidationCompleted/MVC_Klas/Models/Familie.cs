using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Familie
    {
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }
        //[StringLength(30, MinimumLength = 10)]
        public string Orde { get; set; }
        [Display(Name = "Klasse naam")]
        public string Klasse { get; set; }
        [Range(1 ,10)]
        public int FamilieScore { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}
