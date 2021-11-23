using ServiceBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ICarritoService
{
	[OperationContract]
	List<Carrito> GetAllCarrito();

	[OperationContract]
	Carrito GetCarritoById(int value);
	
	[OperationContract]
	string AddCarrito(Carrito producto);

	[OperationContract]
	string DeleteCarrito(int value);

	[OperationContract]
	string UpdateCarrito(Carrito producto);	
}

