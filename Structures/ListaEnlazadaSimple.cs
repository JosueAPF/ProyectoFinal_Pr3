using System.Text;
using Microsoft.OpenApi.Models;

namespace TarjetasCredito_API_Rest.Structures
{
    public class ListaEnlazadaSimple<T>
    {
        public Nodo<T> Cabeza { get; set; } 
        public Nodo<T> Ultimo { get; set; }
        public void Enlistar(T dato) {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevo;
                Ultimo = nuevo;
            }
            else { 
                Ultimo.Enlazar(nuevo);
                Ultimo = nuevo;
            }
        }

        public string MostrarLista() { 
            StringBuilder dato = new StringBuilder();
            Nodo<T> auxCabeza = Cabeza;
            while (auxCabeza !=null) { 
                dato.Append(auxCabeza.ToString());  
            }
            return dato.ToString();
        }
    }
}
