using System;
using ConstrutorFuncionario;

Funcionario[] funcionarios = new Funcionario[3];

for (int i = 0; i < funcionarios.Length; i++){
    
    funcionarios[i] = new Funcionario();
    
    Console.WriteLine("-=-=-=-=-=-=-=-= Cadastro de funcionário -=-=-=-=-=-=-=-=-");
    // Cadastro nome funcionário

    Console.Write("\nCadastre o nome do funcionário: ");
    funcionarios[i].Nome = Console.ReadLine();

    // Cadastro salário funcionário

    Console.Write("\nCadastre o salário do funcionário: ");
    funcionarios[i].Salario = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

}

Console.WriteLine("-------------------------- Funcionários --------------------------");

foreach (Funcionario f in funcionarios){
    f.MostrarProdutos();
}

Console.WriteLine("------------------------------------------------------------------");

Console.Write("Digite o valor em porcentagem para o aumento do salário dos funcionários: ");
double perCent = Convert.ToDouble(Console.ReadLine());

foreach (Funcionario f in funcionarios){
    f.CalcularAumento(perCent);
}

Console.WriteLine("-------------------------- Funcionários --------------------------");

foreach (Funcionario f in funcionarios){
    f.MostrarProdutos();
}

Console.WriteLine("Quantidade de instâncias: ");

Console.WriteLine("------------------------------------------------------------------");
