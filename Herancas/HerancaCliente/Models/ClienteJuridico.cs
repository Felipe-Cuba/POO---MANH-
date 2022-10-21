using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente.Models
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;

        public int CNPJ
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }

        public ClienteJuridico(int c, string e, string n, int cn): base(c, e, n) {
            CNPJ = cn;
        }

        public void Show() {
            base.MostrarAtributos();
            Console.Write($"\tCNPJ: {CNPJ}\n");
        }
    }
}