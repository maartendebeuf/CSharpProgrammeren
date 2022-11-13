using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_ADO.net.Repository
{
    public interface IRepositoryTest
    {
        List<string> GetItems();
        string GetItemById(int id);
        void AddItem(DB_Models.tbl_test item);
        void DeleteItem(int id);
    }
}
