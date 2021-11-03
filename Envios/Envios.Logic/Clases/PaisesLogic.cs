using Envios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios.Logic.Clases
{
    public class PaisesLogic : BaseDBClasesLogic
    {
        public List<Paises> GetAll()
        {
            return context.Paises.ToList();
        }
    }
}
