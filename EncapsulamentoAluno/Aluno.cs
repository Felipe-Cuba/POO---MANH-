using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {

        private int matricula;
        private string nome;
        private double p1;
        private double p2;
        private double media;
        public int Matricula
        {
            get { return matricula; }
            set 
            { 
                if (value > 0)
                {
                    matricula = value;
                }
                else
                {
                    Console.WriteLine("Matricula inválida!!!");
                }
            }
        }


        public string Nome
        {
            get { return nome; }
            set => nome = value;
        }

        public double P1
        {
            get { return p1; }
            set 
            {
                if (value >= 0 &&  value <= 10)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine("Nota da P1 inválida!!!");
                }
            }
        }

        public double P2
        {
            get { return p2; }
            set 
            {
                if (value >= 0 &&  value <= 10)
                {
                    p2 = value;
                }
                else
                {
                    Console.WriteLine("Nota da P2 inválida!!!");
                }
            }
        }

        public double Media
        {
            get 
            { 
                media = (P1 + P2) / 2; 
                return media;
            }
        }
        
        
    }
}