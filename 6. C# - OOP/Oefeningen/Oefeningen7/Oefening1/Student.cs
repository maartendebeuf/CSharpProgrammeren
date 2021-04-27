using System;
using System.Collections.Generic;
using System.Text;

namespace Oefeningen1
{

    class Student
    {
        public Student(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
            AantalGebruikers++;
        }

        public static int AantalGebruikers { get; set; }
        
        public string Voornaam { get; set; }
        public string Naam { get; set; }

    }
}
