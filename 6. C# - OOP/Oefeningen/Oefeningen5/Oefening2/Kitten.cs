using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening2
{
    public class Kitten : Kat
    {
        public Kitten(string naam, int leeftijd)
            : base(naam, leeftijd, "vrouwtje")
        {

        }
    }
}
