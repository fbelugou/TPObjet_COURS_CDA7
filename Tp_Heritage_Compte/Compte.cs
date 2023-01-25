using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Compte
{
    internal class Compte
    {
        private static int CodeCompteur = 1;


        public int Code { get; private set; }
        
        public decimal Solde { get; protected set; }

        public decimal CoutOperation { get; protected set; }

        public Compte()
        {
            Code = CodeCompteur;
            Solde = 0;
            CoutOperation = 0;
            
            CodeCompteur += 1;
        }

        public Compte(decimal solde)
            : this()
        {
            Solde = solde;
        }


        public virtual bool Debiter(decimal somme)
        {
            Solde -= somme + CoutOperation;
            return true;
        }

        public virtual bool Crediter(decimal somme)
        {
             Solde += somme - CoutOperation;
            return true;
        }
    }
}
