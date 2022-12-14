using MVC_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Repository
{
    internal interface IRepositoryTest
    {
        // nu is de klasse enkel voor test maar dit kan ook generic
        List<tbl_test> GetItems();
        string GetItemById(int id);
        void AddItem(Models.tbl_test item);
        void DeleteItem(int id);
    }
}
