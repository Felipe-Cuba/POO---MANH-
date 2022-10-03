using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda.models
{
    public class Vendedor
    {
        private double comissao;

        public double Comissao
        {
            get { return comissao; }

            set
            {
                comissao = value;
            }
        }

        public void MostraAtributos()
        {
            Console.WriteLine($"Comissão do vendedor: {comissao:c}");
        }
    }
}