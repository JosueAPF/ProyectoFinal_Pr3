using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace TarjetasCredito_API_Rest.Models;
public class Clientes
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string DPI { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public List<TarjetasCredito> Tarjetas;
    public Clientes()
    {
        
    }
    public Clientes(string id, string nombre, string apellido, string dpi, string direccion, string telefono, string email, DateTime fechaNacimiento, List<TarjetasCredito> tarjetas)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        DPI = dpi;
        Direccion = direccion;
        Telefono = telefono;
        Email = email;
        FechaNacimiento = fechaNacimiento;
        Tarjetas = tarjetas;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, DNI: {DPI}, " +
               $"Dirección: {Direccion}, Teléfono: {Telefono}, Email: {Email}, " +
               $"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, " +
               $"Tarjetas: {Tarjetas?.Count ?? 0} tarjetas asociadas";
    }
    

}




