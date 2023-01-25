using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Banque.Comptes
{
    /// <summary>
    /// Compte courant 
    /// </summary>
    internal class CompteCourant : Compte
    {
        /// <summary>
        /// Découvert autorisé sur le compte courant
        /// </summary>
        public double DecouvertAutorise { get; private set; }
        
        /// <summary>
        /// Constructeur du compte ocurant
        /// </summary>
        /// <param name="titulaire">Titulaire du compte</param>
        public CompteCourant(Client titulaire) : base(titulaire)
        {
            DecouvertAutorise = 300;
        }

        /// <summary>
        /// Constructeur du compte courant avec titulaire et solde
        /// </summary>
        /// <param name="titulaire"></param>
        /// <param name="solde"></param>
        public CompteCourant(Client titulaire, double solde) : this(titulaire)
        {
            Solde = solde;
        }

        /// <summary>
        /// Permet de retirer de l'argent du compte
        /// </summary>
        /// <param name="somme">Somme à retirer</param>
        /// <returns>Renvoie si l'opération à réussi</returns>
        public override bool Debit(double somme)
        {
            if(Solde - somme >= DecouvertAutorise)
            {
                return base.Debit(somme);
            }
            return false;
        }

        public override string? ToString()
        {
            return base.ToString() + "\n" +
                $"Découvert autorisé : {DecouvertAutorise} euros \n";
        }
    }
}
