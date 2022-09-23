using System;
using ClasseProduto;
Produto p1 = new Produto();
Produto p2 = new Produto();

Console.WriteLine("-=-=-=-=-=-=-=-=-= Cadastro Produto -=-=-=-=-=-=-=-=-=-");

Console.Write("\nCadastre o código do produto: ");
p1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("\nCadastre o nome do produto: ");
p1.desc = Console.ReadLine();
Console.Write("\nCadastre o salário do produto: ");
p1.preco = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine("-=-=-=-=-=-=-=-=-= Cadastro Produto -=-=-=-=-=-=-=-=-=-");

Console.Write("\nCadastre o código do produto: ");
p2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("\nCadastre o nome do produto: ");
p2.desc = Console.ReadLine();
Console.Write("\nCadastre o salário do produto: ");
p2.preco = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");

p1.MostrarProdutos();
p2.MostrarProdutos();

Console.WriteLine($"\nTotal: {(p1.preco + p2.preco):c}");
