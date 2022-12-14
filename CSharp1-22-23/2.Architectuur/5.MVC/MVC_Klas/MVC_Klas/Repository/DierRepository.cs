using MVC_Klas.Models;

namespace MVC_Klas.Repository
{
    public class DierRepository
    {
        public DierRepository()
        {
            if (Globals._Dieren == null)
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

        public List<Dier> GetAll()
        {
            return Globals._Dieren.ToList();
        }

        public Dier GetByBenaming(string benaming)
        {

            return Globals._Dieren.Find(e => e.Benaming == benaming);

        }

    }
}
