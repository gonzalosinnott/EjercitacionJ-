using Envios.Data;
using Envios.Entities;
using Envios.Logic.Clases;
using Envios.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Envios.MVC.Controllers
{
    public class ABMController : Controller
    {
        PaisesLogic paisesLogic = new PaisesLogic();
        ProvinciasLogic provinciasLogic = new ProvinciasLogic();
        LocalidadesLogic localidadesLogic = new LocalidadesLogic();
        DataContext context = new DataContext();

        public ActionResult DeletePais(int id)
        {
            try
            {
                paisesLogic.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        public ActionResult DeleteProvincia(int id)
        {
            try
            {
                provinciasLogic.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }
        public ActionResult DeleteLocalidad(int id)
        {
            try
            {
                localidadesLogic.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult CreatePais()
        {
            return PartialView("_CreatePartialPais");
        }

        [HttpPost]
        public ActionResult CreatePais(Paises model)
        {
            model.Available = 1;

            if (model != null)
            {
                paisesLogic.Add(model);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult EditPais(int id)
        {
            Paises model = new Paises();

            model = paisesLogic.getPaisById(id);

            return PartialView("_EditPartialPais", model);
        }

        [HttpPost]
        public ActionResult EditPais(Paises model)
        {

            if (model != null)
            {
                paisesLogic.Update(model);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult CreateProvincia()
        {
            return PartialView("_CreatePartialPais");
        }

        [HttpPost]
        public ActionResult CreateProvincia(Provincias model)
        {
            model.Available = 1;

            if (model != null)
            {
                provinciasLogic.Add(model);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error");
            }
        }



    }
}