using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2
{
    //Voorzie een applicatie die vraagt hoeveel elementen een lijst bevat en vraag dit aantal waardes (van hetzelfde type) aan de gebruiker. 
    //Nadat alle elementen gevraagd zijn, geeft de gebruiker twee indexes in.\
    //Maak een generieke methode die een lijst van een specifiek, niet vooraf gedefinieerd type verwacht en twee indexes. 
    //Gebruik deze indexes om de overeenkomende elementen te wisselen van plaats. Print daarna de lijst uit.
    class App
    {

        public List<T> Input<T>(List<T> input, int index1, int index2)
        {
            T indexwaarde1 = input[index1];
            input[index1] = input[index2];
            input[index2] = indexwaarde1;

            return input;
        }
    }
}
