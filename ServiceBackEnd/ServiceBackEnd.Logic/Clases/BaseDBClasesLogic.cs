using ServiceBackEnd.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackEnd.Logic.Clases
{
    public class BaseDBClasesLogic
    {
        protected readonly DataContext context;

        public BaseDBClasesLogic()
        {
            context = new DataContext();
        }
    }
}
