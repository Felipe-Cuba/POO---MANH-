using System;
using ComposicaoBanco.models;


ContaCorrente conta1 = new ContaCorrente();
conta1.Saldo = 1000;
conta1.ChequeEspecial = 250;

ContaCorrente conta2 = new ContaCorrente();
conta2.Saldo = 2000;
conta2.ChequeEspecial = 500;

Poupanca poupanca1 = new Poupanca();
poupanca1.Saldo = 1000;

Poupanca poupanca2 = new Poupanca();
poupanca2.Saldo = 2000;

List<Poupanca> poups = new List<Poupanca>();
List<ContaCorrente> contas = new List<ContaCorrente>();

poups.Add(poupanca1);
poups.Add(poupanca2);

contas.Add(conta1);
contas.Add(conta2);

Banco banco = new Banco(poups, contas);

int cont = 0;

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=- Poupanças -=-=-=-=-=-=-=-=-=-=-=-");
foreach (Poupanca p in banco.Poups)
{
    cont += 1;
    Console.WriteLine($"Saldo poupança {cont}: {p.Saldo}");
}

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
cont = 0;
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=- Contas -=-=-=-=-=-=-=-=-=-=-=-");
foreach (ContaCorrente c in banco.Contas)
{
    cont += 1;
    Console.WriteLine($"Saldo conta {cont}: {c.Saldo}");
    Console.WriteLine($"Cheque especial conta {cont}: {c.ChequeEspecial}");
}
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

banco = null;
GC.Collect();

