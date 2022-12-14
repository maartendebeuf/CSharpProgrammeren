using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Familie
    {
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }
        [StringLength(10, MinimumLength =100)]
        public string Orde { get; set; }//1
        
        public string Klasse { get; set; }//2

        public override string ToString()
        {
            return Naam;
        }
    }
}
