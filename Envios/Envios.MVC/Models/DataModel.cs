using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Envios.MVC.Models
{
    public class DataModel
    {
        public IEnumerable<PaisModel> Paises { get; set; }
        public IEnumerable<ProvinciaModel> Provincias { get; set; }
        public IEnumerable<LocalidadModel> Localidades { get; set; }

    }
}