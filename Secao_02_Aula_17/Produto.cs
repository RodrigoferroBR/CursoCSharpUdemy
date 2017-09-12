using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_02_Aula_17
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Math.Sqrt(QuantidadeEmEstoque * Preco);
        }

        public string MostrarSaida()
        {
            return $"Dados do Produto: {Nome}, R$ {Preco}, Total: R$ {ValorTotalEmEstoque()}";
        }

        public void EntradaEstoque(int quantidade)
        {
            QuantidadeEmEstoque = QuantidadeEmEstoque + quantidade;
        }

        public void SaidaEstoque(int quantidade)
        {
            QuantidadeEmEstoque = QuantidadeEmEstoque - quantidade;
        }

    }
}
