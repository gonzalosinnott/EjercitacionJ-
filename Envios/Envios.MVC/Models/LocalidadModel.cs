using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Envios.MVC.Models
{
    public class LocalidadModel
    {
        [Key]
        public int LocalidadId { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(50)]
        public string LocalidadName { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public int ProvinciaId { get; set; }

        public int PaisId { get; set; }

        public int Available { get; set; }
    }
}