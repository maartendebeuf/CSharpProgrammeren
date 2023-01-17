﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Klas.Models;
using MVC_Klas.Services;

namespace MVC_Klas.Controllers
{
    public class DierenartsController : Controller
    {
        DierenartsRepository _dierenartsRepository;
        public DierenartsController(DierenartsRepository dierenartsRepository)
        {
            _dierenartsRepository = dierenartsRepository;
            //_jds = jsonDierenartsService;
        }
        // GET: DierenartsController
        public ActionResult Index()
        {
            if (ViewData["Example"]?.ToString() != "Test")
            {
                ViewData["Example"] = "Test";
            }

            if (ViewBag.Example == "Test")
            {

            }
            
            if (ViewBag.Example2 == null || ViewBag.Example2.ToString() != "Test")
            {
                ViewBag.Example2 = "Test";
            }

            var info = ViewData["Example2"].ToString();

            if (TempData["Example"]?.ToString() != "Test")
            {
                TempData["Example"] = "Test";
            }

            if (HttpContext.Session.GetString("Example") != "Test")
            {
                HttpContext.Session.SetString("Example", "Test");
            }

            return View(_dierenartsRepository.GetAll());
        }

        // GET: DierenartsController/Details/5
        public ActionResult Details(string id)
        {
            return View(_dierenartsRepository.GetByNaam(id));
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
