using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceBackEnd.Connection
{
    public class XMLContext
    {
        public XMLContext()
        {

        }

        public XElement XMLData = XElement.Load(@"D:\NEORIS\Capacitacion\EjercitacionJ-\ECommerce\ServiceProductos\Customers.xml");
    }
}
