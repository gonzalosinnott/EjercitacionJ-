using Envios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios.Logic
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
