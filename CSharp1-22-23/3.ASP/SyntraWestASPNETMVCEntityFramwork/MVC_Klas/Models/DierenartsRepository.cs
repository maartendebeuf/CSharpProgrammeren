using Microsoft.EntityFrameworkCore;
using MVC_Klas.Services;

namespace MVC_Klas.Models
{
    public class DierenartsRepository
    {
        private KlasContext _context;
        public DierenartsRepository(KlasContext context) 
        { 
            _context = context; 
        }
        public List<Dierenarts> GetAll()
        {
            return _context.Dierenartsen.Include(e => e.Familie).ToList();
            //return Globals._Families; 
        }

        public Dierenarts GetByNaam(string naam)
        {
            return _context.Dierenartsen.FirstOrDefault(e => e.Naam == naam);
            //return Globals._Families.Find(e => e.Naam == naam);
        }
    }
}
