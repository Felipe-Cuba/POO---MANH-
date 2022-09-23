using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta // Nossa pasta
{
    public class Conta
    {

       //Delcaração de atributos

        public int numero;
        public string titular;
        public double saldo;

       //Delcaração dos metódos 
        
        public void Sacar(double valorSaque){

            saldo -= valorSaque;

        }

        public void Depositar(double valorDeposito){
            saldo += valorDeposito;
        }

        public void Transferir(double valorTransferir, Conta objConta){
            //Passagem de parametro por valor usa valorTrasnferir
            //Passagem de valor por refêrencia usa objConta
            saldo -= valorTransferir; //Objeto atual
            objConta.saldo += valorTransferir; //Objeto a tranferir
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Nome do titular: {titular}\t  Numero da conta: {numero}\t   Saldo da conta: {saldo:c}");
        }
        
    }
}