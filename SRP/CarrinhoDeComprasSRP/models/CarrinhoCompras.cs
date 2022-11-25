using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeComprasSRP.models
{
    public class CarrinhoCompras
    {
        private List<Itens> vetItens = new List<Itens>();
        public CarrinhoCompras()
        {
            this.vetItens = new List<Itens>();
        }
        public List<Itens> VetItens
        {
            get { return vetItens; }
        }
        public bool AdicionarItem(Itens it)
        {
            vetItens.Add(it);
            return true;
        }
        public bool ValidarCarrinho()
        {
            return vetItens.Count > 0;
        }
    }
}