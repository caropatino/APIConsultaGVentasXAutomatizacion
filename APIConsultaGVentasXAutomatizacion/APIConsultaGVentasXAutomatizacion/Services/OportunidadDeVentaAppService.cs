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

        public async Task<IEnumerable<OportunidadDeVenta>> GetOportunidadDeVentaPorCliente(Guid ClienteId)
        {
            return _context.AppOportunidadesDeVenta.ToList();
                /*.Where(c => c.ClienteId == ClienteId);
                    && c.TenantId.Equals("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                    && c.CompaniaId == 5
                    && c.Estado < 5);*/
                
        }


    }
}
