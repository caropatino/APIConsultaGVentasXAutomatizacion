namespace APIConsultaGVentasXAutomatizacion.Models
{
    public class OportunidadDeVenta
    {
        public Guid Id { get; set; }

        public Guid TenantId { get; set; }

        public long CompaniaId {  get; set; }

        public string Numero {  get; set; }

        public Guid ClienteId { get; set; }

        public Guid TipoDeProductoOVId { get; set; }

        public int Estado {  get; set; }

        public OportunidadDeVentaDetalleProducto Productos { get; set; }

    }
}
