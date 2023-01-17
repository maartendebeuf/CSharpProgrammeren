using MVC_Klas.Models;

namespace MVC_Klas.Interfaces
{
    public interface IDierRepository
    {
        //IDierRepository(FamilieRepository familieRepository);
        List<Dier> GetAll();
        //Dier ParseDier();
        Dier GetByBenaming(string benaming);
        void UpdateDier(Dier dier);
        bool AddDier(Dier dier);
        void DeleteDier(string benaming);
    }
}
