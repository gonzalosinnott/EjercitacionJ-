namespace ServiceBackEnd.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carrito")]
    public partial class Carrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarritoId { get; set; }

        public int ProductoId { get; set; }

        [Required]
        [StringLength(50)]
        public string CompraName { get; set; }

        [Required]
        [StringLength(50)]
        public string CompraMarca { get; set; }

        [Required]
        [StringLength(500)]
        public string CompraDescripcion { get; set; }

        public int CompraCantidad { get; set; }

        [Required]
        [StringLength(500)]
        public string CompraImage { get; set; }

        public double CompraPrecioUnitario { get; set; }

        public double CompraPrecioTotal { get; set; }
    }
}
