using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vista.MVC.Models;

namespace Vista.MVC.Controllers
{
    public class ClientesAdminController : Controller
    {
        ClientesServiceReference.ClienteServiceClient client = new ClientesServiceReference.ClienteServiceClient();

        public ActionResult Index()
        {
            try
            { 
                var clientes = client.GetAllClientes();
                List<ClienteModel> listaClientes = new List<ClienteModel>();

                foreach (var item in clientes)
                {
                    ClienteModel auxCliente = new ClienteModel
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName                   
                    };

                    listaClientes.Add(auxCliente);
                }

                ViewBag.Clientes = listaClientes.Count();
                return View(listaClientes);
            }
            catch(Exception ex) 
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        public ActionResult DeleteCliente(int id)
        {
            try
            {
                client.DeleteCliente(id);
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
        public PartialViewResult CreateCliente()
        {
            return PartialView("_CreateClientePartial");
        }

        [HttpPost]
        public ActionResult CreateCliente(ClientesServiceReference.Clientes model)
        {
            model.Available = 1;

            if (model != null)
            {
                client.AddCliente(model);
                return RedirectToAction("Index", "ClientesAdmin");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult EditCLiente(int id)
        {

            var model = client.GetClienteById(id);
            ViewBag.ClienteId = model.Id;
            ViewBag.FirstName = model.FirstName;
            ViewBag.LastName = model.LastName;

            return PartialView("_EditClientePartial");
        }

        [HttpPost]
        public ActionResult EditCliente(ClientesServiceReference.Clientes model)
        {
            client.UpdateCliente(model);
            return RedirectToAction("Index", "ClientesAdmin");
        }
    }
}