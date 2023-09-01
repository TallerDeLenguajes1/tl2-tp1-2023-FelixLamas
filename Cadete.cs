namespace TP1
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        private List<Pedido> pedidos;

        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public double calcularJornal(List<Pedido> pedidos)
        {
            return  pedidos.Count() * 500;
        }

    }    
}
