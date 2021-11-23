using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Envios.MVC.Models
{
    public class PaisModel
    {
        [Key]
        public int PaisId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaisName { get; set; }

        public int Available { get; set; }
    }
}