using Microsoft.EntityFrameworkCore;
using Fastfixer_Web.Models.Entities;

namespace Fastfixer_Web.Data
{
    public class FastfixerDbContext : DbContext
    {
        public FastfixerDbContext(DbContextOptions<FastfixerDbContext> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; } 
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<OrdenesServicios> OrdenesServicios { get; set; }
        public DbSet<Repuestos> Repuestos { get; set; }
        public DbSet<RepuestosUtilizados> RepuestosUtilizados{ get; set; }
        public DbSet<ServiciosRealizados> ServiciosRealizados { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }




    }

}
  