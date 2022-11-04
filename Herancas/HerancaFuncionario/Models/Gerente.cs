using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario.Models
{
    public class Gerente : Funcionario
    {
        public Gerente(double sal) : base(sal) { }

        public override double CalcularBonificacao()
        {
            return Salario * 0.15;
        }
    }
}