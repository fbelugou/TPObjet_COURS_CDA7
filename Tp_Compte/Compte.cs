using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Compte
{
    internal class Compte
    {
        private static int CompteurDeCompte { get; set; } = 0;
        public static int AfficherNombreDeCompte()
        {
            return CompteurDeCompte;
        }

        public Guid Code { get; private set; }
        
        public decimal Solde { get; private set; }

        public Client Proprietaire  { get; private set; }

        public Compte(Client proprietaire)
        {
            CompteurDeCompte ++;
            Proprietaire = proprietaire;
            Solde = 0;
            Code = Guid.NewGuid();
        }

        public bool Crediter(decimal somme)
        {
            Solde += somme;
            return true;
        }

        public bool Crediter(decimal somme, Compte otherCompte)
        {
            if(otherCompte.Debit(somme))
            {
                Crediter(somme);
                return true;
            }

            return false;
        }

        public bool Debit(decimal somme)
        {
            if(Solde >= somme)
            {
                Solde -= somme;
                return true;
            }

            return false;
        }

        public bool Debit(decimal somme, Compte otherCompte)
        {
            if(Debit(somme))
            {
                otherCompte.Crediter(somme);
                return true;
            }

            return false;
        }

        public override string? ToString()
        {
            return $@"Identifiant du compte : {Code}
Solde: {Solde} euros
Propriétaire du compte: 
{Proprietaire}";
        }

        public void Afficher()
        {
            Console.WriteLine(this);
        }
    }
}
