public class SistemaDeSeguridad
{
    private Camara camara;
    private SensorTemperatura sensorTemperatura;
    private Alarma alarma;

    public SistemaDeSeguridad()
    {
        camara = new Camara();
        sensorTemperatura = new SensorTemperatura();
        alarma = new Alarma(); 
    }

    public void activarSistema()
    {
        Console.WriteLine("######Activando sistema de seguridad#######");
        camara.encender();
        sensorTemperatura.iniciar();
        alarma.activar();
        Console.WriteLine("######Sistema de seguridad activado######");
    }
}