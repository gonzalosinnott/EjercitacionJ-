using ServiceBackEnd.Connection;
using ServiceBackEnd.Entitites.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceBackEnd.Logic
{
    public class ClientesLogic
    {
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
                Clientes customer = new Clientes();

                customer.Id = item.Element("id").Value;
                customer.FirstName = item.Element("first_name").Value;
                customer.LastName = item.Element("last_name").Value;

                customersList.Add(customer);
            }

            return customersList;
        }
    }
}
