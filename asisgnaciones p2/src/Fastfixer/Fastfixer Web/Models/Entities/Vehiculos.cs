using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fastfixer_Web.Models.Entities
{
    public class Vehiculos
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int cliente_id { get; set; }

        [Required]
        [MaxLength(20)]
        public string placa { get; set; }

        [Required]
        [MaxLength(50)]
        public string marca { get; set; }

        [Required]
        [MaxLength(50)]
        public string modelo { get; set; }

        [Required]
        public int anio { get; set; }

        // Relación con Clientes (FK)
        [ForeignKey("cliente_id")]
        public virtual Clientes Cliente { get; set; }

        // Relación: Un vehículo puede tener muchas órdenes de servicio
        public virtual ICollection<OrdenesServicios> OrdenesServicios { get; set; }
    }
}
