using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Fastfixer_Web.Models.Entities
{
    [Table("Clientes")] 
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        public string? Direccion { get; set; }

        public virtual ICollection<Vehiculos> Vehiculos { get; set; } = new List<Vehiculos>();
    }
}
