namespace Exercicio05
{
    public class DownloadManager
    {
        public event Action<string>? DownloadCompleted;

        public void IniciarDownload(string arquivo)
        {
            Console.WriteLine($"Iniciando download de {arquivo}...");

            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Baixando... {i * 20}%");
            }

            DownloadCompleted?.Invoke(arquivo);
        }
    }
}
