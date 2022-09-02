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
        private double p1, p2, media;

        public int Matricula
        {
            get => matricula;
            set  
            {
                    matricula = value;
                    Console.WriteLine($"Success ----> Matricula inserida com sucesso!!\n");
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                Console.WriteLine($"Success ----> Nome inserido com sucesso!!\n");
            }
        }

        public double P1
        {
            get => p1;
            set
            {
                p1 = value;
                Console.WriteLine($"Success ----> Nota P1 inserida com sucesso!!\n");
            }
        }

        public double P2
        {
            get => p2;
            set
            {
                p2 = value;
                Console.WriteLine($"Success ----> Nota P2 inserida com sucesso!!\n");
            }
        }

        public double Media
        {
            get => media;
            set
            {
                media = value;
                Console.WriteLine($"Success ----> Média inserida com sucesso!!\n");
            }
        }

        public void MostrarDados(){
            Console.WriteLine($"\n------------------------------------------------------------\n");
            Console.WriteLine($"Matricula: {matricula}\nNome: {nome}\nNota P1: {p1}\tNota P2: {p2}\nMédia: {media}");
            Console.WriteLine($"\n------------------------------------------------------------\n");

        }
    }
}