using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Gerente : Funcionario, IAutenticavel
    {

        public bool Autenticar(int senha)
        {

            if (this.Senha == senha)
            {
                Console.WriteLine("Gerente autenticado");
                return true;
            }

            return false;

        }
    }
}