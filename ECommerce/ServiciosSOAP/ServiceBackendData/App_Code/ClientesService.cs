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

    public string AddCliente(Clientes cliente)
    {
        try
        {
            clienteLogic.Add(cliente);
            return "SUCCESS";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    public Clientes GetClienteById(int value)
    {
        return clienteLogic.GetDataById(value);
    }

    public string UpdateCliente(Clientes cliente)
    {
        try
        {
            clienteLogic.Update(cliente);
            return "SUCCESS";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    public string DeleteCliente(int value)
    {
        try
        {
            clienteLogic.Delete(value);
            return "SUCCESS";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}

