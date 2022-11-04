using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente.Models
{
    public class ClienteFisico : Cliente
    {
        public int RG { get; set; }

        public ClienteFisico(int c, string n, int i, int rg) : base(c, n, i)
        {
            RG = rg;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.Write($"RG: {this.RG}\n");
        }

        public override void VerificarIdade()
        {
            if (this.Idade >= 18 && this.Idade <= 50)
            {
                Console.WriteLine("Cliente Físico");
            }
        }
    }
}