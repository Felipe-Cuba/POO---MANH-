using System;
using ClasseConta;
//  Main()

//Declarando uma variável
Conta c1;

//Instancia de objeto
c1 = new Conta();

c1.numero = 032659;
c1.titular = "Felipe";
c1.saldo = 1000;

c1.MostrarAtributos();
Console.Write("\nDigite o valor que deseja depositar em sua conta: ");
double valorDeposito = Convert.ToDouble(Console.ReadLine());

c1.Depositar(valorDeposito);
Console.WriteLine($"\n{c1.titular} depositou {valorDeposito:c}\n");
c1.MostrarAtributos();

Console.Write("\nDigite o valor que deseja sacar de sua conta: ");
double valorSaque = Convert.ToDouble(Console.ReadLine());
c1.Sacar(valorSaque);
Console.WriteLine($"\n{c1.titular} sacou {valorSaque:c}\n");
c1.MostrarAtributos();



Conta c2 = new Conta();
c2.numero = 1032568;
c2.titular = "Leo";

c2.MostrarAtributos();
Console.Write("\nDigite o valor que deseja depositar em sua conta: ");
valorDeposito = Convert.ToDouble(Console.ReadLine());
c2.Depositar(valorDeposito);
Console.WriteLine($"\n{c2.titular} depositou {valorDeposito:c}\n");
c2.MostrarAtributos();

Console.Write("\nDigite o valor que deseja sacar de sua conta: ");
valorSaque = Convert.ToDouble(Console.ReadLine());
c2.Sacar(valorSaque);
Console.WriteLine($"\n{c1.titular} depositou {valorSaque:c}\n");
c2.MostrarAtributos();

Console.Write("Digite o valor que deseja tranferir para Leo: ");
double valorTransferir = Convert.ToDouble(Console.ReadLine());

if( valorTransferir > c1.saldo){
    Console.WriteLine("\nVocê não possui esse valor em sua conta!!");
} else {
    c1.Transferir(valorTransferir, c2);

    Console.WriteLine($"\n{c1.titular} transferiu {valorTransferir:c} para {c2.titular}\n");

    c1.MostrarAtributos();
    c2.MostrarAtributos();
}

Console.Write("Digite o valor que deseja tranferir para Felipe: ");
valorTransferir = Convert.ToDouble(Console.ReadLine());

if( valorTransferir > c2.saldo){
    Console.WriteLine("\nVocê não possui esse valor em sua conta!!");
} else {
    c2.Transferir(valorTransferir, c1);

    Console.WriteLine($"\n{c2.titular} transferiu {valorTransferir:c} para {c1.titular}\n");

    c1.MostrarAtributos();
    c2.MostrarAtributos();
}








