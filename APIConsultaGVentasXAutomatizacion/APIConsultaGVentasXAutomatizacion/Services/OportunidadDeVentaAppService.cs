using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public class OportunidadDeVentaAppService: IOportunidadDeVentaAppService
    {
        private readonly AppDbContext _context;
        public OportunidadDeVentaAppService(AppDbContext context)
        {
            _context = context;
        }

        public List<OportunidadDeVenta> GetOportunidadDeVentaPorCliente(Guid ClienteId, Guid ProductoId)
        {
            return _context.AppOportunidadesDeVenta
                /*.Join(_context.AppOportunidadDeVentaDetalleProductoOV
                    ,o => o.Id
                    ,p => p.OportunidadDeVentaId
                    ,(o, p) => new OportunidadDeVenta
                    {
                        Id = o.Id,
                        ClienteId = o.ClienteId,
                        TenantId = o.TenantId,
                        CompaniaId = o.CompaniaId,
                        Estado = o.Estado,
                        Productos = p.ProductoOVId
                    })*/
                .Where(x => x.ClienteId == ClienteId
                    && x.TenantId == new Guid("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                    && x.CompaniaId == 5
                    && x.Estado < 5
                    && x.Productos.ProductoOVId == ProductoId).ToList();
                
        }


    }
}
