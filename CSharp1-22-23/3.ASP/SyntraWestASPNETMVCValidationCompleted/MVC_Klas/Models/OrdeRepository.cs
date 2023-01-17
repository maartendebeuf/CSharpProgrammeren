using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Klas.Models
{
    public class OrdeRepository
    {
        public OrdeRepository()
        {
            if (Globals._Ordes == null)
            {
                Globals._Ordes = new List<Orde>();

                Globals._Ordes.Add(new Orde() { Naam = "Orde 1" });
                Globals._Ordes.Add(new Orde() { Naam = "Orde 2" });
            }
        }

        public List<Orde> GetAll()
        {
            return Globals._Ordes;
        }
    }
}
