using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverViewWPF._3.AdvancedDotNet.Generic
{
    public class CarFactory<T> where T : Car, new()
        //T meegeven om aan te geven dat Class generic is
        //T moet een Car zijn
        // new bijzetten om een nieuwe instantie aan te kunnen maken van T
    {
        public List<T> Cars { get; set; }

        public CarFactory()
        {
            Cars = new List<T>();
            T skoda = new T(); // als new() niet in de namespace staat kan je dit niet doen
        }

        public void AddCar(T car)
        {
            Cars.Add(car);
        }

        public double GetAverageHorsePower()
        {
            return Math.Round(Cars.Average(e => (double)e.HorsePower), 2);
        }
    }
}
