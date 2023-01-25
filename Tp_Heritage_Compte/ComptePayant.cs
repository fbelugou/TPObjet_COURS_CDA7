using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Compte
{
    internal class ComptePayant : Compte
    {
        public ComptePayant(): base()
        {
            CoutOperation = 5;
        }

        public ComptePayant(decimal solde) : base(solde) 
        {
            CoutOperation = 5;
        }
    }
}
