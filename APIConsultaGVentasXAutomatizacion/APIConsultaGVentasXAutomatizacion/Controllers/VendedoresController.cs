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
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace APIConsultaGVentasXAutomatizacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly IVendedoresAppService _vendedoresAppService;
        private IConfiguration _configuration;

        public VendedoresController(IVendedoresAppService vendedoresAppService, IConfiguration iConfig)
        {
            _vendedoresAppService = vendedoresAppService;
            _configuration = iConfig;
        }


        [HttpGet, Route("EscogerVendedorParaOportunidad")]
        public Guid EscogerVendedorParaOportunidad(int estadoId)
        {
            try
            {
                System.IO.File.AppendAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "e.txt"), "A");

                var resultado = _vendedoresAppService.GetVendedorConMenosOportunidadesAbiertas(estadoId);

                if (estadoId == 1 || resultado == null)
                {
                    return new Guid(_configuration.GetSection("idVendedorOficina").Value);
                }

                return resultado.VendedorId;
                
            }
            catch (Exception ex)
            {
                string v = crear_ex(ex);
                System.IO.File.AppendAllText(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "e.txt"), v);
                throw ex;
            }
        }

        private string crear_ex(Exception ex)
        {
            StringBuilder x = new StringBuilder();
            x.AppendLine(ex.Message);
            if (ex.InnerException != null)
            {
                x.AppendLine("****");
                x.AppendLine(crear_ex(ex.InnerException));
            }
            return x.ToString();
        }
    }
}
