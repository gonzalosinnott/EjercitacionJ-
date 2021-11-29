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
public class CarritoService : ICarritoService
{
	CLienteLogic carritoLogic = new CLienteLogic();

	public List<Carrito> GetAllCarrito()
    {
		var carrito = carritoLogic.GetAll();

		return carrito.ToList();
	}

    public Carrito GetCarritoById(int value)
    {
		return carritoLogic.GetDataById(value);
	}

	public string AddCarrito(Carrito producto)
    {
		try
		{
			carritoLogic.Add(producto);
			return "SUCCESS";
		}
		catch (Exception ex)
		{
			return ex.ToString();
		}
	}

    public string DeleteCarrito(int value)
    {
		try
		{
			carritoLogic.Delete(value);
			return "SUCCESS";
		}
		catch (Exception ex)
		{
			return ex.ToString();
		}
	}

    public string UpdateCarrito(Carrito producto)
    {
		try
		{
			carritoLogic.Update(producto);
			return "SUCCESS";
		}
		catch (Exception ex)
		{
			return ex.ToString();
		}
	}
}
