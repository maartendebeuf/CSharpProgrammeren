using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Klas.Interface;
using MVC_Klas.Models;

namespace MVC_Klas.Controllers
{
    public class FamilieController : Controller
    {
        FamilieRepository _familieRepo;
        OrdeRepository _ordeRepo;
        IKlasseRepository _klasseRepo;

        public FamilieController(FamilieRepository familieRepository, IKlasseRepository klasseRepository, OrdeRepository ordeRepository)
        {
            _familieRepo = familieRepository;
            _ordeRepo = ordeRepository;
            _klasseRepo = klasseRepository;
        }

        public IActionResult Index()
        {
            var result = _familieRepo.GetAll();
            return View(result);
        }

        public ActionResult Details(string naam)
        {
            Familie x = _familieRepo.GetByNaam(naam);
            return View(x);
        }

        public ActionResult Create()
        {
            ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
            ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Familie familie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Familie x = familie;
                    if (_familieRepo.AddFamilie(x))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                        ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                        ModelState.AddModelError("Naam", "Naam van familie bestaat al.");
                        return View(familie);
                    }
                }
                else
                {
                    ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                    ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                    return View(familie);
                    //return RedirectToAction(nameof(Index));
                    //return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(string naam)
        {
            Familie x = _familieRepo.GetByNaam(naam);

            ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
            ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });

            return View(x);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Familie familie)
        {
            try
            {
                Familie x = familie;
                _familieRepo.UpdateFamilie(x);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                return View(familie);
            }
        }

        public ActionResult Delete(string naam)
        {
            return View(_familieRepo.GetByNaam(naam));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Familie familie)
        {
            try
            {
                _familieRepo.DeleteFamilie(familie.Naam);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
