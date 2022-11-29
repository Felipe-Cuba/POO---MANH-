using HerancaFuncionario.Models;

Funcionario f = new Funcionario(1000);

Secretario s = new Secretario(2500);

Mensalista m = new Mensalista(160, 2500);

Horista h = new Horista(8, 2200);

Gerente g = new Gerente(5000);

Diretor d = new Diretor(8900);

Console.WriteLine($"Bonificação funcinário: {f.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação secretario: {s.CalcularBonificacao():c}");
Console.WriteLine($"Horas trabalhadas mensalista: {m.qtdeHorasTrabalhadas}\tBonificação Mensalista: {m.CalcularBonificacao():c}");
Console.WriteLine($"Horas por semana horista: {h.qtdeHorasSemana}\tBonificação Horista: {h.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação gerente: {g.CalcularBonificacao():c}");
Console.WriteLine($"Bonificação diretor: {d.CalcularBonificacao():c}");
