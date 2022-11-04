using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente.Models
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string nome;
        protected int idade;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Cliente(int c, string n, int i)
        {
            Codigo = c;
            Nome = n;
            Idade = i;
        }

        public virtual void MostrarAtributos()
        {
            Console.Write($"Código: {this.Codigo}\tNome: {this.Nome}\t Idade: {this.Idade}\t");
        }

        public abstract void VerificarIdade();
    }
}