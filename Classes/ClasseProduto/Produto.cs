using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //Declaração de atributos
        public int codigo;
        public string desc;
        public double preco;

        //Declaração dos métodos

        public void MostrarProdutos(){
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\nCódigo: {codigo}\nDescrição do produto: {desc}\nPreço do produto: {preco:c}\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- \n");
        }
    }
}