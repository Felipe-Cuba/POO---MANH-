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
    }
}