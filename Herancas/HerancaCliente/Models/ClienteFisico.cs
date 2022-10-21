using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente.Models
{
    public class ClienteFisico : Cliente
    {
        private int rg;

        public int RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico(int c, string e, string n, int r): base(c, e, n) {
            RG = r;
        }

        public void Show() {
            base.MostrarAtributos();
            Console.Write($"\tRG: {RG}\n");
        }
    }
}