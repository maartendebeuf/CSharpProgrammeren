using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Bediende : Werknemer
    {
        public int GepresteerdeDagenMaand { get; set; } = new int();

        public Bediende(string voornaam, string naam)
            : base(voornaam, naam)
        {            
        }

    }
}
