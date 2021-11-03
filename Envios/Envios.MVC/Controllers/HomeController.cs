using Envios.Data;
using Envios.Entities;
using Envios.Logic.Clases;
using Envios.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Envios.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataContext entities = new DataContext();
            CascadaModel model = new CascadaModel();
            foreach (var pais in entities.Paises)
            {
                model.Paises.Add(new SelectListItem { Text = pais.PaisName, Value = pais.PaisID.ToString() });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int? paisId, int? provinciaID, int? localidadID)
        {
            DataContext entities = new DataContext();
            CascadaModel model = new CascadaModel();
            foreach (var pais in entities.Paises)
            {
                model.Paises.Add(new SelectListItem { Text = pais.PaisName, Value = pais.PaisID.ToString() });
            }

            if (paisId.HasValue)
            {
                var provincias = (from provincia in entities.Provincias
                              where provincia.PaisID == paisId.Value
                              select provincia).ToList();
                foreach (var provincia in provincias)
                {
                    model.Provincias.Add(new SelectListItem { Text = provincia.ProvinciaName, Value = provincia.ProvinciaID.ToString() });
                }

                if (provinciaID.HasValue)
                {
                    var localidades = (from localidad in entities.Localidades
                                  where localidad.ProvinciaID == provinciaID.Value
                                  select localidad).ToList();
                    foreach (var localidad in localidades)
                    {
                        model.Localidades.Add(new SelectListItem { Text = localidad.LocalidadName, Value = localidad.localidadID.ToString() });
                    }
                }
            }

            return View(model);
        }

    }
}