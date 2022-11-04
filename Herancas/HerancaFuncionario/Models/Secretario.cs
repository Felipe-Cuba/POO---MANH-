using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HerancaFuncionario.Models
{
    public class Secretario : Funcionario
    {
        public Secretario(double sal) : base(sal) { }
        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao();
        }
    }
}