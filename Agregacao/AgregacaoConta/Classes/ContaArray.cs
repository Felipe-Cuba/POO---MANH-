using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta.Classes
{
    public class ContaArray
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public List<Cliente> VetorTitular { get; set; }
        
    }
}