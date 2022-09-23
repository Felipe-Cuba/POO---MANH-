using System;
using ClasseFuncionário;

Funcionario f1 = new Funcionario();

Console.WriteLine("-=-=-=-=-=-=-=-=-= Cadastro Funcionário -=-=-=-=-=-=-=-=-=-");

Console.Write("\nCadastre o código do funcinário: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("\nCadastre o nome do funcionário: ");
f1.nome = Console.ReadLine();
Console.Write("\nCadastre o salário do funcionário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

f1.MostrarAtributos();