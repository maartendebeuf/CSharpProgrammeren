using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.Classes
{
    internal class BaseClass
    {
        public string Naam { get; set; }
        public BaseClass(string naam)
        {
            Naam = naam;
        }
        internal string Type()
        {
            return "Methode om over te erven in subklasse";
        }

        //* **Superklasse:** methode of property voorzien van het keyword   **_virtual_**   Merkt de methode of property als overschrijfbaar
        //*  **Subklasse:**  methode of property voorzien van het keyword   **_override_**  Laat de compiler weten dat het een nieuwe implementatie is van een bestaande methode of property
        internal virtual string Type2()
        {
            return "Methode om te overschrijven in subklasse";
        }
    }

}
