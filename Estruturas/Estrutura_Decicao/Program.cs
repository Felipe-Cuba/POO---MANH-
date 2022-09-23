using System;

double salario;

Console.Write("Digite o salário:");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Seu salário é R$ {salario}");

if (salario > 5000)
    Console.WriteLine("Paga imposto INSS");

else if (salario <= 1000)
    Console.WriteLine("Não paga impostos");

else
    Console.WriteLine("Paga IR");

int mes = 1;

switch(mes)
{
    case 1: Console.WriteLine("Janeiro");
        break;
    case 2: Console.WriteLine("Fevereiro");
        break;
    default: Console.WriteLine("Mês Inválido");
        break;
}



