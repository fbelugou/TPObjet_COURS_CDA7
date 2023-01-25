using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Compte
{
    /// <summary>
    /// Représente un compte d'épargner
    /// </summary>
    internal class CompteEpargne : Compte
    {
        /// <summary>
        /// Taux d'intérêts du compte épargner
        /// </summary>
        public static decimal TauxInteret {get; private set; } = 6;

        /// <summary>
        /// Constructeur
        /// </summary>
        public CompteEpargne(): base() {}

        /// <summary>
        /// Constructeur avec le solde
        /// </summary>
        /// <param name="solde">Solde initial du compte</param>
        public CompteEpargne(decimal solde): base(solde) {}


        /// <summary>
        /// Permet de calculer les intérêts et de les verser au compte
        /// </summary>
        public void CalculInteret()
        {
            Solde = Solde * (1 + TauxInteret/100);
        }

    }
}
