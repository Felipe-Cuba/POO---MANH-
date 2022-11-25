using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeComprasSRP.models
{
    public class Itens
    {
        private string descricao;
        private double valor;

        public Itens(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public void MostraItens()
        {
            Console.WriteLine($"Descrição: {this.Descricao}\tValor: {this.Valor:c}");
        }
    }
}