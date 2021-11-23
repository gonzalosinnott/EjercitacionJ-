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

        // GET: ClientesAdmin
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
    }
}