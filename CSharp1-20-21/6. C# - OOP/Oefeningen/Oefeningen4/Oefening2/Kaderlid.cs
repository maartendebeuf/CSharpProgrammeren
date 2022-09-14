using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Kaderlid : Werknemer
    {
        public int GepresteerdeDagenMaand { get; set; } = new int();
        public Bedrijfswagen BedrijfswagenKaderlid { get; set; }

        public Kaderlid(string voornaam, string naam, string type)
            : base(voornaam, naam)  
        {
            BedrijfswagenKaderlid = new Bedrijfswagen(type);
        }
    }
}