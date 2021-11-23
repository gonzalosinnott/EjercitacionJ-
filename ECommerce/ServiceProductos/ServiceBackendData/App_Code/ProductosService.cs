using ServiceBackEnd.Entities;
using ServiceBackEnd.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class ProductosService : IProductosService
{
	ProductosLogic productosLogic = new ProductosLogic();

	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public string GetAllProductsConsoleTest()
	{
		var productos = productosLogic.GetAll().Where(p => p.Available != 0);

		StringBuilder sb = new StringBuilder();
		foreach (Productos item in productos)
		{
			sb.AppendLine("---------------------------------");
			sb.AppendLine("Nombre: " + item.ProductoName);
			sb.AppendLine("Marca: " + item.ProductoMarca);
			sb.AppendLine("Descripcion: " + item.ProductoDescription);
			sb.AppendLine("Stock: " + item.ProductoStock);
			sb.AppendLine("Precio: " + item.ProductoPrecio);
			sb.AppendLine("---------------------------------");
		}

		return sb.ToString();
	}

	public List<Productos> GetAllProducts()
	{
		var productos = productosLogic.GetAll().Where(p => p.Available != 0);

		return productos.ToList();
	}

	public Productos GetProductById(int id)
    {
		return productosLogic.GetDataById(id);
    }

	public string AddProduct(Productos producto)
    {
        try
        {
			productosLogic.Add(producto);
			return "SUCCESS";
        }
		catch(Exception ex)
        {
			return ex.ToString();
        }
    }

	public string DeleteProduct(int id)
	{
		try
		{
			productosLogic.Delete(id);
			return "SUCCESS";
		}
		catch (Exception ex)
		{
			return ex.ToString();
		}
	}

	public string UpdateProduct(Productos producto)
    {
		try
		{
			productosLogic.Update(producto);
			return "SUCCESS";
		}
		catch (Exception ex)
		{
			return ex.ToString();
		}
	}
 
}
