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
public interface IProductosService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	string GetAllProductsConsoleTest();

	[OperationContract]
	List<Productos> GetAllProducts();

	[OperationContract]
	Productos GetProductById(int value);
	
	[OperationContract]
	string AddProduct(Productos producto);

	[OperationContract]
	string DeleteProduct(int value);

	[OperationContract]
	string UpdateProduct(Productos producto);

}


