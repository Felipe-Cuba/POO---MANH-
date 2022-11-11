using AbastrataFuncionario.Models;

// Instancia de assalariados
Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 2000);

// Instancia de comissionados
Comissionado c1 = new Comissionado(3, "Leo", 3000, 10);
Comissionado c2 = new Comissionado(4, "Teo", 4000, 20);

// Instancia de departamentos
Departamento d1 = new Departamento(50, "TI");
Departamento d2 = new Departamento(51, "RH");

d1.VetF = new List<Funcionario>();
d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(c1);

d2.VetF = new List<Funcionario>();
d2.AdmitirFuncionario(a2);
d2.AdmitirFuncionario(c2);

d1.ListarFuncionarios();
d2.ListarFuncionarios();

d1.RemoverFuncionario(1);
d1.ListarFuncionarios();

Console.WriteLine($"Total: {d1.CalcularFolhaPagamento(30):c}");
Console.WriteLine();
Console.WriteLine($"Total: {d2.CalcularFolhaPagamento(30):c}");



