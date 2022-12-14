using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVC_Klas.Models;

namespace MVC_Klas.Controllers
{
    public class FamilieController : Controller
    {
        //rechts klikken op methode om View toe te voegen
        public IActionResult Index()
        {
            FamilieRepository _repo = new FamilieRepository();
            return View(_repo.GetAll());
        }
        //string ipv int omdat we in de (index)view de naam terug koppelen
        public ActionResult Details(string naam)
        {
            FamilieRepository _repo = new FamilieRepository();
            Familie x = _repo.GetByNaam(naam);

            return View(x);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Familie familie)
        {
            try
            {
                if (ModelState.IsValid)//check code side
                {
                    Familie x = familie;
                    FamilieRepository _repo = new FamilieRepository();
                    _repo.AddFamilie(x);
                    return RedirectToAction(nameof(Index));
                
                    //zie nieuwe versie voor validatie van dubbele waardes via repo en zo de check terug te koppelen met client
                }
                return View(familie);// return (create) viewmet ingevulde waardes
            }
            catch
            {
                return View();
            }
        }        
        public ActionResult Edit(string naam)
        {
            //ophalen weer te geven data
            //ophalen repo
            FamilieRepository _repoFamilie = new FamilieRepository();
            OrdeRepository ordeRepository = new OrdeRepository();
            
            //ViewBag.Ordes vullen om mee te geven in de View
            ViewBag.Ordes = ordeRepository.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.Naam });

            //viewdata ophalen van geselecteerde element(
            Familie x = _repoFamilie.GetByNaam(naam);

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
                FamilieRepository _repo = new FamilieRepository();
                _repo.UpdateFamilie(x);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string naam)
        {
            FamilieRepository _repo = new FamilieRepository();

            return View(_repo.GetByNaam(naam));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Familie familie)
        {
            try
            {
                FamilieRepository _repo = new FamilieRepository();
                _repo.DeleteFamilie(familie.Naam);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
