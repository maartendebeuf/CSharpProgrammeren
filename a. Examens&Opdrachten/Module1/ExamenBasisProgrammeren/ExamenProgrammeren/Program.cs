using System;
using System.Collections.Generic;

namespace ExamenProgrammeren
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Maak een applicatie die de gebruiker vraagt om een array (geen List!) op te vullen met getallen en daarna een extra getal toevoegt op een bepaalde positie. 

            Vraag aan de gebruiker hoeveel getallen er initieel ingegeven zullen worden en vul de lijst op. Vraag daarna een positie en een nieuw getal. 
            De positie is index + 1, met andere woorden: positie = 1, index = 0. 
            Voeg het getal toe aan de array op de index en verplaats alle getallen vanaf die index een positie verder (van i naar i+1). 
            Zorg ervoor dat er geen getal verdwijnt. 
            Als je lijst drie getallen bevat, is het mogelijk om een getal aan het einde toe te voegen door positie 4 mee te geven en bevat je resultaat dus vier getallen.
            Toon daarna de aangepaste lijst.
            De gebruiker kan getallen blijven toevoegen aan de array tot het woord stop getypt wordt.

            Voorzie ook de nodige controles en vang mogelijke fouten op!


            Uitbreiding 

            Met onderstaande uitbreiding kan je maximaal twee punten extra verdienen. Je verliest echter geen punten als je de uitbreiding niet oplost.

            Kan je een tweede oplossing voorzien die deze keer wel gebruik maakt van een List? Ik verwacht hierdoor dus twee verschillende oplossingen (array en list).  
              
            */
            
            bool geldigAantal = true;
            do
            {
                try
                {

                    Console.Write("geef het aantal in die de lijst initieel zal bevatten: ");
                    var aantalGetallen = int.Parse(Console.ReadLine());
                    //List<int> getallenlijst2 = new List<int>();
                    if (aantalGetallen <= 0)
                    {
                        Console.WriteLine($"\nMet {aantalGetallen} kan geen lijst gemaakt worden.\n");
                        geldigAantal = false;
                    }
                    else
                    {
                        geldigAantal = true;
                        int[] getallenlijst = new int[aantalGetallen + 1];  
                        for (int i = 0; i < aantalGetallen; i++)
                        {
                            bool geldigGetal = true;
                            do
                            {                                
                                try
                                {
                                    Console.Write($"geef getal {i + 1} in: ");
                                    var getal = int.Parse(Console.ReadLine());
                                    getallenlijst[i] = getal;
                                    //getallenlijst2.Add(getal);
                                    geldigGetal = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nJe gaf een verkeerd teken in.\n");
                                    geldigGetal = false;
                                    
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine("\nJe gaf een te grote waarde in.\n");
                                    geldigGetal = false;
                                    
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nJe gaf geen geldig getal in.\n");
                                    geldigGetal = false;
                                    
                                }


                            } while (!geldigGetal);
                        }
                        bool geldigePlaats = true;
                        do
                        {
                            try
                            {
                                geldigePlaats = true;
                                Console.Write("Geef de positie van het in te voegen getal in: ");
                                var positie = int.Parse(Console.ReadLine());
                                Console.Write("Geef de waarde in die je wil invoegen: ");
                                var extraGetal = int.Parse(Console.ReadLine());
                                var verplaatsPositie = aantalGetallen;
                                if (positie<=0)
                                {
                                    Console.WriteLine("\nJe gaf geen geldige waarde in voor de positie of de waarde.\n");
                                    geldigePlaats = false;
                                }
                                else
                                {
                                    while (verplaatsPositie >= positie)
                                    {
                                        getallenlijst[verplaatsPositie] = getallenlijst[verplaatsPositie - 1]; 
                                        verplaatsPositie--;

                                        //bool EersteExtraCijfer = true;
                                        //if (EersteExtraCijfer)
                                        //{
                                        //    getallenlijst2.Add(getallenlijst2[verplaatsPositie - 1]);
                                        //    EersteExtraCijfer = false;
                                        //}
                                        //getallenlijst2[verplaatsPositie] = getallenlijst2[verplaatsPositie - 1];
                                    }
                                    if (verplaatsPositie <= positie)
                                    {
                                        getallenlijst[positie - 1] = extraGetal;
                                        //getallenlijst2[positie - 1] = extraGetal;
                                    }

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nJe gaf geen geldige waarde in voor de positie of de waarde.\n");
                                geldigePlaats = false;
                            }
                        } while (!geldigePlaats);
                        
                        Console.Write("\bUitvoer: ");
                        for (int i = 0; i < getallenlijst.Length; i++)
                        {
                            if (i +1 < getallenlijst.Length)
                            {
                                Console.Write(getallenlijst[i] + ",");
                            }
                            else
                            {
                                Console.Write(getallenlijst[i]);
                            }

                        }
                        //Console.WriteLine("\bUitvoer: ");
                        //for (int i = 0; i < getallenlijst2.Count; i++)
                        //{
                        //    if (i + 1 < getallenlijst2.Count)
                        //    {
                        //        Console.Write(getallenlijst2[i] + ",");
                        //    }
                        //    else
                        //    {
                        //        Console.Write(getallenlijst2[i]);
                        //    }

                        //}
                        Console.ReadLine();
                    }                    
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nJe gaf een verkeerd teken in.\n");
                    geldigAantal = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nJe gaf een te grote waarde in.\n");
                    geldigAantal = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nJe gaf geen geldig getal in.\n");
                    geldigAantal = false;
                }
            } while (!geldigAantal);   
        }
    }
}
