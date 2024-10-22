using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Models;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public class TicketsAppService: ITicketsAppService
    {
        private readonly AppDbContext _context;
        public TicketsAppService(AppDbContext context)
        {
            _context = context;
        }

        public List<Ticket> GetTicketsPorCliente(Guid ClienteId)
        {
            return _context.AppTickets
               .Where(t => t.ClienteId == ClienteId
                   && t.TenantId == new Guid("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                   && t.CompaniaId == 5
                   && t.Estatus == 0).ToList();
        }
    }
}
