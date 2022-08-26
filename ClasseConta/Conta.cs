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
        
        public void Sacar(){

        }

        public void depositar(){
            
        }

        public void MostrarAtributos(){
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=- Conta {numero} =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\nNome do titular: {titular}\nNumero da conta: {numero}\nSaldo da conta: {saldo:c}\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= \n\n\n");
        }
        
    }
}