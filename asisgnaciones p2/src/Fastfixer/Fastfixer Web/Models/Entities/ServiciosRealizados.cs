using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fastfixer_Web.Models.Entities
{
    public class ServiciosRealizados
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int orden_id { get; set; }

        public string? descripcion { get; set; }

        [Required]
        public decimal costo { get; set; }

        // Relación con OrdenesServicio (FK)
        [ForeignKey("orden_id")]
        public virtual OrdenesServicios OrdenServicios { get; set; }
    }
}
