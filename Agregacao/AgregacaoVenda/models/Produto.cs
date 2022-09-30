using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda.models
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;

        public int Codigo
        {
            get { return codigo; }

            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }

            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }

            set { preco = value; }
        }

        public void MostraAtributos()
        {
            Console.WriteLine($"Codigo: {codigo}\t Nome: {nome}\t Preço: {preco}");
        }
    }
}