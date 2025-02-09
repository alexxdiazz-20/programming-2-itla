using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fastfixer_Web.Models.Entities
{
    public class RepuestosUtilizados
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int orden_id { get; set; }

        [Required]
        public int repuesto_id { get; set; }

        [Required]
        public int cantidad { get; set; }

        // Relaciones con OrdenesServicio y Repuestos
        [ForeignKey("orden_id")]
        public virtual OrdenesServicios OrdenServicio { get; set; }

        [ForeignKey("repuesto_id")]
        public virtual Repuestos Repuestos { get; set; }
    }
}
