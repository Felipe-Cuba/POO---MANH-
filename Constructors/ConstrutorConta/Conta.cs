using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public static int Contador { get; set; }

        static Conta()
        {
            Contador = 1000;
        }

        public Conta()
        {
            Contador++;
        }

        public Conta(int numero)//Construtor Padrão
        {
            this.Numero = numero;
            Contador++;
        }

        public Conta(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
            Contador++;
        }

        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            Contador++;
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Número: {Numero}\tTitular: {Titular}\tSaldo: {Saldo:c}\n");
        }
    }
}