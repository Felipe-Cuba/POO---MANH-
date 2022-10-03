// 1. Criar as classes de acordo com o trecho de diagrama de classe anexo
// 2. A comissão do vendedor é gerada referente a 2% do preço do produto vendido
// 3. Na instância de um comprador, conceda um valor de verba
// 4. Quando realizar uma venda subtraia o valor da verba
// 5. É para ser realizada mais de uma venda, para usar o vetor/List de produtos
// 6. No cadastro de produtos, o código inicial é 500
// 7. Use encapsulamento completo (com tratamento de valores digitados) para os atributos da classe Produto
// 8. Realizar instâncias necessárias para testar as classes
using System;
using AgregacaoVenda.models;

//Instância da classe Venda
Venda vendas = new Venda();

//Definindo verba do comprador
double verba = 0;

Console.Write("Informe a verba do comprador: ");
verba = Convert.ToDouble(Console.ReadLine());
vendas.Comp = new Comprador(verba);

//Definindo o restante dos atributos da venda
vendas.Vend = new Vendedor();
vendas.VetorProduto = new List<Produto>();

int codigoInicial = 500;

double precoInformado, comissao = 0, totalPagar = 0, perCent = 2;
string nomeInformado;

Produto[] produtos = new Produto[3];

//Definição dos produtos

for (int i = 0; i < produtos.Length; i++)
{
    precoInformado = 0;
    nomeInformado = "";
    produtos[i] = new Produto();
    produtos[i].Codigo = codigoInicial + i;
    Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
    Console.Write("Informe o nome do produto: ");
    nomeInformado = Console.ReadLine();
    Console.Write("Informe o preço do produto: ");
    precoInformado = Convert.ToDouble(Console.ReadLine());
    comissao += precoInformado * (perCent / 100);
    totalPagar += precoInformado;

    produtos[i].Nome = nomeInformado;
    produtos[i].Preco = precoInformado;

    vendas.VetorProduto.Add(produtos[i]);
}

//Apresentação dos dados

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
Console.WriteLine("Nota da venda:\n");
foreach (Produto p in produtos)
{
    p.MostraAtributos();
}
Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

if (vendas.Comp.Verba < totalPagar)
{
    vendas.Comp.MostrarAtributos();
    Console.WriteLine($"Total a pagar: {totalPagar:c}\n");
    Console.WriteLine("O comprador não possui dinheiro suficiente para pagar!");
    Console.WriteLine("Portanto a venda não será realizada!");
}
else
{
    vendas.Comp.MostrarAtributos();
    Console.WriteLine($"Total a pagar: {totalPagar:c}\n");
    vendas.Comp.Verba -= totalPagar;
    Console.WriteLine("Pagamento realizado!\n");
    Console.WriteLine($"-----------------------------------------------------------------------\n");
    vendas.Comp.MostrarAtributos();
    Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

    vendas.Vend.Comissao = comissao;
    vendas.Vend.MostraAtributos();
}
