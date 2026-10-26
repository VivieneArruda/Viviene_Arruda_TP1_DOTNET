namespace Exercicio04
{
    public delegate void TemperatureExceededHandler(double temperatura);

    public class TemperatureSensor
    {
        public event TemperatureExceededHandler? TemperatureExceeded;

        public void RegistrarLeitura(double temperatura)
        {
            Console.WriteLine($"Leitura registrada: {temperatura} ºC");

            if (temperatura > 100)
            {
                TemperatureExceeded?.Invoke(temperatura);
            }
        }
    }
}