using System;
using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();

f1.Codigo = 1;
f1.Nome = "Ana";
f1.Salario = 1000;

Console.WriteLine($"Nome do funcionário: {f1.Nome}");// get

if(f1.Salario > 5000){
    Console.WriteLine("Paga imposto");
} else {
    Console.WriteLine("Não paga imposto");
}
