﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.Extensions.Localization;
using MVC_Klas.Models;
using MVC_Klas.Services;
using System.Security.Cryptography.Xml;

namespace MVC_Klas.Controllers
{
    public class DierController : Controller
    {
        private DierRepository _dierRepo;
        private FamilieRepository _familieRepo;
        private readonly IStringLocalizer<DierController> _localizer; 

        public DierController(DierRepository repo, FamilieRepository familieRepo, IStringLocalizer<DierController> localizer)
        {

            _dierRepo = repo;
            _familieRepo = familieRepo;
            _localizer = localizer;
        }

        // GET: DierController
        public ActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            return View(_dierRepo.GetAll());
        }

        public JsonResult GetAnimals()//jsonrtesult te te controleren via postman app
        {
            return Json(_dierRepo.GetAll());
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
            ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
            return View();
        }

        // POST: DierController/Create
        [HttpPost]                                                                  //HttpPost is voor de return van de view(als er op de button wordt geklikt
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dier dier)
        {
            try
            {
                ModelState.Remove("Familie");

                if (ModelState.IsValid)//extra check op de DataAnnotations van Model in backend
                {
                    Dier x = dier;
                    var result = _dierRepo.AddDier(x);
                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });//selectlistItem voor List van dropdownmenu(MVC) op te vullen
                        ModelState.AddModelError("Benaming", "Naam van dier is reeds in gebruik!");
                        return View(dier);
                    }
                }
                ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
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
            item.Value = familie.ID.ToString();
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
                ViewBag.Families = _familieRepo.GetAll().Select(e => new SelectListItem() { Text = e.Naam, Value = e.ID.ToString() });
                return View(dier);
            }
        }

        // GET: DierController/Delete/5
        public ActionResult Delete(string benaming)             //kan ook direct via button met redirect voor herladen van pagina vb in herhaling
        {                                                       //mapping van models in departmentService vb in herhaling
            return View(_dierRepo.GetByBenaming(benaming));     //vb met include in departmentRepo vb in herhaling
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
