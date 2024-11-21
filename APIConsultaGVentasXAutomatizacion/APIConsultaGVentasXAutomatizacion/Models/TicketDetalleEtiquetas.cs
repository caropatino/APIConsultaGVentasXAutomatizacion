namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class TicketDetalleEtiquetas
    {
        public Guid Id { get; set; }

        public Guid TicketId { get; set; }

        public Etiqueta Etiqueta { get; set; }
    }
}
