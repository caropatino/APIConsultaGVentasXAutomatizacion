using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public interface ITicketsAppService
    {
        List<Ticket> GetTicketsPorCliente(Guid ClienteId);
    }
}
