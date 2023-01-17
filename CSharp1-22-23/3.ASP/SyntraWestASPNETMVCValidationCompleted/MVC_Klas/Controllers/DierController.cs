using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.VisualBasic;
using MVC_Klas.Interfaces;
using MVC_Klas.Models;
using MVC_Klas.Services;
using System.Security.Cryptography.Xml;

namespace MVC_Klas.Controllers
{
    public class DierController : Controller
    {
        private IDierRepository _dierRepo;
        private FamilieRepository _familieRepo;

        public DierController(IDierRepository repo, FamilieRepository familieRepo)
        {
            _dierRepo = repo;
            //_dierRepo.Counter++;
            _familieRepo = familieRepo;

        }

        // GET: DierController
        public ActionResult Index()
        {
            return View(_dierRepo.GetAll());
        }

        // GET: DierController/Details?benaming=
        public ActionResult Details(string benaming)
        {
            Dier x = _dierRepo.GetByBenaming(benaming);
            return View(x);
        }

        // GET: DierController/Create
        public ActionResult Create()
        {
            ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.Naam });
            return View();
        }

        // POST: DierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dier dier)
        {
            try
            {
                ModelState.Remove("FamilieObject");

                if (ModelState.IsValid)
                {
                    Dier x = dier;
                    var result = _dierRepo.AddDier(x);
                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.Naam });
                        ModelState.AddModelError("Benaming", "Naam van dier is reeds in gebruik!");
                        return View(dier);
                    }
                }
                ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.Naam });
                return View(dier);
            }
            catch
            {
                return View();
            }
        }

        // GET: DierController/Edit/5
        public ActionResult Edit(string benaming)
        {
            Dier x = _dierRepo.GetByBenaming(benaming);

            ViewBag.Families = _familieRepo.GetAll().Select(e => this.ConvertFamilie(e));

            return View(x);
        }

        public SelectListItem ConvertFamilie(Familie familie)
        {
            SelectListItem item = new SelectListItem();
            item.Text = familie.Naam;
            item.Value = familie.Naam;
            return item;
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
                _dierRepo.UpdateDier(x);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.Naam });
                return View(dier);
            }
        }

        // GET: DierController/Delete/5
        public ActionResult Delete(string benaming)
        {
            return View(_dierRepo.GetByBenaming(benaming));
        }

        // POST: DierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Dier dier)
        {
            try
            {
                _dierRepo.DeleteDier(dier.Benaming);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
