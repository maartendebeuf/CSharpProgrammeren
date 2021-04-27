using System;

namespace Oefeningen1
{
    class Program
    {
        //Voorzie een klasse `Student` met een property naam. 
        //Hou in diezelfde klasse bij hoeveel keer een student is aangemaakt. 
        //Je mag de waarde **niet** buiten de klasse berekenen of bewaren.\
        //Na het aanmaken van vier studenten hebben we vier objecten en bevat een student dus *iets* met waarde 4.

        static void Main(string[] args)
        {
            Student student1 = new Student("Maarten", "De Beuf");
            Student student2 = new Student("Lyen", "De Beuf");
            Student student3 = new Student("Kim", "Stichelbout");
            Console.WriteLine(Student.AantalGebruikers);
        }
    }
}
