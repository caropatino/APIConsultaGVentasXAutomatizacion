using APIConsultaGVentasXAutomatizacion.Models;
using Microsoft.EntityFrameworkCore;

namespace APIConsultaGVentasXAutomatizacion.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet <Cliente> AppClientes { get; set; }

        public DbSet<OportunidadDeVenta> AppOportunidadesDeVenta { get; set; }

        public DbSet<OportunidadDeVentaDetalleProducto> AppOportunidadDeVentaDetalleProductosOV { get; set; }

    }
}
