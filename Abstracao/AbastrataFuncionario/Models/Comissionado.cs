using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbastrataFuncionario.Models
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }

        public override double CalcularSalario(int diasUteis)
        {
            double percent = Porcentagem / 100;
            return Salario / 30 * diasUteis * percent + Salario;
        }

        public Comissionado(int c, string n, double s, double p) : base(c, n, s)
        {
            Porcentagem = p;
        }
    }
}