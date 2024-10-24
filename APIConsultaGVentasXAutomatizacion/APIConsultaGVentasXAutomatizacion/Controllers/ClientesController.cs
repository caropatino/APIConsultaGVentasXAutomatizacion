﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Models;
using APIConsultaGVentasXAutomatizacion.Services;
using Microsoft.AspNetCore.Mvc.Routing;

namespace APIConsultaGVentasXAutomatizacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        
        private readonly IClientesAppService _clientesAppService;

        public ClientesController(IClientesAppService clientesAppService)
        {
            _clientesAppService = clientesAppService;
        }


        [HttpGet, Route("ValidarRIF")]
        public bool ValidacionRIF(string RIF)
        {
            return _clientesAppService.ValidarRIF(RIF);
        }

        [HttpGet, Route("NumeroIdentificacion")]
        public List<Cliente> GetClientePorRIF(string NumeroDeIdentificacion)
        {
            return _clientesAppService.GetClienteXIdentificacion(NumeroDeIdentificacion);
        }

        [HttpGet, Route("detalle")]
        public List<ClienteDTO> GetDetallesCliente(Guid ClienteId)
        {
            return _clientesAppService.GetDetallesCliente(ClienteId);
        }

    }
}
