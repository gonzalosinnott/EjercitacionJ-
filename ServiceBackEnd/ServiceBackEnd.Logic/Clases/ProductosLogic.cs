using ServiceBackEnd.Entities.Clases;
using ServiceBackEnd.Logic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackEnd.Logic
{
    public class ProductosLogic : BaseDBClasesLogic
    {
        public List<Productos> GetAll()
        {
            return context.Productos.ToList();
        }

        public void Add(Productos newProducto)
        {
            context.Productos.Add(newProducto);
            context.SaveChanges();
        }

        public void Update(Productos producto)
        {
            try
            {
                var productoUpdate = context.Productos.Find(producto.ProductoId);
                productoUpdate.ProductoName = producto.ProductoName;
                productoUpdate.ProductoMarca = producto.ProductoMarca;
                productoUpdate.ProductoDescription = producto.ProductoDescription;
                productoUpdate.ProductoStock = producto.ProductoStock;
                productoUpdate.ProductoPrecio = producto.ProductoPrecio;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var productoToDelete = context.Productos.Find(id);

                ///BORRADO LOGICO
                productoToDelete.Available = 0;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Productos GetDataById(int id)
        {
            Productos producto = context.Productos.Where(p => p.ProductoId == id).FirstOrDefault();

            return producto;
        }

    }
}
