using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes4_2
{

    //● Maak de klasse “Movie”
    //● Properties: Name, Producer, Rating, Director, ReleaseDate
    //● Maak voldoende demo data aan om je queries te kunnen testen
    //● Maak volgende queries (in beide syntaxen)
    //    ○ Toon alle films uit 2010
    //    ○ Toon alle films met een rating tussen 4 en 6
    //    ○ Toon alle films van de regiseur "Steven Spielberg"
    //    ○ Toon het aantal films per regiseur
    //    ○ Toon het aantal films per producer
    //    ○ Toon de gemiddelde rating van een film voor elk jaar
    public class Movie
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Rating { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
