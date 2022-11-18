using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Funcionario
    {
        private int senha;

        public int Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

    }
}