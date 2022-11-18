using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (this.Senha == senha)
            {
                Console.WriteLine("Diretor Autenticado");
                return true;
            }

            return false;
        }
    }
}