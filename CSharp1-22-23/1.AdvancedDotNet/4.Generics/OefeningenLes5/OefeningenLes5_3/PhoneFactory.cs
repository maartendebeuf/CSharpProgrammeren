using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes5_3
{
    internal class PhoneFactory<T> where T : Phone
    {
        public List<T> Phones { get; set; } = new List<T>();

        public void AddPhone(T phone)
        {
            //add phone
            Phones.Add(phone);
        }
        public void RemovePhone(T phone)
        {
            //remove phone
            Phones.Remove(phone);
        }  
        public double GetAveragePrice()
        {
            // return the average price

            return Phones.Average(x=>x.Price);
        }
        public double GetBiggestScreenSize()
        {
            // return the largest screen size
            return Phones.Max(x=>x.Screensize);
        }
        public int GetLowestCameraCount()
        {
            //Returne the smalest Camera Count
            return Phones.Min(x=>x.CameraCount);
        }
    }
}
