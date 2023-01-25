using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Banque.Comptes
{
    /// <summary>
    /// Représente un compte
    /// </summary>
    internal class Compte
    {
        /// <summary>
        /// Compteur d'instance de compte
        /// </summary>
        private static int _compteurDeCompte = 1;

        /// <summary>
        /// Numéro unique d'un compte
        /// </summary>
        public int NumeroDuCompte { get; private set; }

        /// <summary>
        /// Titulaire du compte
        /// </summary>
        public Client Titulaire { get; private set; }

        /// <summary>
        /// Date de création du compte
        /// </summary>
        public DateTime DateDeCreation { get; private set; }

        /// <summary>
        /// Solde courant dans le compte
        /// </summary>
        public double Solde { get; protected set; }

        /// <summary>
        /// Constructeur de la classe compte
        /// </summary>
        /// <param name="titulaire">Titulaire du compte</param>
        public Compte(Client titulaire)
        {
            NumeroDuCompte = _compteurDeCompte;
            Titulaire = titulaire;
            DateDeCreation = DateTime.Now;
            titulaire.AjouterUnCompte(this);
            _compteurDeCompte += 1;
        }

        /// <summary>
        /// Constructeur d'un compte avec son titulaire et son solde
        /// </summary>
        /// <param name="titulaire">Titulaire du compte</param>
        /// <param name="solde">Solde du compte</param>
        public Compte(Client titulaire, double solde)
            : this(titulaire)
        {
            Solde = solde;
        }

        /// <summary>
        /// PErmet de retirer de l'argent du solde
        /// </summary>
        /// <param name="somme">Somme à retirer</param>
        /// <returns>Renvoie si l'opération à réussi</returns>
        public virtual bool Debit(double somme)
        {
            Solde -= somme;
            return true;
        }

        /// <summary>
        /// Permet de mettre de l'argent sur le compte
        /// </summary>
        /// <param name="somme">Somme à rajouter au compte</param>
        /// <returns>Renvoie si l'opération à réussi</returns>
        public bool Credit(double somme)
        {
            Solde += somme;
            return true;
        }

        public override string? ToString()
        {
            return
                $"Numéro du compte: {NumeroDuCompte} créé le {DateDeCreation.ToString("dd/MM/yyyy")} \n" +
                $"Solde : {Math.Round(Solde, 2)}";
        }
    }
}
