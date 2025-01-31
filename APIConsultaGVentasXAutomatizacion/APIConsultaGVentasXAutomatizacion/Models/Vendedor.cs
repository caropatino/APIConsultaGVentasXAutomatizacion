namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class Vendedor
    {
        public Guid Id { get; set; }

        public Guid TenantId { get; set; }

        public string Codigo { get; set; }

        public string? Nombre { get; set; }


        public long CompaniaId { get; set; }

        public string Ciudad { get; set; }

        public int Estatus { get; set; }
    }
}
