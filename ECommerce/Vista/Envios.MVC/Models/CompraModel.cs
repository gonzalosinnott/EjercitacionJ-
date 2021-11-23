using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vista.MVC.Models
{
    public class CompraModel
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(50)]
        public string ProductoName { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(50)]
        public string ProductoMarca { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(500)]
        public string ProductoDescription { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public double ProductoPrecio { get; set; }

        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public int ProductoCantidad { get; set; }

        public string ProductoImage { get; set; }
    }
}