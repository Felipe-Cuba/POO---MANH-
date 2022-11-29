using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel.models
{
    public class SeguroDeVida : ITributavel
    {
        public double CalcularTributos()
        {
            double tributo = 75;

            return tributo;
        }
    }
}