namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> mensagemPortugues = nome => Console.WriteLine($"Olá, {nome}! Seja bem-vindo ao sistema.");
            Action<string> mensagemIngles = nome => Console.WriteLine($"Hello, {nome}! Welcome to the system.");
            Action<string> mensagemEspanhol = nome => Console.WriteLine($"¡Hola, {nome}! Bienvenido al sistema.");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.WriteLine("Escolha o idioma:");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");
            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Action<string> exibirBoasVindas;

            switch (opcao)
            {
                case 1:
                    exibirBoasVindas = mensagemPortugues;
                    break;
                case 2:
                    exibirBoasVindas = mensagemIngles;
                    break;
                case 3:
                    exibirBoasVindas = mensagemEspanhol;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            exibirBoasVindas(nome);
        }
    }
}