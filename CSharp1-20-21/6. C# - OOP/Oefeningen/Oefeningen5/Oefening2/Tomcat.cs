using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Tomcat : Kat
    {
        public override string Type { get; } = "Tomcat";
        public Tomcat(string naam, int leeftijd)
               : base(naam, leeftijd, "mannetje")
        {

        }
    }
}
