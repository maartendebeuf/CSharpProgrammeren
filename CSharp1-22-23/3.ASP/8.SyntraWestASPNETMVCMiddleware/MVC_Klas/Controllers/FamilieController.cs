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
        //rechts klikken op methode om View toe te voegen
        public IActionResult Index()
        {
            var result = _familieRepo.GetAll();
            return View(result);
        }
        //string ipv int omdat we in de (index)view de naam terug koppelen
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
        public ActionResult Create(Familie familie)//check code side
        {
            try
            {
                //validatie van dubbele waardes via repo en zo de check terug te koppelen met client
                if (ModelState.IsValid)
                {
                    Familie x = familie;
                    if (_familieRepo.AddFamilie(x))//checkt Familie nog niet bestaat en returnt true
                    {
                        return RedirectToAction(nameof(Index));//keer terug naar de index view
                        
                    }
                    else
                    {
                        ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                        ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                        ModelState.AddModelError("Naam", "Naam van familie bestaat al.");
                        return View(familie);// return (create) view met ingevulde waardes
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
            //viewdata ophalen van geselecteerde element
            Familie x = _familieRepo.GetByNaam(naam);
            //ViewBag.Ordes en klasses vullen om mee te geven in de View
            ViewBag.Klasses = _klasseRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
            ViewBag.Ordes = _ordeRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });

            return View(x);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Familie familie)//returnt een nieuw object, als er een property niet is weergegeven in de form gaat deze field een standaard waarde meegeven(anders da noriginele object,
                                                 //het veld kon eventueel als hidden field meegeven( geen paswoorden in zetten want dit is wel zichtbaar in de Resources van internetpage

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
