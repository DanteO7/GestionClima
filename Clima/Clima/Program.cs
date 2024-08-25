using GestionClimatica.Modulos;

class Program
{
    static void Main()
    {
        Clima unClima = new Clima(11, "Nublado");

        Ubicacion unaUbicacion1 = new Ubicacion("San Nicho", "Argentina", unClima);
        Ubicacion unaUbicacion2 = new Ubicacion("Villa Constitucion", "Argentina", unClima);
        Ubicacion unaUbicacion3 = new Ubicacion("Rosario", "Argentina", unClima);

        Meteorologo meteorologo1 = new Meteorologo("Pepito", "Agricola");
        Meteorologo meteorologo2 = new Meteorologo("Juancito", "Normal");
        Meteorologo meteorologo3 = new Meteorologo("Pedrito", "Normal");

        Estacion estacion1 = new Estacion(unaUbicacion1, meteorologo1);
        Estacion estacion2 = new Estacion(unaUbicacion2, meteorologo2);
        Estacion estacion3 = new Estacion(unaUbicacion3, meteorologo3);

        RedClimatica unaRedClimatica = new RedClimatica("Juancito", new List<Estacion> { estacion1, estacion2, estacion3 });

        unaRedClimatica.MostrarDetalle();

        InformeClimatico unInforme = new InformeClimatico("Hoy hizo calor", unaUbicacion3);
        unInforme.GenerarInforme();
    }
}
