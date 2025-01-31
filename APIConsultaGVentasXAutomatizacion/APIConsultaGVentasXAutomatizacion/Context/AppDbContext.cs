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

        public DbSet<Ticket> AppTickets { get; set; }

        public DbSet<ClienteDetalleContactos> AppClienteDetalleContactos { get; set; }

        public DbSet<Etiqueta> AppEtiquetas { get; set; }

        public DbSet<TicketDetalleEtiquetas> AppTicketDetalleEtiquetas { get; set; }

        public DbSet<Ciudad> AppCiudades { get; set; }

        public DbSet<Vendedor> AppVendedores { get; set; } 

    }
}
