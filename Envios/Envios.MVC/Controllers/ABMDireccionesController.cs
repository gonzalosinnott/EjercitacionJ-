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
    public class ABMDireccionesController : Controller
    {
        DataContext context = new DataContext();
        PaisesLogic paisesLogic = new PaisesLogic();
        ProvinciasLogic provinciasLogic = new ProvinciasLogic();
        LocalidadesLogic localidadesLogic = new LocalidadesLogic();

        // GET: ABMDirecciones
        public ActionResult Index()
        {
            ViewBag.ListaPaises = paisesLogic.GetAll().Where(p => p.Available != 0);
            return View();
        }

        private IList<Provincias> GetProvincias(int paisId)
        {
            return provinciasLogic.GetAll().Where(p => p.PaisID == paisId).ToList();
        }

        public JsonResult LoadProvincias(int paisId)
        {
            var provinciasList = GetProvincias(paisId).Where(p => p.Available != 0);
            var provinciasData = provinciasList.Select(p => new SelectListItem()
            {
                Text = p.ProvinciaName.ToString(),
                Value = p.ProvinciaID.ToString(),
            });
            return Json(provinciasData, JsonRequestBehavior.AllowGet);
        }

        private IList<Localidades> GetLocalidades(int provinciaId)
        {
            return localidadesLogic.GetAll().Where(l => l.ProvinciaID == provinciaId).ToList();
        }

        public JsonResult LoadLocalidades(int provinciaId)
        {
            var localidadesList = GetLocalidades(provinciaId).Where(p => p.Available != 0);
            var localidadesData = localidadesList.Select(l => new SelectListItem()
            {
                Text = l.LocalidadName.ToString(),
                Value = l.LocalidadID.ToString(),
            });
            return Json(localidadesData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult CreatePais()
        {
            return PartialView("_CreatePaisPartial");
        }

        [HttpPost]
        public ActionResult CreatePais(Paises model)
        {
            model.Available = 1;

            if (model != null)
            {
                paisesLogic.Add(model);
                return RedirectToAction("Index", "ABMDirecciones");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult CreateProvincia()
        {
            ViewBag.ListaPaises = paisesLogic.GetAll();

            return PartialView("_CreateProvinciaPartial");
        }

        [HttpPost]
        public ActionResult CreateProvincia(Provincias model)
        {
            model.Available = 1;

            if (model != null)
            {
                provinciasLogic.Add(model);
                return RedirectToAction("Index", "ABMDirecciones");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult CreateLocalidad()
        {
            ViewBag.ListaProvincias = provinciasLogic.GetAll();
            return PartialView("_CreateLocalidadPartial");
        }

        [HttpPost]
        public ActionResult CreateLocalidad(Localidades model)
        {
            model.Available = 1;

            if (model != null)
            {
                localidadesLogic.Add(model);
                return RedirectToAction("Index", "ABMDirecciones");
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult DeletePais(int id)
        {
            try
            {
                paisesLogic.Delete(id);
                return Json(new
                {
                    result = "SUCCESS",
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return Json(new
                {
                    result = "ERROR",
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteProvincia(int id)
        {
            try
            {
                provinciasLogic.Delete(id);
                return Json(new
                {
                    result = "SUCCESS",
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return Json(new
                {
                    result = "ERROR",
                }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult DeleteLocalidad(int id)
        {
            try
            {
                localidadesLogic.Delete(id);
                return Json(new
                {
                    result = "SUCCESS",
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return Json(new
                {
                    result = "ERROR",
                }, JsonRequestBehavior.AllowGet);
            }
        }                

        [HttpGet]
        public PartialViewResult EditPais(int id)
        {

            var model = paisesLogic.GetDataById(id);
            ViewBag.PaisId = model.PaisID;
            ViewBag.PaisName = model.PaisName;

            return PartialView("_EditPaisPartial");
        }

        [HttpPost]
        public ActionResult EditPais(Paises model)
        {
            paisesLogic.Update(model);
            return RedirectToAction("Index", "ABMDirecciones");
        }

        [HttpGet]
        public PartialViewResult EditProvincia(int id)
        {

            var model = provinciasLogic.GetDataById(id);
            ViewBag.ProvinciaID = model.ProvinciaID;
            ViewBag.ProvinciaName = model.ProvinciaName;

            return PartialView("_EditProvinciaPartial");
        }

        [HttpPost]
        public ActionResult EditProvincia(Provincias model)
        {
            provinciasLogic.Update(model);
            return RedirectToAction("Index", "ABMDirecciones");
        }

        [HttpGet]
        public PartialViewResult EditLocalidad(int id)
        {

            var model = localidadesLogic.GetDataById(id);
            ViewBag.LocalidadID = model.LocalidadID;
            ViewBag.LocalidadName = model.LocalidadName;

            return PartialView("_EditLocalidadPartial");
        }

        [HttpPost]
        public ActionResult EditLocalidad(Localidades model)
        {
            localidadesLogic.Update(model);
            return RedirectToAction("Index", "ABMDirecciones");
        }
    }
}