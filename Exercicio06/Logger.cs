namespace Exercicio06
{
    public class Logger
    {
        public void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[CONSOLE] {mensagem}");
        }

        public void LogToFile(string mensagem)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now} - {mensagem}{Environment.NewLine}");
            Console.WriteLine("[ARQUIVO] Mensagem gravada em log.txt");
        }

        public void LogToDatabase(string mensagem)
        {
            Console.WriteLine($"[BANCO] INSERT INTO Logs (Mensagem) VALUES ('{mensagem}') - simulado");
        }
    }
}
