using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario.Models
{
    public class Mensalista : Funcionario
    {

        public int qtdeHorasTrabalhadas { get; set; }

        public Mensalista(int q, double sal) : base(sal)
        {
            this.qtdeHorasTrabalhadas = q;
        }

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao();
        }

    }
}