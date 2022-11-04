using System;
using AbstrataCliente.Models;

ClienteFisico cf = new ClienteFisico(10, "Felipe", 25, 1312309);
ClienteJuridico cj = new ClienteJuridico(12, "Cuba", 56, 465486548);
Teste teste = new Teste();

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

cf.MostrarAtributos();
cj.MostrarAtributos();

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

teste.VerificarIdadeClasses(cf);
teste.VerificarIdadeClasses(cj);