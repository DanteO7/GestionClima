namespace GestionClimatica.Modulos
{
    public class Estacion
    {
        public int NumeroEstacion {  get; set; }
        public string Direccion { get; set; }
        public Estacion(int numeroEstacion,string direccion)
        {
            NumeroEstacion = numeroEstacion;
            Direccion = direccion;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Numero de estacion: {NumeroEstacion}, Direccion: {Direccion}");
        }
        public void ObtenerClima(Ubicacion ubicacion)
        {
            ubicacion.MostrarDetalles();
        }
    }
}
