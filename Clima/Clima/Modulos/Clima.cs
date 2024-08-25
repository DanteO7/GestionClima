namespace GestionClimatica.Modulos
{
    public class Clima
    {
        public double Temperatura { get; set; }
        public string Condicion { get; set; }


        public Clima(double temperatura, string condicion)
        {
            Temperatura = temperatura;
            Condicion = condicion;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Temperatura: {Temperatura}°C\n" +
                $"Condicion: {Condicion}");
        }
    }
}
