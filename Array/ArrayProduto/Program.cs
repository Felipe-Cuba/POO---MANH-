using System;
using ArrayProduto;


Produto[] vetorProduto = new Produto[1];


for (int i = 0; i < vetorProduto.Length; i++){
    vetorProduto[i] = new Produto();

    Console.WriteLine("-=-=-=-=-=-=-=-= Cadastro de conta -=-=-=-=-=-=-=-=-");
    //Cadastro do número da conta
    Console.Write("\nCadastre o código do produto: ");
    vetorProduto[i].codigo = Convert.ToInt32(Console.ReadLine());
    //Cadastro do titular da conta
    Console.Write("\nCadastre a descrição do produto: ");
    vetorProduto[i].desc = Console.ReadLine();
    //Cadastro do saldo da conta
    Console.Write("\nCadastre o preço do produto: ");
    vetorProduto[i].preco = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
}

Console.WriteLine($"\n------------------------- Produtos -------------------------\n");

foreach (Produto p in vetorProduto){
    p.MostrarProdutos();
}

Console.WriteLine($"\n------------------------------------------------------------\n");



Console.Write("Valor em porcentagem que deseja aplicar aos produtos(Em caso de números decimais utilize ','): ");

double perCent = Convert.ToDouble(Console.ReadLine()); 

foreach (Produto p in vetorProduto){
    p.CalcularAumento(perCent);
}



Console.WriteLine($"\n------------------------- Produtos -------------------------\n");

foreach (Produto p in vetorProduto){
    p.MostrarProdutos();
}

Console.WriteLine($"\n------------------------------------------------------------\n");
