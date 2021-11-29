using ServiceBackEnd.Connection;
using ServiceBackEnd.Entitites.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceBackEnd.Logic
{
    public class ClientesLogic
    {
        XDocument xmldoc = XDocument.Load(@"D:\NEORIS\Capacitacion\EjercitacionJ-\ECommerce\ServiceProductos\Customers.xml");
        string path = @"D:\NEORIS\Capacitacion\EjercitacionJ-\ECommerce\ServiceProductos\Customers.xml";

        protected readonly XMLContext context;
        public ClientesLogic()
        {
            context = new XMLContext();
        }

        public List<Clientes> GetAll()
        {
            IEnumerable<XElement> customers = context.XMLData.Elements();

            List<Clientes> customersList = new List<Clientes>();

            foreach (var item in customers)
            {                
                int available = Int32.Parse(item.Element("available").Value);
                if (available != 0)
                {
                    Clientes customer = new Clientes
                    {
                        Id = Int32.Parse(item.Element("id").Value),
                        FirstName = item.Element("first_name").Value,
                        LastName = item.Element("last_name").Value
                    };
                    customersList.Add(customer);
                }             
            }
            return customersList;
        }

        public void Add(Clientes newCliente)
        {
            int id = GetMaxId() + 1;
            XElement cliente = new XElement("Customer",
                                   new XElement("id", id),
                                   new XElement("first_name", newCliente.FirstName),
                                   new XElement("last_name", newCliente.LastName),
                                   new XElement("available", newCliente.Available));

            xmldoc.Root.Add(cliente);
            xmldoc.Save(path);
        }

        public void Update(Clientes cliente)
        {
            try
            {
                XElement clienteXml = xmldoc.Descendants("Customer").FirstOrDefault(p => Int32.Parse(p.Element("id").Value) == cliente.Id);

                if (clienteXml != null)
                {
                    clienteXml.Element("first_name").Value = cliente.FirstName;
                    clienteXml.Element("last_name").Value = cliente.LastName;
                    
                    xmldoc.Save(path);
                }
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
                XElement clienteXml = xmldoc.Descendants("Customer").FirstOrDefault(p => Int32.Parse(p.Element("id").Value) == id);

                if (clienteXml != null)
                {
                    ///BORRADO LOGICO
                    clienteXml.Element("available").Value = "0";
                    
                    ///BORRADO FISICO
                    ///clienteXml.Remove();
                    
                    xmldoc.Save(path);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public Clientes GetDataById(int id)
        {
            XElement clienteXml = xmldoc.Descendants("Customer").FirstOrDefault(p => Int32.Parse(p.Element("id").Value) == id);

            if(clienteXml != null)
            {
                Clientes cliente = new Clientes
                {
                    Id = Int32.Parse(clienteXml.Element("id").Value),
                    FirstName = (string)clienteXml.Element("first_name"),
                    LastName = (string)clienteXml.Element("last_name")
                };
                return cliente;
            }

            return null;
        }
        
        public int GetMaxId()
        {
            IEnumerable<XElement> customers = context.XMLData.Elements();

            int id = context.XMLData.Elements("Customer").Elements("id").Max(x => Int32.Parse(x.Value));

            return id;
        }
    }
}
