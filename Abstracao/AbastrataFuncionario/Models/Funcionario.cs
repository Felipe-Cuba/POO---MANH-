using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbastrataFuncionario.Models
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public List<Dependente> vetDep { get; set; }

        public Funcionario(int c, string n, double s)
        {
            Codigo = c;
            Nome = n;
            Salario = s;
        }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\t Salário: {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);

        public int CalcularTotalDependentes()
        {
            return this.vetDep.ToArray().Length;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            this.vetDep.Add(novoDep);
            // Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            // Console.WriteLine("Dependente adicionado com sucesso!");
            // Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
        }

        public void RemoverDependentesMaiorIdade(int cod)
        {
            Dependente[] arrayDep = vetDep.ToArray();

            for (int i = 0; i < arrayDep.Length; i += 1)
            {
                if (arrayDep[i].Codigo == cod)
                {
                    this.vetDep.Remove(arrayDep[i]);
                }
            }
        }

        public void ListarDependetes()
        {
            Console.WriteLine($"\n-=-=-=-=-=-=-=- Lista dependentes: {this.Nome} -=-=-=-=-=-=-=-\n");
            foreach (Dependente dep in this.vetDep)
            {
                Console.WriteLine($"Codigo: {dep.Codigo}\tNome: {dep.Nome}\tIdade: {dep.Idade}");
            }
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
        }

    }
}