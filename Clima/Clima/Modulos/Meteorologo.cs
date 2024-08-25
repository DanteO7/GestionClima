namespace GestionClimatica.Modulos
{
    public class Meteorologo
    {
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Meteorologo(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public void MostrarDetall()
        {
            Console.WriteLine($"Meteorólogo: {Nombre}");
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}

