using HerancaFuncionario.Models;

Funcionario f = new Funcionario(1000);

Secretario s = new Secretario(2500);

Gerente g = new Gerente(5000);

Diretor d = new Diretor(8900);

Console.WriteLine($"Bonificação funcinário: {f.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação secretario: {s.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação gerente: {g.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação diretor: {d.CalcularBonificacao():c}");
