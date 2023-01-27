using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Heritage_Batiment
{
    /// <summary>
    /// Représente un batiment
    /// </summary>
    internal class Batiment
    {
        //Adresse du batiment
        public string Adresse { get; private set; }
       
        /// <summary>
        /// Constructeur
        /// </summary>
        public Batiment() { }

        /// <summary>
        /// Constructeur avec adresse
        /// </summary>
        /// <param name="adresse">Adresse du batiment</param>
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
