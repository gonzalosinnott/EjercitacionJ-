using Envios.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vista.MVC.Controllers
{
    public class ProductosAdminController : Controller
    {
        ProductosServiceReference.ServiceClient client = new ProductosServiceReference.ServiceClient();
        
        
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
            catch(Exception ex) 
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
            
        }

        public ActionResult DeleteProducto(int id)
        {
            try
            {
                client.DeleteProduct(id);
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
        public PartialViewResult CreateProducto()
        {
            return PartialView("_CreateProductoPartial");
        }

        [HttpPost]
        public ActionResult CreateProducto(ProductosServiceReference.Productos model)
        {
            model.Available = 1;

            if (model != null)
            {
                client.AddProduct(model);
                return RedirectToAction("Index", "ProductosAdmin");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public PartialViewResult EditProducto(int id)
        {

            var model = client.GetProductById(id);
            ViewBag.ProductoId = model.ProductoId; 
            ViewBag.ProductoName = model.ProductoName;
            ViewBag.ProductoMarca = model.ProductoMarca;
            ViewBag.ProductoDescription = model.ProductoDescription;
            ViewBag.ProductoPrecio = model.ProductoPrecio;
            ViewBag.ProductoStock = model.ProductoStock;
            ViewBag.ProductoImage = model.ProductoImage;

            return PartialView("_EditProductoPartial");
        }

        [HttpPost]
        public ActionResult EditProducto(ProductosServiceReference.Productos model)
        {
            client.UpdateProduct(model);
            return RedirectToAction("Index", "ProductosAdmin");
        }
    }
}