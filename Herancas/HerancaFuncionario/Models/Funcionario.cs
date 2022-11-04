using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario.Models
{
    public class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(double sal)
        {
            Salario = sal;
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 0.10;
        }
    }
}