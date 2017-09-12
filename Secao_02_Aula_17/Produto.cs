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
            return (QuantidadeEmEstoque * Preco);
        }

        public string MostrarSaida()
        {
            return $"Dados do Produto: {Nome} - {string.Format("{0:C}", Preco)} - {QuantidadeEmEstoque} Unidade(s) - Total: {string.Format("{0:C}", ValorTotalEmEstoque())}";
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
