
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverViewWPF._3.AdvancedDotNet.Generic
{
    internal class Program
    {
        public void Main()
        {

            var audiFactory = new CarFactory<Audi>();
            var skodaFactory = new CarFactory<Skoda>();

            audiFactory.AddCar(new Audi() { CarName = "A4", HorsePower = 110 });
            audiFactory.AddCar(new Audi() { CarName = "A5", HorsePower = 150 });
            audiFactory.AddCar(new Audi() { CarName = "A3", HorsePower = 100 });
            audiFactory.AddCar(new Audi() { CarName = "Q7", HorsePower = 300 });

            Console.WriteLine("Average audi horsepower: " + audiFactory.GetAverageHorsePower());

            skodaFactory.AddCar(new Skoda() { Name = "Octavia", HorsePower = 110 });
            skodaFactory.AddCar(new Skoda() { Name = "Superb", HorsePower = 150 });
            skodaFactory.AddCar(new Skoda() { Name = "Enyaq", HorsePower = 125 });

            Console.WriteLine("Average skoda horsepower: " + skodaFactory.GetAverageHorsePower());

            Console.ReadKey();
        }
    }
}
