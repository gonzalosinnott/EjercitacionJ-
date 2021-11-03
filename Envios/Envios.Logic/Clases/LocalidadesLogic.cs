using Envios.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Envios.Logic.Clases
{
    public class LocalidadesLogic : BaseDBClasesLogic
    {
        public List<Localidades> GetAll()
        {
            return context.Localidades.ToList();
        }
    }
}
