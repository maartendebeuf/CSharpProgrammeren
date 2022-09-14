using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Arbeider : Werknemer
    {
        public int GepresteerdeUrenMaand { get; set; } = new int();

        public Arbeider(string voornaam, string naam)
            : base(voornaam, naam)
        {
        }
    }
}
