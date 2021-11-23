using Envios.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vista.MVC.Models;

namespace Vista.MVC.Controllers
{
    public class ProductosClientController : Controller
    {
        ProductosServiceReference.ProductosServiceClient client = new ProductosServiceReference.ProductosServiceClient();


        // GET: Productos
        public ActionResult Index()
        {
            try
            {
                var productos = client.GetAllProducts();
                List<ProductoModel> listaProductos = new List<ProductoModel>();

                foreach (var item in productos)
                {
                    ProductoModel auxProducto = new ProductoModel
                    {
                        ProductoId = item.ProductoId,
                        ProductoName = item.ProductoName,
                        ProductoMarca = item.ProductoMarca,
                        ProductoDescription = item.ProductoDescription,
                        ProductoPrecio = item.ProductoPrecio,
                        ProductoStock = item.ProductoStock,
                        Available = item.Available,
                        ProductoImage = item.ProductoImage
                    };

                    listaProductos.Add(auxProducto);
                }
                ViewBag.Productos = listaProductos.Count();
                return View(listaProductos);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult ListarProductos()
        {
            
            return PartialView("_ListarProductoPartial");
        }

        [HttpGet]
        public ActionResult AddCompra(int id, int cantidad)
        {

            return View("Index");
        }
    }
}