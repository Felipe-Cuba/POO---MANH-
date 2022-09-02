using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string desc;
        public double preco;

        public void MostrarProdutos(){
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=- Produto: {desc} =-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\nCódigo: {codigo}\tDescrição do produto: {desc}\tPreço do produto: {preco:c}\n");
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        }

        public void CalcularAumento(double perCent){

            double aumento;
            aumento = perCent/100;
            preco = preco + (aumento*preco);

        }
    }
}