namespace TarjetasCredito_API_Rest.Models
{
    public class TarjetasCredito
    {
        public string NumeroTarjeta { get; set; }
        public string ClienteId { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal SaldoActual { get; set; }
        public string PIN { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public bool EstaBloqueada { get; set; }
        public List<Transaccion> Transacciones { get; set; }

        // Constructor parametrizado
        public TarjetasCredito(string numeroTarjeta, string clienteId, decimal limiteCredito, decimal saldoActual,
                               string pin, DateTime fechaExpiracion, bool estaBloqueada, List<Transaccion> transacciones)
        {
            NumeroTarjeta = numeroTarjeta;
            ClienteId = clienteId;
            LimiteCredito = limiteCredito;
            SaldoActual = saldoActual;
            PIN = pin;
            FechaExpiracion = fechaExpiracion;
            EstaBloqueada = estaBloqueada;
            Transacciones = transacciones;
        }

        // Método ToString
        public override string ToString()
        {
            return $"Número de Tarjeta: {NumeroTarjeta}, Cliente ID: {ClienteId}, Límite Crédito: {LimiteCredito:C}, " +
                   $"Saldo Actual: {SaldoActual:C}, Estado: {(EstaBloqueada ? "Bloqueada" : "Activa")}, " +
                   $"Fecha Expiración: {FechaExpiracion.ToShortDateString()}, " +
                   $"Transacciones: {Transacciones?.Count ?? 0} transacciones";
        }

     

        // Realizar pago
        public void RealizarPago(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor que cero.");
            }

            SaldoActual -= monto;
        }

        // Realizar consumo
        public void RealizarConsumo(decimal monto)
        {
            if (monto <= 0 || SaldoActual + monto > LimiteCredito)
            {
                throw new InvalidOperationException("Monto inválido o se excede el límite de crédito.");
            }

            SaldoActual += monto;
        }

        // Renovar tarjeta
        public void RenovarTarjeta()
        {
            FechaExpiracion = FechaExpiracion.AddYears(5); 
        }

        // Cambiar PIN
        public void CambiarPIN(string nuevoPin)
        {
            if (string.IsNullOrEmpty(nuevoPin) || nuevoPin.Length != 4)
            {
                throw new ArgumentException("El PIN debe tener 4 dígitos.");
            }

            PIN = nuevoPin;
        }

        // Bloquear tarjeta
        public void BloquearTarjeta()
        {
            EstaBloqueada = true;
        }

        // Desbloquear tarjeta
        public void DesbloquearTarjeta()
        {
            EstaBloqueada = false;
        }

        // Solicitar aumento de límite de crédito
        public void SolicitarAumentoLimite(decimal nuevoLimite)
        {
            if (nuevoLimite <= LimiteCredito)
            {
                throw new InvalidOperationException("El nuevo límite debe ser mayor al límite actual.");
            }

            LimiteCredito = nuevoLimite;
        }
    }
}