using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Compte
{
    internal class Client
    {
        public int CIN { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public string Tel { get; private set; }

        public Client(int cIN, string nom, string prenom)
        {
            CIN = cIN;
            Nom = nom;
            Prenom = prenom;
            Tel = string.Empty;
        }

        public Client(int cIN, string nom, string prenom, string tel)
            : this(cIN, nom, prenom)
        {
            Tel = tel;
        }

        public override string? ToString()
        {
            return $@"CIN : {CIN}
Nom : {Nom}
Prénom : {Prenom}
Tel : {Tel}";
        }

        public void Afficher()
        {
            Console.WriteLine(this);
        }
    }
}
