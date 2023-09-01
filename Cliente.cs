namespace TP1
{
    public class Cliente
{
    public string nombre;
    public string direccion;
    public string telefono;
    public string datosReferenciaDireccion;

    public Cliente(string nombre, string direccion, string telefono, string datosReferenciaDireccion){
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.datosReferenciaDireccion = datosReferenciaDireccion;
    }

}
}