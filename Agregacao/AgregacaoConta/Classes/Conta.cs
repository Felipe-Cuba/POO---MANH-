using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta.Classes
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Tiular { get; set; }
    }
}