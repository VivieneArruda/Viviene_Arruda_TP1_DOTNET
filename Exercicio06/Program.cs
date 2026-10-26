namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> registrarLog = logger.LogToConsole;
            registrarLog += logger.LogToFile;
            registrarLog += logger.LogToDatabase;

            Console.Write("Digite a mensagem de log: ");
            string mensagem = Console.ReadLine() ?? "";

            registrarLog(mensagem);
        }
    }
}