namespace GestionClimatica.Modulos
{
    public class Estacion
    {
        private static List<string> ciudades = new List<string>();
        private Ubicacion _ubicacion = null!;
        private static List<string> meteorologos = new List<string>();
        private Meteorologo _meteorologo = null!;

        public Ubicacion Ubicacion
        {
            get { return _ubicacion; }
            set
            {
                if (string.IsNullOrEmpty(value.Ciudad))
                {
                    throw new ArgumentException("La ciudad no puede ser nula o vacía");
                }
                if (ciudades.Contains(value.Ciudad))
                {
                    throw new Exception("No puede ingresar una ciudad repetida");
                }
                else
                {
                    _ubicacion = value;
                    ciudades.Add(value.Ciudad);
                }
            }
        }

        public Meteorologo Meteorologo
        {
            get { return _meteorologo; }
            set
            {
                if (string.IsNullOrEmpty(value.Nombre))
                {
                    throw new ArgumentException("El nombre del meteorólogo no puede ser nulo o vacío");
                }
                if (meteorologos.Contains(value.Nombre))
                {
                    throw new Exception("No puede ingresar un meteorólogo repetido");
                }
                else
                {
                    _meteorologo = value;
                    meteorologos.Add(value.Nombre);
                }
            }
        }

        public Estacion(Ubicacion ubicacion, Meteorologo meteorologo)
        {
            Ubicacion = ubicacion;
            Meteorologo = meteorologo;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine("\nDetalles de la Estación:");
            Ubicacion.MostrarDetalles();
            Meteorologo.MostrarDetall();
        }
    }
}
