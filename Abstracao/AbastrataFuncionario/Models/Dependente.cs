using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbastrataFuncionario.Models
{
    public class Dependente
    {
        private int codigo;
        private string nome;
        private int idade;

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public Dependente(int c, string n, int i)
        {
            Codigo = c;
            Nome = n;
            Idade = i;
        }

        public bool VerificarMaiorIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            }
            return false;
        }
    }
}