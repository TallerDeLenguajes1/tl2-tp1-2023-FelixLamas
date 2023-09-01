namespace TP1
{
    public class Pedido
    {
        private int nro;
        private string obs;
        private Cliente cliente;

        private string estado;

        public Pedido(int nro, string obs, string estado, string nombreC, string direccioC, string telefonoC, string datosDRC){
            this.nro = nro;
            this.obs = obs;
            this.estado = estado;
            cliente = new Cliente(nombreC, direccioC, telefonoC, datosDRC);
        }

        public string VerDireccionCliente(){
            return cliente.direccion + cliente.datosReferenciaDireccion;
        }
    }
}