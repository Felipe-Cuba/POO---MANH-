using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
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
            Console.WriteLine($"------------------------- Conta de {titular}:{numero} -------------------------------");
            Console.WriteLine($"\nNome do titular: {titular}\tNumero da conta: {numero}\tSaldo da contas: {saldo:c}\n");
        }
    }
}