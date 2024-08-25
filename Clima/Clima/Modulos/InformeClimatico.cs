namespace GestionClimatica.Modulos
{
    public class InformeClimatico
    {
        public DateTime Fecha = DateTime.Now;
        public string Resumen {  get; set; }
        public Ubicacion Ubicacion { get; set; }
        public InformeClimatico(string resumen, Ubicacion ubicacion)
        {
            Resumen = resumen;
            Ubicacion = ubicacion;
        }
        public void GenerarInforme()
        {
            Console.WriteLine($"\nFecha {Fecha}");
            Ubicacion.MostrarDetalles();
            Console.WriteLine($"Resumen: {Resumen}");
        }
    }
}
