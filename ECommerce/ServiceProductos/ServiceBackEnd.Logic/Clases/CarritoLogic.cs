using ServiceBackEnd.Entities;
using ServiceBackEnd.Logic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackEnd.Logic
{
    public class CLienteLogic : BaseDBClasesLogic
    {
        public List<Carrito> GetAll()
        {
            return context.Carrito.ToList();
        }

        public void Add(Carrito newCompra)
        {
            context.Carrito.Add(newCompra);
            context.SaveChanges();
        }

        public void Update(Carrito compra)
        {
            try
            {
                var compraUpdate = context.Carrito.Find(compra.CarritoId);
                compraUpdate.ProductoId = compra.ProductoId;
                compraUpdate.CompraName = compra.CompraName;
                compraUpdate.CompraMarca = compra.CompraMarca;
                compraUpdate.CompraDescripcion = compra.CompraDescripcion;
                compraUpdate.CompraCantidad = compra.CompraCantidad;
                compraUpdate.CompraImage = compra.CompraImage;
                compraUpdate.CompraPrecioUnitario = compra.CompraPrecioUnitario;
                compraUpdate.CompraPrecioTotal = compra.CompraPrecioTotal;

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
                var compraToDelete = context.Carrito.Find(id);

                context.Carrito.Remove(compraToDelete);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Carrito GetDataById(int id)
        {
            Carrito compra = context.Carrito.Where(p => p.CarritoId== id).FirstOrDefault();

            return compra;
        }

    }
}
