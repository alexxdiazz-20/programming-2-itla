using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fastfixer_Web.Models.Entities
{
    public class Facturas
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int orden_id { get; set; }

        public DateTime fecha_emision { get; set; }

        [Required]
        public decimal total { get; set; }

        // Relación con OrdenesServicio (FK)
        [ForeignKey("orden_id")]
        public virtual OrdenesServicios OrdenServicios { get; set; }
    }
}

