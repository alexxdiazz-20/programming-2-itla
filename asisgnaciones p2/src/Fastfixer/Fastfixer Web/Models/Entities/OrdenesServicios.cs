using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fastfixer_Web.Models.Entities
{
    public class OrdenesServicios
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int vehiculo_id { get; set; }

        public DateTime? fecha_ingreso { get; set; }
        public DateTime? fecha_entrega { get; set; }

        [MaxLength(50)]
        public string? estado { get; set; }

        [Required]
        public decimal costo_total { get; set; }

        // Relación con Vehiculos (FK)
        [ForeignKey("vehiculo_id")]
        public virtual Vehiculos Vehiculo { get; set; }

        // Relación: Una orden puede tener muchas facturas y servicios
        public virtual ICollection<Facturas> Facturas { get; set; }
        public virtual ICollection<ServiciosRealizados> ServiciosRealizados { get; set; }
    }
}
