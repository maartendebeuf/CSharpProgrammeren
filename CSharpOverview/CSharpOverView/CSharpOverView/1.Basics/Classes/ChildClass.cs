using CSharpOverView._1.Basics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.Classes
{
    internal class ChildClass:BaseClass, IChildClass
    {
        // : base() verwijst naar de constructor in de superklasse
        public ChildClass(string naam) : base(naam)
        {

        }
        public string Type { get; }

        // : this() verwijst naar de constructor in de eigenklasse
        public ChildClass(string naam, string type) : this(naam)
        {
            Type = type;
        }
        public string CildType()
        {
            //verwijst naar een methode in de superclass
            return base.Type();
        }

        //* **Superklasse:** methode of property voorzien van het keyword   **_virtual_**   Merkt de methode of property als overschrijfbaar
        //*  **Subklasse:**  methode of property voorzien van het keyword   **_override_**  Laat de compiler weten dat het een nieuwe implementatie is van een bestaande methode of property
        internal override string Type2()
        {
            return "Methode om te overschrijven in subklasse";
        }
    }
}

