using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda.models
{
    public class Comprador
    {
        private double verba;

        public double Verba
        {
            get { return verba; }
            set { verba = value; }
        }

        public Comprador(double verb)
        {
            this.Verba = verb;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Verba do comprador: {verba}\n");
        }
    }
}