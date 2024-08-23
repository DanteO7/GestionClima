namespace GestionClimatica.Modulos
{
    public class Clima
    {
        public decimal TemperaturaC {  get; set; }
        public string Condicion { get; set; }
        public Clima(decimal temperaturaC, string condicion)
        {
            TemperaturaC = temperaturaC;
            Condicion = condicion;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Temperatura en Celcius: {TemperaturaC}\nCondicion: {Condicion}");
        }
    }
}
