using System;

// Console.WriteLine("Exemplo for........");
// for (int x = 0; x < 5; x++)
//     Console.WriteLine($"Valor de x: {x}");


// Console.WriteLine("Exemplo While..........\n");

// int w = 7;

// while (w < 15){
//     Console.WriteLine($"Valor de w: {w}");
//     w++;
// }


// Console.WriteLine("Exemplo DO...WHILE....\n");

// do {
//     Console.WriteLine($"Valor de w: {w}");
//     w++;
// }while(w < 20);



// Crie um programa para clacular a media de idade de algumas pessoas, apresente o resultado ao final. WHILE


int id, x = 0;
double soma = 0;
bool a;

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.Write("Deseja começar? (S/N): ");
string i = Console.ReadLine().ToUpper();



if ( i == "S"){
    a = true;
        while(a == true){


        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("\nDigite uma idade: ");
        id = Convert.ToInt32(Console.ReadLine());

        if (id > 0){
            soma += id;
            x++;
        } else {
            Console.WriteLine("\nO valor digitado é nulo ou invalido.");
            soma = 0;
            break;
        }
        

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("\nDeseja cadastrar mais alguma idade? (S/N): ");
        i = Console.ReadLine().ToUpper();

        if (i != "S"){
            a = false;
        }
    }

    if (soma != 0){
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"\nA media de idades é: {soma / x}");
    }
    
}
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");





