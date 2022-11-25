using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarrinhoDeComprasSRP.models
{
    public class Pedidos
    {
        private string status;
        private double valorPedido;
        private CarrinhoCompras carrinhoCompra;
        public Pedidos()
        {
            Status = "Aberto";
            carrinhoCompra = new CarrinhoCompras();
        }
        public bool Confirmar()
        {
            if (carrinhoCompra.ValidarCarrinho())
            {
                Status = "Confirmado";
                return true;
            }
            return false;
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public CarrinhoCompras CarrinhoCompra
        {
            get { return carrinhoCompra; }
            set { carrinhoCompra = value; }
        }
        public double ValorPedido
        {
            get { return valorPedido; }
            set { valorPedido = value; }
        }
    }
}