using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionário
{
    public class Funcionario
    {
        //Declaração dos atributos

        public int codigo;
        public string nome;
        public double salario;

        //Declaração dos métodos

        public void MostrarAtributos(){
            Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"\nCódigo: {codigo}\nNome do funcionário: {nome}\nSalário do funcionário: {salario:c}\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- \n");
        }
    }
}