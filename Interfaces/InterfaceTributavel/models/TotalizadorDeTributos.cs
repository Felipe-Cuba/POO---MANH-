using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel.models
{
    public class TotalizadorDeTributos
    {
        public double total { get; set; }

        public void Adiciona(ITributavel t)
        {
            this.total += t.CalcularTributos();
        }
    }
}