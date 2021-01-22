using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening7
{
    class Auto
    {
        //Maak een WPF-applicatie die een lijst van auto's aanmaakt. 
        //Zorg voor knoppen die methodes aanroept om de auto te laten starten, rijden, draaien (links en rechts). 
        //Iedere auto heeft ook een naam. Toon voor iedere actie een tekst die de actie beschrijft (vb. Auto X start).

        public string autoNaam = string.Empty;
        private bool gestart = false;

        public void Nieuw(string inpAutoNaam)
        {
            string nieuweAuto = inpAutoNaam;
            autoNaam = nieuweAuto;
            MessageBox.Show($"De {autoNaam} is toegevoegd aan de garage.");

        }
        public void Start()
        {
            MessageBox.Show($"De {autoNaam} is gestart.");
            gestart = true;
        }
        public void Vooruit()
        {
            MessageBox.Show($"De {autoNaam} rijdt vooruit.");
        }
        public void Links()
        {
            MessageBox.Show($"De {autoNaam} draait naar links.");
        }
        public void Rechts()
        {
            MessageBox.Show($"De {autoNaam} draait naar rechts.");
        }
        public bool Gestart()
        {
            return gestart;
        }
    }
}
