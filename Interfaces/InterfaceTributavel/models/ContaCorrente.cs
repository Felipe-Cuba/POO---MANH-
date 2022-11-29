using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel.models
{
    public class ContaCorrente : ITributavel
    {
        public double saldo { get; set; }

        public ContaCorrente(double s)
        {
            this.saldo = s;
        }

        public double CalcularTributos()
        {
            double percent = 0.05;
            return this.saldo * percent;
        }

    }
}