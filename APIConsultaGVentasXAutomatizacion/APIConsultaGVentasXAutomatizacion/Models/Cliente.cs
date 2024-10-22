﻿namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public Guid TenantId { get; set; }

        public string? Codigo { get; set; }

        public string? Nombre { get; set; }

        public string? NumeroDeIdentificacion { get; set; }

        public int CompaniaId { get; set; }


    }
}