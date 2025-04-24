namespace TarjetasCredito_API_Rest.Structures
{
    public class Nodo<T>
    {
        public T Dato { get; set; }
        public Nodo<T> Sig { get; set; }
        public Nodo(T dato) { 
            this.Dato = dato;
            this.Sig = null;
        }
        public Nodo<T> Enlazar(Nodo<T> nodo) {
            this.Sig = nodo;
            return nodo;
        }
        public override string ToString()
        {
            return $"{Dato}";
        }
    }
}
