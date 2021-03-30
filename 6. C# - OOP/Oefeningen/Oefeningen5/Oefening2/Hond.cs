using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening2
{
    public class Hond : Dier
    {
        public override string Type { get; } = "Hond";
        private string geluid = "Woef Woef";
        public Hond(string naam, int leeftijd, string geslacht)
            : base( naam,  leeftijd, geslacht)
        {
        }
        public override void PrintGeluid()
        {
            MessageBox.Show(geluid);
        }
    }
}
