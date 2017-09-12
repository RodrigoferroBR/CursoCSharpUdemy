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
            prod.Preco = double.Parse(Console.ReadLine());

            Console.Write("Digite quantidade em Estoque: ");
            prod.QuantidadeEmEstoque = int.Parse(Console.ReadLine());

        }
    }
}
