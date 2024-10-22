using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface IClientesAppService
    {
        bool ValidarRIF(string RIF);

        public Task<IEnumerable<Cliente>> GetClienteXIdentificacion(string NroIdentificacion);
    }
}
