using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic;
using MVC_Klas.Models;
using MVC_Klas.Services;

namespace MVC_Klas.Controllers
{
    public class DierController : Controller
    {

        // GET: DierController
         public ActionResult Index()
        //public string Index()
        {
               DierRepository _repo= new DierRepository();
               return View(_repo.GetAll());

            //return "Hier komen de dieren";
        }

        // GET: DierController/Details/5
        public ActionResult Details(string benaming)
        {
            DierRepository _repo = new DierRepository();
            Dier x = _repo.GetByBenaming(benaming);

            return View(x);
        }

        // GET: DierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DierController/Create
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

        // GET: DierController/Edit/5
        public ActionResult Edit(string benaming)
        {
            DierRepository _repo = new DierRepository();
            Dier x = _repo.GetByBenaming(benaming);

            return View(x);
        }

        // POST: DierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
       // public ActionResult Edit(string benaming, IFormCollection collection)
        public ActionResult Edit(Dier dier)
        {
            try
            {
                Dier x = dier;
                DierRepository _repo =   new DierRepository();
                _repo.UpdateDier(x);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DierController/Delete/5
        public ActionResult Delete(string benaming)
        {
            DierRepository _repo = new DierRepository();

            return View(_repo.GetByBenaming(benaming));
        }

        // POST: DierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Dier dier)
        {
            try
            {
                DierRepository _repo = new DierRepository();
                _repo.DeleteDier(dier.Benaming);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
