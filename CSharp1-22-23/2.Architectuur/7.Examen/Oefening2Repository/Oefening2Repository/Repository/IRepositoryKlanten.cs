using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2Repository.Repository
{
    internal interface IRepositoryKlanten
    {
        void AddItem(Model.Klant item);
        List<Model.Klant> GetItems();
        string GetItemById(int id);
        void UpdateItem(Model.Klant item);
        void DeleteItem(int id);
    }
}
