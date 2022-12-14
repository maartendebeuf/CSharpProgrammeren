using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Klas.Models;
using MVC_Klas.Services;

namespace MVC_Klas.Controllers
{
    public class tbl_testController : Controller
    {
        //RepositoryTbl_testService
        private RepositoryTbl_testService _rtts;
        public tbl_testController(RepositoryTbl_testService repositoryTbl_TestService)
        {
            _rtts = repositoryTbl_TestService;
        }


        // GET: tbl_testController
        public ActionResult Index()
        {
            //Repository.Repository.RepositoryTestADO repositoryTest = new Repository.Repository.RepositoryTestADO();
            
            //DierRepository _repo = new DierRepository();
            return View(_rtts.GetItems());
        }

        // GET: tbl_testController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: tbl_testController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_testController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: tbl_testController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: tbl_testController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: tbl_testController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: tbl_testController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
