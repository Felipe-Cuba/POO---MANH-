using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda.models
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProduto;

        public Comprador Comp
        {
            get { return comp; }
            set
            {
                if (value != null)
                {
                    comp = value;
                }
                else
                {
                    Console.WriteLine("Comprador está vazio! Portanto não foi adicionado!");
                }
            }
        }

        public Vendedor Vend {
            get {return vend;}
            set {
                if(value != null) {
                    vend = value;
                } else {
                    Console.WriteLine("Vendedor está vazio! Portanto não foi adicionado");
                }
            }
        }

        public List<Produto> VetorProduto
        {
            get { return vetProduto; }

            set
            {
                if (value != null)
                {
                    vetProduto = value;
                }
                else
                {
                    Console.WriteLine("Produto vazio! Portanto não foi adicionado!");
                }

            }

        }


    }
}