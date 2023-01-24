using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Batiment
{
    internal class Maison : Batiment
    {
        public int NbPieces { get; private set; }

        public Maison()
        {
            
        }

        public Maison(string adresseDelaMaison, int nbPieces)
            : base(adresseDelaMaison)
        {
            NbPieces = nbPieces;
        }

        public override string? ToString()
        {
            return base.ToString() + $" est une maison de {NbPieces} pièces.";
        }
    }
}
