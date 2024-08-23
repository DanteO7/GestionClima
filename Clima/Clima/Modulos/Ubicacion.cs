namespace GestionClimatica.Modulos
{
    public class Ubicacion
    {
        public string Ciudad {  get; set; }
        public string Pais {  get; set; }
        public Clima Clima { get; set; }
        public Estacion Estacion { get; set; }
        public Ubicacion(string ciudad, string pais, Clima clima, Estacion estacion)
        {
            Ciudad = ciudad;
            Pais = pais;
            Clima = clima;
            Estacion = estacion;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Ciudad: {Ciudad}\nPais: {Pais}\nEstacion encargada:");
            Estacion.MostrarDetalles();
            Clima.MostrarDetalles();
        }
    }
}
