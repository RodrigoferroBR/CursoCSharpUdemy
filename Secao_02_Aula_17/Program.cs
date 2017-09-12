using System;

namespace Secao_02_Aula_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new Produto();

            Console.Write("Digite os dados do Produto: ");
            prod.Nome = Console.ReadLine();

            Console.Write("Digite o preço do Produto: ");
            prod.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quantidade em Estoque: ");
            prod.QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine(prod.MostrarSaida());
            Console.ReadKey();

            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            var entrada = int.Parse(Console.ReadLine());
            prod.EntradaEstoque(entrada);
            Console.WriteLine(prod.MostrarSaida());
            Console.ReadKey();

            Console.Write("Digite a quantidade de produtos que sairam no estoque: ");
            var saida = int.Parse(Console.ReadLine());
            prod.SaidaEstoque(saida);
            Console.WriteLine(prod.MostrarSaida());
            Console.ReadKey();

        }
    }
}
