using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario.Models
{
    public class Horista : Funcionario
    {

        public int qtdeHorasSemana { get; set; }

        public Horista(int q, double sal) : base(sal)
        {
            this.qtdeHorasSemana = q;
        }

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao();
        }

    }
}