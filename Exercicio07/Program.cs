namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Action<string>? registrarLog = null;

            Console.WriteLine("Teste 1 - delegate sem nenhum método associado");
            registrarLog?.Invoke("Mensagem sem destino");
            Console.WriteLine("Nenhuma exceção ocorreu.");
            Console.WriteLine();

            Console.WriteLine("Teste 2 - delegate com os três métodos");
            registrarLog += logger.LogToConsole;
            registrarLog += logger.LogToFile;
            registrarLog += logger.LogToDatabase;
            registrarLog?.Invoke("Sistema iniciado");
            Console.WriteLine();

            Console.WriteLine("Teste 3 - removendo todos os métodos");
            registrarLog -= logger.LogToConsole;
            registrarLog -= logger.LogToFile;
            registrarLog -= logger.LogToDatabase;
            registrarLog?.Invoke("Essa mensagem não deve aparecer");
            Console.WriteLine("Nenhuma exceção ocorreu.");
        }
    }
}
