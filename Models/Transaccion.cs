namespace TarjetasCredito_API_Rest.Models
{
    public class Transaccion
    {
        public string Id { get; set; }
        public string NumeroTarjeta { get; set; }
        public TipoTransaccion Tipo { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string EstablecimientoId { get; set; }
        public Transaccion()
        {
            
        }
    }
}
