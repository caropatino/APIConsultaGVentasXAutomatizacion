﻿using System.Diagnostics.Contracts;
using System;
using System.Linq.Expressions;
using APIConsultaGVentasXAutomatizacion.Models;
using APIConsultaGVentasXAutomatizacion.Context;
using Microsoft.EntityFrameworkCore;

namespace APIConsultaGVentasXAutomatizacion.Services
{
    public class ClientesAppService : IClientesAppService
    {

        private readonly AppDbContext _context;
        public ClientesAppService(AppDbContext context)
            {
                _context = context;
            }
    
        public bool ValidarRIF(string RIF)
        {

            var digitosRIF = RIF.Substring(1,8).Chunk(1);

            int digitoVerificador = int.Parse(RIF.Substring(RIF.Length-1));


            int[] clave = { 3, 2, 7, 6, 5, 4, 3, 2 };

            int suma = 0;

            for (int i = 0; i < digitosRIF.Count(); i++)
            {
                suma = suma + (int.Parse(digitosRIF.ElementAt(i)) * clave[i]);
            }

            var letraRIF = RIF.Substring(0, 1);

            switch (letraRIF)
            {
                case "V":
                    suma = suma + 4; 
                    break;

                case "E":
                    suma = suma + 8;
                    break;

                case "J":
                    suma = suma + 12;
                    break;
            }

            int digitoCalculado = 11 - (suma % 11);

            if (digitoCalculado == digitoVerificador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Cliente> GetClienteXIdentificacion(string NroIdentificacion)
        {
            return _context.AppClientes
                .Where(c => c.NumeroDeIdentificacion.Equals(NroIdentificacion)
                    && c.TenantId == new Guid("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                    && c.CompaniaId == 5).ToList();
        }

        public List<ClienteDTO> GetDetallesCliente(Guid ClienteId)
        {
            return _context.AppClientes
                .Where(c => c.Id == ClienteId
                    && c.TenantId == new Guid("018FFA54-0C99-E0C2-7202-39F9BCBA9B8E")
                    && c.CompaniaId == 5
                    && c.Contactos.ClienteId == ClienteId
                    && c.Contactos.EsPrincipal == true)
                .Select(x => new ClienteDTO
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    ContactoId = x.Contactos.ContactoId,
                    VendedorId = x.VendedorId
                })
                .ToList();
        }


    }
}
