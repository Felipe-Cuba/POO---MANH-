using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int codigo;
        private string desc;
        private double preco;

        public int Codigo
        {
            get => codigo;
            set 
            {

                if (value > 0){
                    codigo = value;
                } else {
                    Console.WriteLine($"\nCódigo inserido: {value}\tError ----> Código inválido!!\n");
                }
            }
        }

        public string Desc
        {
            get => desc;
            set
            {
                if (value != ""){
                    desc = value;
                } else {
                    Console.WriteLine($"\nDescrição inserida: {value}\tError ----> Descrição inválida!!\n");
                }
            }
        }

        public double Preco
        {
            get => preco;
            set 
            {
                if (value > 0){
                    preco = value;
                } else {
                    Console.WriteLine($"\nPreço inserido: {value:c}\tError ----> Preço inválido!!\n");
                }
            }
        }
    }
}