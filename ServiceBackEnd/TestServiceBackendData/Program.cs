using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServiceBackendData
{
    class Program
    {
        static void Main(string[] args)
        {

            string returnData = RequestAllProductsConsoleTest();

            Console.WriteLine("Show data...");

            Console.WriteLine(returnData);

            Console.ReadKey();
        }

       static string RequestAllProductsConsoleTest()
        {
            BackendDataService.ServiceClient client = new BackendDataService.ServiceClient();
            return client.GetAllProductsConsoleTest();
        }
    }
}
