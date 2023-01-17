using MVC_Klas.Models;

namespace MVC_Klas.Interfaces
{
    public interface IFamilieRepository
    {
        List<Familie> GetAll();
        
        Familie GetByNaam(string naam);

        bool AddFamilie(Familie familie);

        void UpdateFamilie(Familie familie);

        void DeleteFamilie(string naam);
    }
}
