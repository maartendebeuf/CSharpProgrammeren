using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_MD.Controllers
{
    public class DierController : Controller
    {
        // GET: DierController
        public ActionResult Index()
        {
            //return "Hier komen de dieren";
            return View();
        }

        // GET: DierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DierController/Edit/5
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

        // GET: DierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DierController/Delete/5
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
