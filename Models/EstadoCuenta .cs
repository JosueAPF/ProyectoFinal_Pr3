using System.Collections.Generic;

namespace TarjetasCredito_API_Rest.Models
{
    public class EstadoCuenta
    {
        public string Id {get;set;}
        public string NumeroTarjeta { get; set; }
        public DateTime FechaInicio { get; set; }
        public  DateTime FechaFin { get; set; }
        public  decimal SaldoAnterior { get; set; }
        public decimal SaldoActual { get; set; }
        public decimal PagoMinimo { get; set; }
        public  decimal PagoTotal { get; set; }
        public List<Transaccion> Transacciones;
        public DateTime FechaVencimiento;

        public EstadoCuenta(string id, string numeroTarjeta, DateTime fechaInicio, DateTime fechaFin,
                            decimal saldoAnterior, decimal saldoActual, decimal pagoMinimo, decimal pagoTotal,
                            List<Transaccion> transacciones, DateTime fechaVencimiento)
        {
            Id = id;
            NumeroTarjeta = numeroTarjeta;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            SaldoAnterior = saldoAnterior;
            SaldoActual = saldoActual;
            PagoMinimo = pagoMinimo;
            PagoTotal = pagoTotal;
            Transacciones = transacciones;
            FechaVencimiento = fechaVencimiento;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Número de Tarjeta: {NumeroTarjeta}, Fecha Inicio: {FechaInicio.ToShortDateString()}, " +
                   $"Fecha Fin: {FechaFin.ToShortDateString()}, Saldo Anterior: {SaldoAnterior:C}, Saldo Actual: {SaldoActual:C}, " +
                   $"Pago Mínimo: {PagoMinimo:C}, Pago Total: {PagoTotal:C}, Fecha de Vencimiento: {FechaVencimiento.ToShortDateString()}, " +
                   $"Transacciones: {Transacciones?.Count ?? 0} transacciones";
        }


    }
}
