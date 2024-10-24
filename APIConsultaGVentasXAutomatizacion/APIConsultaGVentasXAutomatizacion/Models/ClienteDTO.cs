namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }

        public string Codigo { get; set; }

        public Guid ContactoId { get; set; }

        public Guid VendedorId { get; set; }
    }
}
