using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public class VendedoresAppService : IVendedoresAppService
    {
        private readonly AppDbContext _context;
        public VendedoresAppService(AppDbContext context)
        {
            _context = context;
        }

        public CantidadOportunidadesXVendedorDTO GetVendedorConMenosOportunidadesAbiertas (int estadoId)
        {
            var query = from oportunidad in _context.AppOportunidadesDeVenta
                        join vendedor in _context.AppVendedores on oportunidad.VendedorId equals vendedor.Id
                        join ciudad in _context.AppCiudades on vendedor.Ciudad equals ciudad.Nombre
                        where (oportunidad.Estado < 5
                        && oportunidad.CompaniaId == 5
                        && oportunidad.TenantId == new Guid("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                        && vendedor.TenantId == oportunidad.TenantId
                        && vendedor.CompaniaId == oportunidad.CompaniaId
                        && ciudad.TenantId == oportunidad.TenantId)
                        && ciudad.EstadoId == estadoId
                        select oportunidad;

            return query
             .GroupBy(x => x.VendedorId)
             .Select(g => new CantidadOportunidadesXVendedorDTO
             {
                 VendedorId = g.Key,
                 Cantidad = g.Count()
             })
             .OrderBy(o => o.Cantidad)
             .FirstOrDefault();
        }


    }
}
