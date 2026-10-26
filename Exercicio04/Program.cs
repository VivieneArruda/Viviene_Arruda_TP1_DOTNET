namespace Exercicio04
{
    internal class Program
    {
        static void MostrarAlerta(double temperatura)
        {
            Console.WriteLine($"*** ALERTA: temperatura de {temperatura} ºC acima do limite seguro de 100 ºC! ***");
        }

        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += MostrarAlerta;

            Console.Write("Quantas leituras deseja simular? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite a temperatura da leitura {i}: ");
                double temperatura = Convert.ToDouble(Console.ReadLine());
                sensor.RegistrarLeitura(temperatura);
            }

            Console.WriteLine("Monitoramento finalizado.");
        }
    }
}