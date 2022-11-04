using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente.Models
{
    public class ClienteJuridico : Cliente
    {
        public int CNPJ { get; set; }

        public ClienteJuridico(int c, string n, int i, int cnpj) : base(c, n, i)
        {
            CNPJ = cnpj;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.Write($"CNPJ: {this.CNPJ}\n");
        }

        public override void VerificarIdade()
        {
            if (this.Idade > 50)
            {
                Console.WriteLine("Cliente Juridico");
            }
        }
    }
}