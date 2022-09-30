using System;
using ComposicaoNotaFiscal.models;

ItemNotaFiscal item1 = new ItemNotaFiscal(10);
ItemNotaFiscal item2 = new ItemNotaFiscal(3);
List<ItemNotaFiscal> vetItem = new List<ItemNotaFiscal>();

vetItem.Add(item1);
vetItem.Add(item2);

NotaFiscal notaFiscal = new NotaFiscal(1, "30/09/2022", vetItem);

foreach (ItemNotaFiscal it in notaFiscal.VetItens)
{
    Console.WriteLine($"Quantidade: {it.Quantidade}");
}

notaFiscal = null;
GC.Collect();