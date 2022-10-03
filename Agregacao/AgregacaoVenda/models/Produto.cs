using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda.models
{
    public class Produto
    {
        /*
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        EXEMPLO DE CRIAÇÃO DE UMA VARIAVEL ESTATICA COM AUTO INCREMENTO

        private static int codigo;

        static Produto()
        {
            codigo = 500;
        }

        public Produto()
        {
            codigo += 1;
        } 
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        */
        private int codigo;
        private string nome;
        private double preco;

        public int Codigo
        {
            get { return codigo; }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get { return nome; }

            set
            {
                if (value != "")
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("Nome inválido!");
                }
            }
        }

        public double Preco
        {
            get { return preco; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("O preço de um produto deve ser maior que 0!!!");
                }
                else
                {
                    preco = value;
                }
            }
        }



        public void MostraAtributos()
        {
            Console.WriteLine($"Codigo: {codigo}\t Nome: {nome}\t Preço: {preco:c}");
        }
    }
}