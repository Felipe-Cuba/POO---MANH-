using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public int Telefone { get; set; }
        public Endereco Address { get; set; }
    }
}