using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Klas.Controllers
{
    public class DierenartsController : Controller
    {
        // GET: DierenartsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DierenartsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DierenartsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DierenartsController/Create
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

        // GET: DierenartsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DierenartsController/Edit/5
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

        // GET: DierenartsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DierenartsController/Delete/5
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
