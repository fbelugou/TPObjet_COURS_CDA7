using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Batiment
{
    internal class Batiment
    {
        public string Adresse { get; private set; }

        public Batiment() { }

        public Batiment(string adresse)
        {
            Adresse = adresse;
        }

        public override string? ToString()
        {
            return $"Le batiment situé à l'adresse {Adresse}";
        }
    }
}
