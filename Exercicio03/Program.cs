namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> calcularArea = (baseRetangulo, altura) => baseRetangulo * altura;

            Console.Write("Informe a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura do retângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = calcularArea(baseRetangulo, altura);

            Console.WriteLine($"A área do retângulo é: {area:F2}");
        }
    }
}
