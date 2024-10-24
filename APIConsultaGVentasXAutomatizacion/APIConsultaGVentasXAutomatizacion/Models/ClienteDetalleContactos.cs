namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class ClienteDetalleContactos
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public Guid ContactoId { get; set; }

        public bool EsPrincipal {  get; set; }
    }
}
