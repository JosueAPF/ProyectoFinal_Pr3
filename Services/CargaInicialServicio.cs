using TarjetasCredito_API_Rest.Data;
using TarjetasCredito_API_Rest.Models;

namespace TarjetasCredito_API_Rest.Services
{
    public class CargaInicialServicio
    {
        public LecturaDatos<Clientes> lecturaClientes;
        public LecturaDatos<TarjetasCredito> lecturaTarjetas;
        public CargaInicialServicio(LecturaDatos<Clientes> clientes,LecturaDatos<TarjetasCredito> tarjetas)
        {
            lecturaClientes = clientes;
            lecturaTarjetas = tarjetas;

            lecturaClientes.Lectura("Clientes.json");
            lecturaTarjetas.Lectura("Tarjetas.json");
        }

        public List<Clientes> verClientes(){
            return lecturaClientes.MostrarDatos();
        }
        public List<TarjetasCredito> verTarjetas() {
            return lecturaTarjetas.MostrarDatos();
        }
        public string mirarRuta() {
            return lecturaClientes.mostrarRuta();
        }

    }
}
