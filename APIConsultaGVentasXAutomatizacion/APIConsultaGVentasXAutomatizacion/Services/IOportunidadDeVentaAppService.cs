using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface IOportunidadDeVentaAppService
    {
        public Task<IEnumerable<OportunidadDeVenta>> GetOportunidadDeVentaPorCliente(Guid ClienteId);
    }
}
