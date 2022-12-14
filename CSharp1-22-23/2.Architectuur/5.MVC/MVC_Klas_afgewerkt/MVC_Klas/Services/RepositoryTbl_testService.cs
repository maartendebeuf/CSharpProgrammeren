using MVC_Klas.Models;
using Repository.Repository;

namespace MVC_Klas.Services
{
    public class RepositoryTbl_testService
    {
        public RepositoryTestADO _repo;
        public RepositoryTbl_testService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
            _repo = new RepositoryTestADO();
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        public IEnumerable<tbl_test> GetItems()
        {
            List<tbl_test> itemList = new List<tbl_test>();
            foreach (var item in _repo.GetItems())
            {
                tbl_test newTbl_Test = new tbl_test();
                newTbl_Test.Idx = item.Idx;
                newTbl_Test.Col1 = item.Col1;
                itemList.Add(newTbl_Test);
            }
            return itemList;
        }

    }
}
