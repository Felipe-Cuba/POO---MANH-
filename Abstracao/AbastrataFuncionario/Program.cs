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

Dependente dep1 = new Dependente(1, "Roberto", 13);
Dependente dep2 = new Dependente(2, "Julio", 16);
Dependente dep3 = new Dependente(3, "Ana Julia", 18);
Dependente dep4 = new Dependente(4, "Helena", 35);
Dependente dep5 = new Dependente(5, "Luana", 15);

a1.vetDep = new List<Dependente>();
a2.vetDep = new List<Dependente>();
c1.vetDep = new List<Dependente>();
c2.vetDep = new List<Dependente>();

d1.VetF = new List<Funcionario>();
d2.VetF = new List<Funcionario>();

a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);
a2.AdicionarDependente(dep3);
c1.AdicionarDependente(dep4);
c2.AdicionarDependente(dep5);

d1.AdmitirFuncionario(a1);
d2.AdmitirFuncionario(a2);
d1.AdmitirFuncionario(c1);
d2.AdmitirFuncionario(c2);

a1.ListarDependetes();
a2.ListarDependetes();
c1.ListarDependetes();
c2.ListarDependetes();


d1.MostrarQtdeDependentesFuncionario();
d2.MostrarQtdeDependentesFuncionario();

foreach (Funcionario f in d1.VetF)
{
    Dependente[] arrayDep = f.vetDep.ToArray();

    for (int i = 0; i < arrayDep.Length; i += 1)
    {
        if (arrayDep[i].VerificarMaiorIdade())
        {
            f.RemoverDependentesMaiorIdade(arrayDep[i].Codigo);
        }
    }
}

foreach (Funcionario f in d2.VetF)
{
    Dependente[] arrayDep = f.vetDep.ToArray();

    for (int i = 0; i < arrayDep.Length; i += 1)
    {
        if (arrayDep[i].VerificarMaiorIdade())
        {
            f.RemoverDependentesMaiorIdade(arrayDep[i].Codigo);
        }
    }
}

a1.ListarDependetes();
a2.ListarDependetes();
c1.ListarDependetes();
c2.ListarDependetes();

d1.MostrarQtdeDependentesFuncionario();
d2.MostrarQtdeDependentesFuncionario();
