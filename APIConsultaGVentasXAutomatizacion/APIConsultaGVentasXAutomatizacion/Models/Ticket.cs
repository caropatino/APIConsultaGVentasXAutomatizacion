namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public Guid TenantId { get; set; }

        public string Codigo { get; set; }

        public string? Descripcion { get; set; }

        public DateTime CreationTime { get; set; }

        public int Estatus { get; set; }

        public Guid ClienteId { get; set; } 

        public long CompaniaId { get; set; }
    }
}
