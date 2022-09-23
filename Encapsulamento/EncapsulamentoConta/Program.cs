using System;
using EncapsulamentoConta;

Conta c1 = new Conta();

c1.Numero = 1;
c1.Titular = "Felipe";
c1.Saldo = 1000;

Console.WriteLine($"Saldo: {c1.Saldo:c}");