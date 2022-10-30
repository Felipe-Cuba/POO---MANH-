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

        public List<Poupanca> Poups
        {
            get { return poups; }
            set { poups = value; }
        }

        public List<ContaCorrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }

        public Banco(List<Poupanca> p, List<ContaCorrente> c)
        {
            Poups = p;
            Contas = c;
        }



    }
}