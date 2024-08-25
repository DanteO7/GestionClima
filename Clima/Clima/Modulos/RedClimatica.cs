namespace GestionClimatica.Modulos
{
    public class RedClimatica
    {
        public string Jefe { get; set; }
        private List<Estacion> _estaciones;

        public RedClimatica(string jefe, List<Estacion> estaciones)
        {
            Jefe = jefe;
            if (estaciones.Count < 2)
            {
                throw new Exception("Cantidad de estaciones no válidas. Se necesitan al menos 2");
            }
            _estaciones = estaciones;
        }

        public void AgregarEstacion(Estacion estacion)
        {
            _estaciones.Add(estacion);
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Jefe De la red: {Jefe}");
            foreach (var estacion in _estaciones)
            {
                estacion.MostrarDetalle();
            }
        }
    }
}
