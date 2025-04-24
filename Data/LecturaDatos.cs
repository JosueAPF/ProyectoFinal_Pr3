using System.Text.Json;
using System.Text.Json.Serialization;
using TarjetasCredito_API_Rest.Models;
using TarjetasCredito_API_Rest.Structures;

namespace TarjetasCredito_API_Rest.Data
{
    public class LecturaDatos<T>
    {
        public string Ruta { get; set; }
        public List<T> miLista;
        public LecturaDatos(IWebHostEnvironment env)
        {
            miLista = new List<T>();
            Ruta = Path.Combine(env.ContentRootPath,"Data");
            Console.WriteLine($"[DEBUG] Buscando JSON en: {Ruta}");
        }
        public void Lectura(string nombreArchivo) {
            string rutaCompleta = Path.Combine(Ruta, nombreArchivo);
            Console.WriteLine(rutaCompleta);    
            if (File.Exists(rutaCompleta))
            {
                try { 
                    var LecturaJson = File.ReadAllText(rutaCompleta);
                    Console.WriteLine(LecturaJson);
                    miLista = JsonSerializer.Deserialize<List<T>>(LecturaJson);
 
                }
                catch
                {
                    miLista = new List<T>();  
                }
            }
            else {
                Console.WriteLine("No existe");
            }
        }
        public  List<T> MostrarDatos(){ 
            return miLista;
        }

        public string mostrarRuta() {
            return Ruta;
        }
    }
}
