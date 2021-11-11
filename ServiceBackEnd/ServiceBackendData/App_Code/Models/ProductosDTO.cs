using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Productos
/// </summary>
public class ProductosDTO
{
    [Key]
    public int ProductoId { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductoName { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductoMarca { get; set; }

    [Required]
    [StringLength(500)]
    public string ProductoDescription { get; set; }

    public double ProductoPrecio { get; set; }

    public int Available { get; set; }

    public int ProductoStock { get; set; }
}