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
        public int LocalidadID { get; set; }

        [Required]
        [StringLength(50)]
        public string LocalidadName { get; set; }

        public int ProvinciaID { get; set; }

        public int Available { get; set; }
    }
}