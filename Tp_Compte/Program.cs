// See https://aka.ms/new-console-template for more information
using Tp_Compte;


Client c = new Client(45879, "David", "John", "08 44 77 55 66");

Compte compte1 = new Compte(c);
Compte compte2 = new Compte(c);

compte1.Crediter(100);

compte2.Crediter(20, compte1);

compte1.Afficher();
compte2.Afficher();


compte1.Debit(20);
compte1.Afficher();


compte1.Debit(20, compte2);
compte1.Afficher();
compte2.Afficher();