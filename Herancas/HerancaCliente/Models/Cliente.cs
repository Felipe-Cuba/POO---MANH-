using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente.Models
{
    public class Cliente
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

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

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Cliente(int c, string e, string n) {
            Codigo = c;
            Endereco = e;
            Nome = n;
        }

        public void MostrarAtributos()
        {
            Console.Write($"Codigo: {Codigo}\tNome: {Nome}\t Endereco: {Endereco}");
        }
    }
}