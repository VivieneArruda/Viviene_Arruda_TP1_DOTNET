namespace Exercicio11
{
    internal class Program
    {
        static string Concatenar(string nome, string sobrenome)
        {
            string resultado = nome + " " + sobrenome;
            Console.WriteLine($"Concatenar retornou: {resultado}");
            return resultado;
        }

        static string ParaMaiusculas(string nome, string sobrenome)
        {
            string resultado = (nome + " " + sobrenome).ToUpper();
            Console.WriteLine($"ParaMaiusculas retornou: {resultado}");
            return resultado;
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            string resultado = (nome + " " + sobrenome).Replace(" ", "");
            Console.WriteLine($"RemoverEspacos retornou: {resultado}");
            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine() ?? "";

            Func<string, string, string> processar = Concatenar;
            processar += ParaMaiusculas;
            processar += RemoverEspacos;

            Console.WriteLine();
            Console.WriteLine("Executando o delegate encadeado:");
            string resultadoFinal = processar(nome, sobrenome);

            Console.WriteLine();
            Console.WriteLine($"Quantidade de métodos no delegate: {processar.GetInvocationList().Length}");
            Console.WriteLine($"Resultado final retornado: {resultadoFinal}");
            
            
        }
    }
}
