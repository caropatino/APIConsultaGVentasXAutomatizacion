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
    public class OportunidadDeVentaController : ControllerBase
    {
        private readonly IOportunidadDeVentaAppService _oportunidadDeVentaAppService;

        public OportunidadDeVentaController(IOportunidadDeVentaAppService oportunidadDeVentaAppService)
        {
            _oportunidadDeVentaAppService = oportunidadDeVentaAppService;
        }
   

        [HttpGet, Route("ValidarExistenciaOportunidadVenta")]
        public async Task<IEnumerable<OportunidadDeVenta>> GetOportunidadDeVentaXCliente(Guid ClienteId) 
        {
            return await _oportunidadDeVentaAppService.GetOportunidadDeVentaPorCliente(ClienteId);
            
        }

    }
}
