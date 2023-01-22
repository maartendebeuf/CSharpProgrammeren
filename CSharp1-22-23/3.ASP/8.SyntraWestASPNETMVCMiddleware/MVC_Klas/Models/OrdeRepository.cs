using MVC_Klas.Services;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Klas.Models
{
    public class OrdeRepository
    {
        private KlasContext _klasContext;

        public OrdeRepository(KlasContext klasContext)
        {
            _klasContext = klasContext;
            //if (Globals._Ordes == null)
            //{
            //    Globals._Ordes = new List<Orde>();

            //    Globals._Ordes.Add(new Orde() { Naam = "Orde 1" });
            //    Globals._Ordes.Add(new Orde() { Naam = "Orde 2" });
            //}
        }

        public List<Orde> GetAll()
        {
            return _klasContext.Ordes.ToList();
            //return Globals._Ordes;
        }
    }
}
