using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Banque.Comptes
{
    /// <summary>
    /// Représente un compte épargne 
    /// </summary>
    internal class CompteEpargne : Compte
    {
        /// <summary>
        /// Taux d'intéret du compte
        /// </summary>
        public double TauxInteret { get; private set; }

        /// <summary>
        /// Interêts cumulés
        /// </summary>
        public double InteretsCumules { get; private set; }

        /// <summary>
        /// Solde minimal dans le compté
        /// </summary>
        private readonly double _soldeMinimal = 150;

        /// <summary>
        /// Constructeur de compte d'épargne 
        /// </summary>
        /// <param name="titulaire">Titulaire du compte</param>
        public CompteEpargne(Client titulaire) : base(titulaire)
        {
            Solde = 150;
            TauxInteret = 0.75;
            InteretsCumules = 0;
        }

        /// <summary>
        /// Permet de calculer les intérêt du compte
        /// </summary>
        /// <returns>Renvoie les intéret par rapport au montant et au taux</returns>
        public double CalculerInterets()
        {
            return Solde * TauxInteret;
        }

        /// <summary>
        /// Permet de verer les intêrets sur le compte
        /// </summary>
        public void VerserInterets()
        {

            double interetCourant = CalculerInterets();
            InteretsCumules += interetCourant;
            Solde += interetCourant;
        }

        /// <summary>
        /// Permet de retirer de l'argent du compte
        /// </summary>
        /// <param name="somme">Somme à retirer</param>
        /// <returns>renvoie si l'opération à réussi</returns>
        public override bool Debit(double somme)
        {
            if (Solde - somme >= _soldeMinimal)
            {
                return base.Debit(somme);
            }
            return false;
        }

        public override string? ToString()
        {
            return base.ToString() + "\n" +
                $"TauxInteret : {TauxInteret} \n" +
                $"Interets : {CalculerInterets()}";
        }
    }
}
