using ServiceBackEnd.Entitites.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IClienteService
{
	[OperationContract]
	List<Clientes> GetAllClientes();

	[OperationContract]
	string AddCliente(Clientes cliente);

	[OperationContract]
	Clientes GetClienteById(int value);

	[OperationContract]
	string UpdateCliente(Clientes cliente);

	[OperationContract]
	string DeleteCliente(int value);
}

