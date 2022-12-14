namespace MVC_Klas.Models
{
    public class Orde
    {
        public string Naam { get; set; }
        public string Klasse { get; set; }//2

        public override string ToString()
        {
            return Naam;
        }
    }
}
