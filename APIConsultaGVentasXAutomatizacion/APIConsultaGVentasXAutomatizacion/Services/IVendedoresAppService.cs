using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface IVendedoresAppService
    {
        CantidadOportunidadesXVendedorDTO GetVendedorConMenosOportunidadesAbiertas(int estadoId);
    }
}

