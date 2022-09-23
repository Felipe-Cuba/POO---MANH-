using System;
using ArrayConta;


// Declaração do vetor de contas
Conta[] vetorConta = new Conta[3];


for(int i = 0;i < vetorConta.Length; i++){
    // Instancia cada índice
    vetorConta[i] = new Conta();

    Console.WriteLine("-=-=-=-=-=-=-=-= Cadastro de conta -=-=-=-=-=-=-=-=-");
    //Cadastro do número da conta
    Console.Write("\nCadastre o número da conta: ");
    vetorConta[i].numero = Convert.ToInt32(Console.ReadLine());
    //Cadastro do titular da conta
    Console.Write("\nCadastre o titular da conta: ");
    vetorConta[i].titular = Console.ReadLine();
    //Cadastro do saldo da conta
    Console.Write("\nCadastre o saldo da conta: ");
    vetorConta[i].saldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
}

foreach (Conta c in vetorConta){
    c.MostrarAtributos();
}
