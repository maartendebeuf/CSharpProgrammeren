using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVC_Klas.Interfaces;

namespace MVC_Klas.Models
{
    public class DierRepository: IDierRepository
    {
        public int Counter { get; set; }

        private FamilieRepository _repoFamilie;


        public DierRepository(FamilieRepository familieRepository) {
            _repoFamilie = familieRepository;
            Counter = 0;
            if(Globals._Dieren == null)
            {
                Globals._Dieren = new List<Dier>();
                Dier x = new Dier();
                x.Benaming = "Hamster";
                x.Familie = "Knaagdieren";
                x.Gevaarlijk = false;
                Globals._Dieren.Add(x);

                x = new Dier();
                x.Benaming = "Tijger";
                x.Familie = "Katachtigen";
                x.Gevaarlijk = true;
                Globals._Dieren.Add(x);

                x = new Dier();
                x.Benaming = "Slang";
                x.Familie = "Reptielen";
                x.Gevaarlijk = true;
                Globals._Dieren.Add(x);

                x = new Dier();
                x.Benaming = "Hond";
                x.Familie = "Honden";
                x.Gevaarlijk = false;
                Globals._Dieren.Add(x);

                x = new Dier();
                x.Benaming = "Britse korthaar";
                x.Familie = "Katachtigen";
                x.Gevaarlijk = false;
                Globals._Dieren.Add(x);

            }
        } 

        public List<Dier> GetAll() {
            //return Globals._Dieren.Join(Globals._Families, dier => dier.Familie, familie => familie.Naam, (dier, familie) => { dier.FamilieObject = familie; return dier; }).ToList(); 
            //return Globals._Dieren.Join(Globals._Families, dier => dier.Familie, familie => familie.Naam, ParseDier).ToList(); 

            foreach (var item in Globals._Dieren)
            {
                item.FamilieObject = _repoFamilie.GetByNaam(item.Familie);
            }

            return Globals._Dieren;
        }

        private Dier ParseDier(Dier dier, Familie familie) 
        {
            dier.FamilieObject = familie;
            return dier;
        }

        public Dier GetByBenaming(string benaming)
        {
            return Globals._Dieren.Find(e => e.Benaming == benaming);
        }

        public void UpdateDier(Dier dier)
        {
            Dier aantepassen = GetByBenaming(dier.Benaming);
            if (aantepassen != null)
            {
                Globals._Dieren.Remove(aantepassen);
                aantepassen = dier;
                Globals._Dieren.Add(aantepassen);
            }
        }

        public bool AddDier(Dier dier)
        {
            if (GetByBenaming(dier.Benaming) == null)
            {
                Globals._Dieren.Add(dier);
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
                Globals._Dieren.Remove(te_verwijderen);
            }
        }
    }
}
