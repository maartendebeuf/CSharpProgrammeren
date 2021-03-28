using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening2
{
    public abstract class Kat : Dier
    {
        private string geluid = "Miauw";

        public Kat(string naam, int leeftijd, string geslacht)
            : base(naam, leeftijd, geslacht)
        {

        }
        public override void PrintGeluid()
        {
            MessageBox.Show(geluid);
        }
    }
}
