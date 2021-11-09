using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Envios.MVC.Models
{
    public class ProvinciaModel
    {
        [Key]
        public int ProvinciaId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinciaName { get; set; }

        public int PaisId { get; set; }

        public int Available { get; set; }
    }
}