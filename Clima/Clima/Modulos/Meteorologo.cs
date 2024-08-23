namespace GestionClimatica.Modulos
{
    public class Meteorologo
    {
        public string Nombre { get; set; }
        public Estacion Estacion { get; set; }
        public Meteorologo(string nombre, Estacion estacion)
        {
            Nombre = nombre;
            Estacion = estacion;
        }
        public void ReportarCondicion(Ubicacion ubicacion)
        {
            Estacion.ObtenerClima(ubicacion);
        }
    }
}
