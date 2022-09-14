using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtProgrammeren
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  
             *  Neem een positief geheel getal n dat gevraagd wordt aan de gebruiker. 
             *  Als n even is, deel n door 2 om n / 2 te krijgen. 
             *  Als n oneven is, vermenigvuldig dan n met 3 en voeg 1 toe om 3n + 1 te krijgen. 
             *  Herhaal dit tot we de waarde 1 verkrijgen. 
             *  Het vermoeden luidt dat het niet uitmaakt met welk nummer je begint, je zult uiteindelijk altijd 1 bereiken.

            Neem een getal n, geef het aantal stappen terug dat vereist is om 1 te bereiken aan de hand van bovenstaand algoritme.

            Reageer correct op verkeerde input.

            Let op:

            - n is een positief geheel getal
            - Indien n = 1, dan kan het algoritme niet uitgevoerd worden en is het aantal stappen gelijk aan 0.
            */
            bool geldigGetal = true;
            do
            {
                try
                {

                    Console.Write("Geef positief getal in: ");
                    var getal = int.Parse(Console.ReadLine());
                    var startwaarde = getal;
                    var aantalStappen = 0;
                    if (getal<=0)
                    {
                        Console.WriteLine($"\nHet algoritme kan niet worden uitgevoerd. Je gaf nul of een negatief nummer in.\nprobeer het nog eens.\n");
                        geldigGetal = false;
                    }
                    else if(getal == 1)
                    {
                        Console.WriteLine($"\nHet algoritme kan niet worden uitgevoerd. Het aantal stappen is gelijk aan {aantalStappen}.\nprobeer het nog eens.\n");
                        geldigGetal = false;
                    }
                    else if (getal != 1)
                    {
                        Console.WriteLine("-------------------------");
                        while (getal != 1)
                        {
                            if (getal % 2 == 0)
                            {

                                getal /= 2;
                            }
                            else if (getal % 2 != 0)
                            {
                                getal = (getal * 3) + 1;
                            }
                            aantalStappen++;
                            Console.WriteLine(aantalStappen + ". " + getal);

                        }
                        Console.WriteLine($"\nAntwoord: {aantalStappen} stappen. " +
                            $"Dus voor de waarde n = {startwaarde} is de uitkomst {aantalStappen} stap(pen).");
                        Console.ReadLine();
                        geldigGetal = true;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nJe gaf een verkeerd teken in.\nprobeer het nog eens.\n");
                    geldigGetal = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nJe gaf een te grote waarde in.\nprobeer het nog eens.\n");
                    geldigGetal = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nJe gaf geen geldig getal in.\nprobeer het nog eens.\n");
                    geldigGetal = false;
                }
            } while (!geldigGetal);
                        
        }
    }
}
