using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._1.Basics.Classes
{
    public interface IChildClass
    {
        // Interface met properties Naam en Leeftijd. Een interface heeft geen implementaties.
        // Hier kan nog een diepere klasse toegevoegd worden door overerving, die ook IIdentifiable is
        // en dus de properties van bovengenoemde interfaces overerft.

        string Type { get; }
        string CildType();
    }
}
