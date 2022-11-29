using System;
using InterfaceTributavel.models;

ContaCorrente cc = new ContaCorrente(5000);

SeguroDeVida sv = new SeguroDeVida();

TotalizadorDeTributos tt = new TotalizadorDeTributos();

Console.WriteLine("\n-=-=-=-=-=-=- Resultados -=-=-=-=-=-=-\n");

Console.WriteLine($"Saldo conta corrente: {cc.saldo:c}");
Console.WriteLine($"Tributo conta corrente: {cc.CalcularTributos():c}");
Console.WriteLine($"Tributo seguro de vida: {sv.CalcularTributos():c}");

Console.WriteLine("\n-=-=-=-=-=-=- Total -=-=-=-=-=-=-\n");

tt.Adiciona(cc);
tt.Adiciona(sv);

Console.WriteLine($"Total de tributos a pagar: {tt.total:c}");

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
