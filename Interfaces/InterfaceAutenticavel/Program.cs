using System;
using InterfaceAutenticavel.models;

Gerente g = new Gerente();
g.Senha = 100;
g.Autenticar(101);

Diretor d = new Diretor();
d.Senha = 200;

IAutenticavel id = d;

Console.WriteLine($"Autenticou? {id.Autenticar(200)}");

Cliente c = new Cliente();
c.Senha = 300;

IAutenticavel ic = c;

Console.WriteLine($"Autenticou? {ic.Autenticar(300)}");