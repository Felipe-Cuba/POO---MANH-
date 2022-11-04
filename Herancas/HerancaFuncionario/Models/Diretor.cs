using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario.Models
{
    public class Diretor : Funcionario
    {
        public Diretor(double sal) : base(sal) { }

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}