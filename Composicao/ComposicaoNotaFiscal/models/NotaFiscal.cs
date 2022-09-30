using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal.models
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int num, string date, List<ItemNotaFiscal> vet)
        {
            NumeroNF = num;
            Data = date;
            VetItens = vet;
        }
        
    }
}