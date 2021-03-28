using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening2
{
    public class Kikker : Dier
    {
        private string geluid = "Kwaak";

        public Kikker(string naam, int leeftijd, string geslacht)
            : base(naam, leeftijd, geslacht)
        {

        }
        public override void PrintGeluid()
        {
            MessageBox.Show(geluid);
        }
    }
}
