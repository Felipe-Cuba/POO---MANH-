using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco.models
{
    public class Banco
    {
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;

        public Banco(List<Poupanca> p, List<ContaCorrente> c) {
            poups = p;
            contas = c;
        }

    }
}