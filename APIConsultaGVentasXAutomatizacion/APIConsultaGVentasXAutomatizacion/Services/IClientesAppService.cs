using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface IClientesAppService
    {
        bool ValidarRIF(string RIF);

        public List<Cliente> GetClienteXIdentificacion(string NroIdentificacion);
    }
}
