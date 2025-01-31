using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface IOportunidadDeVentaAppService
    {
        public List<OportunidadDeVenta> GetOportunidadDeVentaPorCliente(Guid ClienteId, Guid ProductoId);

        public bool ValidarProductos(string Productos, string valorDelUsuario);
    }
}
