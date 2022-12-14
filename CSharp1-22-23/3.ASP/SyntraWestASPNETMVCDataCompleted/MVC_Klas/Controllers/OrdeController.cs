using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Klas.Models;

namespace MVC_Klas.Controllers
{
    public class OrdeController : Controller
    {
        // GET: OrdeController
        public ActionResult Index()
        {
            OrdeRepository ordeRepository = new OrdeRepository();
            return View(ordeRepository.GetAll());
        }

        // GET: OrdeController/Details/5
        public ActionResult Details(string naam)
        {
            OrdeRepository ordeRepository = new OrdeRepository();
            Orde orde = ordeRepository.GetByNaam(naam);

            return View(orde);
        }

        // GET: OrdeController/Create
        public ActionResult Create()
        {     
             return View();           
            
        }

        // POST: OrdeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Orde orde)
        {
            try
            {
                Orde newOrde = orde;
                OrdeRepository ordeRepository = new OrdeRepository();
                ordeRepository.AddOrde(newOrde);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }

        }

        // GET: OrdeController/Edit/5
        public ActionResult Edit(string naam)
        {
            OrdeRepository ordeRepository = new OrdeRepository();
            Orde orde = ordeRepository.GetByNaam(naam);
            return View(orde);
        }

        // POST: OrdeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Orde orde)
        {
            try
            {
                Orde newOrde = orde;
                OrdeRepository ordeRepository =new OrdeRepository();
                ordeRepository.UpdateOrde(newOrde);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdeController/Delete/5
        public ActionResult Delete(string naam)
        {
            OrdeRepository ordeRepository = new OrdeRepository();

            return View(ordeRepository.GetByNaam(naam));
        }

        // POST: OrdeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Orde orde)
        {
            try
            {
                OrdeRepository ordeRepository = new OrdeRepository();
                ordeRepository.DeleteFamilie(orde.Naam);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
