using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Models;
using APIConsultaGVentasXAutomatizacion.Services;

namespace APIConsultaGVentasXAutomatizacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsAppService _ticketsAppService;

        public TicketsController(ITicketsAppService ticketsAppService)
        {
            _ticketsAppService = ticketsAppService;
        }

        [HttpGet, Route("GetTicketsPorCliente")]
        public List<Ticket> GetTicketsPorCliente(Guid ClienteId)
        {
            return _ticketsAppService.GetTicketsPorCliente(ClienteId);
        }

    }
}
