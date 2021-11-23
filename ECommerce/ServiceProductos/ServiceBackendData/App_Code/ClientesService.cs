using ServiceBackEnd.Entities;
using ServiceBackEnd.Entitites.Clases;
using ServiceBackEnd.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class ClienteService : IClienteService
{
    ClientesLogic clienteLogic = new ClientesLogic();

	public List<Clientes> GetAllClientes()
    {
        var carrito = clienteLogic.GetAll();

        return carrito.ToList();
    }
}

