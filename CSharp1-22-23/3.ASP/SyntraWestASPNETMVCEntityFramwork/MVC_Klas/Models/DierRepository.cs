using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MVC_Klas.Services;

namespace MVC_Klas.Models
{
    public class DierRepository
    {
        private KlasContext _context;

        public DierRepository(KlasContext context) {
            _context = context; 
            //if(Globals._Dieren == null)
            //{
            //    Globals._Dieren = new List<Dier>();
            //    Dier x = new Dier();
            //    x.Benaming = "Hamster";
            //    //x.Familie = "Knaagdieren";
            //    x.Gevaarlijk = false;
            //    Globals._Dieren.Add(x);

            //    x = new Dier();
            //    x.Benaming = "Tijger";
            //    //x.Familie = "Katachtigen";
            //    x.Gevaarlijk = true;
            //    Globals._Dieren.Add(x);

            //    x = new Dier();
            //    x.Benaming = "Slang";
            //    //x.Familie = "Reptielen";
            //    x.Gevaarlijk = true;
            //    Globals._Dieren.Add(x);

            //    x = new Dier();
            //    x.Benaming = "Hond";
            //    //x.Familie = "Honden";
            //    x.Gevaarlijk = false;
            //    Globals._Dieren.Add(x);

            //    x = new Dier();
            //    x.Benaming = "Britse korthaar";
            //    //x.Familie = "Katachtigen";
            //    x.Gevaarlijk = false;
            //    Globals._Dieren.Add(x);

            //}
        } 

        public List<Dier> GetAll() {
            //return Globals._Dieren.Join(Globals._Families, dier => dier.Familie, familie => familie.Naam, (dier, familie) => { dier.FamilieObject = familie; return dier; }).ToList(); 
            //return Globals._Dieren.Join(Globals._Families, dier => dier.Familie, familie => familie.Naam, ParseDier).ToList(); 

            var result = _context.Dieren.Include(e => e.Familie).ToList();
            return result;

            //FamilieRepository _repo = new FamilieRepository();

            //foreach (var item in Globals._Dieren)
            //{
            //    item.FamilieObject = _repo.GetByNaam(item.Familie);
            //}

            //return Globals._Dieren;
        }

        private Dier ParseDier(Dier dier, Familie familie) 
        {
            //dier.FamilieObject = familie;
            return dier;
        }

        public Dier GetByBenaming(string benaming)
        {
            return _context.Dieren.Include(e => e.Familie).FirstOrDefault(e => e.Benaming == benaming);
            //return Globals._Dieren.Find(e => e.Benaming == benaming);
        }

        public void UpdateDier(Dier dier)
        {
            Dier aantepassen = GetByBenaming(dier.Benaming);
            if (aantepassen != null)
            {
                //_context.Database.BeginTransaction();

                aantepassen.AantalPoten = dier.AantalPoten;
                aantepassen.Gevaarlijk = dier.Gevaarlijk;
                aantepassen.Benaming = dier.Benaming;
                aantepassen.FamilieID = dier.FamilieID;
                _context.SaveChanges();

                //_context.Database.CommitTransaction();
            }
        }

        public bool AddDier(Dier dier)
        {
            if (GetByBenaming(dier.Benaming) == null)
            {
                //Globals._Dieren.Add(dier);
                _context.Dieren.Add(dier);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteDier(string benaming)
        {
            Dier te_verwijderen = GetByBenaming(benaming);
            if (te_verwijderen != null)
            {
                _context.Dieren.Remove(te_verwijderen);
                _context.SaveChanges();
                //Globals._Dieren.Remove(te_verwijderen);
            }
        }
    }
}
