using Envios.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vista.MVC.Controllers
{
    public class ProductosClientController : Controller
    {
        ProductosServiceReference.ServiceClient client = new ProductosServiceReference.ServiceClient();


        // GET: Productos
        public ActionResult Index()
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

            return View(listaProductos);
        }
    }
}