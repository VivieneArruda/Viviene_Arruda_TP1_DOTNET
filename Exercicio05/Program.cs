namespace Exercicio05
{
    internal class Program
    {
        static void AvisarConclusao(string arquivo)
        {
            Console.WriteLine($"Download concluído! O arquivo {arquivo} está pronto para uso.");
        }

        static void Main(string[] args)
        {
            DownloadManager gerenciador = new DownloadManager();
            gerenciador.DownloadCompleted += AvisarConclusao;

            Console.Write("Digite o nome do arquivo para download: ");
            string arquivo = Console.ReadLine() ?? "";

            gerenciador.IniciarDownload(arquivo);
        }
    }
}