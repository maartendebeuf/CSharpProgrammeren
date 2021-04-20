using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class Smartphone : IBellen, ISurfen
    {
        public void Bellen(string telefoonnummer)
        {
            Console.WriteLine($"Bellen... [{telefoonnummer}]");
        }

        public void Surfen(string url)
        {
            Console.WriteLine($"Laden website... [{url}]");
        }
    }
}
