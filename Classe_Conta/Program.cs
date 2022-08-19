using System;
using ClasseConta;
//  Main()

//Declarando uma variável
Conta c1;

//Instancia de objeto
c1 = new Conta();

c1.numero = 1;
c1.titular = "Felipe";
c1.saldo = 1000;

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine($"\nNome do titular: {c1.titular}\nNumero da conta: {c1.numero}\nSaldo da conta: {c1.saldo:c}\n");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");



