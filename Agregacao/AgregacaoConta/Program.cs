using System;
using AgregacaoConta.Classes;

/*Uma forma de realizar a agregação

Endereco address1 = new Endereco();

address1.Logradouro = "Rua Terezinha";
address1.Cidade = "Presidente Prudente";
address1.Cep = "19100";
address1.Bairro = "Centro";
address1.Numero = 1002;

Cliente cliente_1 = new Cliente();

cliente_1.Nome = "Ana";
cliente_1.Cpf = 123;
cliente_1.Rg = 12;
cliente_1.Telefone = 189;
cliente_1.Address = address1;

Conta conta_1 = new Conta();

conta_1.Numero = 1548;
conta_1.Saldo = 6000;
conta_1.Tiular = cliente;

// Outra forma de realizar a agregação

Conta conta_2 = new Conta();

conta_2.Numero = 1296;
conta_2.Saldo = 5699;
conta_2.Tiular = new Cliente();
conta_2.Tiular.Nome = "Felipe 😊";
conta_2.Tiular.Cpf = 49086054838;
conta_2.Tiular.Rg = 13;
conta_2.Tiular.Telefone = 18981793652;

conta_2.Tiular.Address.Logradouro = "Rua Antonio Cabrioti";
conta_2.Tiular.Address.Bairro = "JD Jequitibás II";
conta_2.Tiular.Address.Cidade = "Presidente Prudente";
conta_2.Tiular.Address.Cep = "19067760";
conta_2.Tiular.Address.Numero = 100;

*/

ContaArray contavetor = new ContaArray();
contavetor.Numero = 3;
contavetor.Saldo = 10000;
contavetor.VetorTitular = new List<Cliente>();

Cliente cli1 = new Cliente();
Cliente cli2 = new Cliente();
cli1.Cpf = 4000;
contavetor.VetorTitular.Add(cli1);
contavetor.VetorTitular.Add(cli2);

foreach(Cliente t in contavetor.VetorTitular){
    Console.WriteLine($"Numero do CPF: {t.Cpf}");
}


