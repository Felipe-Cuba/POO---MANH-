using EncapsulamentoAluno;
using System;

Aluno a1 = new Aluno();

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Cadastrando Aluno -=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
Console.Write("Digite o número de matricula: ");
a1.Matricula = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o nome do aluno: ");
a1.Nome = Console.ReadLine();

Console.Write("Digite a nota da P1: ");
a1.P1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a nota da P2: ");
a1.P2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=- Dados do aluno -=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

Console.WriteLine($"RA: {a1.Matricula}\nNome: {a1.Nome}\nNota P1: {a1.P1}\tNota P2: {a1.P2}\t Média: {a1.Media}\n");

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");


