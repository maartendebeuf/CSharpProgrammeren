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
            : base()
        {
            SetNaam(voornaam, naam);
        }
        public override void SetNaam(string voornaam, string naam)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
        }
    }
}
