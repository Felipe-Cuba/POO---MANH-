using System;
using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(10);
c2.MostrarAtributos();

Conta c3 = new Conta(15, "Ana");
c3.MostrarAtributos();

Conta c4 = new Conta(16, "Mario",1503);
c4.MostrarAtributos();