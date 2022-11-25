using System;
using CarrinhoDeCompras.models;

CarrinhoCompras c1 = new CarrinhoCompras();
c1.ExibirItens();
Console.WriteLine("\nValor total: " +
c1.ExibirValotTotal());
Itens it1 = new Itens("Impressora", 1000);
Itens it2 = new Itens("Monitor", 2000);
c1.AdicionarItem(it1);
c1.AdicionarItem(it2);
c1.ExibirItens();
Console.WriteLine("\nValor total: " +
c1.ExibirValotTotal());
if (c1.ConfirmarPedido())
    Console.WriteLine("\nPedido realizado com sucesso.");
else
    Console.WriteLine("\nErro, carrinho não possui itens.");
c1.ExibirStatus();