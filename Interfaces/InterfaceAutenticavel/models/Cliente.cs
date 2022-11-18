using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Cliente : IAutenticavel
    {
        private int senha;

        public int Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public bool Autenticar(int senha)
        {
            if (this.Senha == senha)
            {
                Console.WriteLine("Cliente Autenticado");
                return true;
            }

            return false;
        }
    }
}