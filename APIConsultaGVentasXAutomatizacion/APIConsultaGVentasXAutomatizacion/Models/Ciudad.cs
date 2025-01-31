namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }

        public string Nombre { get; set; }

        public Guid TenantId { get; set; }
    }
}
