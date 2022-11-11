using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbastrataFuncionario.Models
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public List<Funcionario> VetF { get; set; }


        public Departamento(int c, string d)
        {
            Codigo = c;
            Descricao = d;
        }

        public void AdmitirFuncionario(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine($"-=-=-=-=-=- Funcionários: {Descricao} -=-=-=-=-=-\n");
            foreach (Funcionario f in VetF)
            {
                f.MostrarAtributos();
            }
            Console.WriteLine();
        }

        public void RemoverFuncionario(int cod)
        {
            for (int i = 0; i < VetF.Count; i += 1)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == cod)
                {
                    VetF.Remove(f);
                }
            }
        }

        public double CalcularFolhaPagamento(int diasUteis)
        {
            double folhaPagamento = 0;
            Console.WriteLine($"-=-=-=-=-=- Folha de pagamento: {Descricao} -=-=-=-=-=-\n");
            for (int i = 0; i < VetF.Count; i += 1)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folhaPagamento += f.CalcularSalario(diasUteis);
            }
            return folhaPagamento;
        }

    }
}