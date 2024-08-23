using GestionClimatica.Modulos;

class Program
{
    static void Main()
    {
        Clima climita = new Clima(10, "Nublado");
        Estacion estacioncita = new Estacion(1, "Calle Falsa 123");
        Ubicacion ubicacioncita = new Ubicacion("Villa Constitucion", "Argentina", climita, estacioncita);
        Meteorologo meteorologito = new Meteorologo("Juancito", estacioncita);
        
        meteorologito.ReportarCondicion(ubicacioncita);
    }
}