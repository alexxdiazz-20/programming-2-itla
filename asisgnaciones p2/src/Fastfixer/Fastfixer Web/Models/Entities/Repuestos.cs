using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fastfixer_Web.Models.Entities
{
    public class Repuestos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }

        public string? descripcion { get; set; }

        [Required]
        public decimal precio { get; set; }

        public int? stock { get; set; }

        // Relación con RepuestosUtilizados
        public virtual ICollection<RepuestosUtilizados> RepuestosUtilizados { get; set; }
    }
}
