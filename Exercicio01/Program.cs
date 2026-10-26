namespace Exercicio01
{
    delegate decimal CalculateDiscount(decimal preco);

    internal class Program
    {
        static decimal AplicarDesconto(decimal preco)
        {
            return preco - (preco * 0.10m);
        }

        static void Main(string[] args)
        {
            Console.Write("Informe o preço original do produto: R$ ");
            decimal precoOriginal = Convert.ToDecimal(Console.ReadLine());

            CalculateDiscount calcular = AplicarDesconto;
            decimal precoFinal = calcular(precoOriginal);

            Console.WriteLine($"Preço original: R$ {precoOriginal:F2}");
            Console.WriteLine("Desconto aplicado: 10%");
            Console.WriteLine($"Preço final: R$ {precoFinal:F2}");
        }
    }
}