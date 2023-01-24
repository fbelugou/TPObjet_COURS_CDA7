using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_HeritageVecteur
{
    internal class Vecteur2D
    {
        /// <summary>
        /// Point sur l'Abscisse (X)
        /// </summary>
        public float Abscisse { get; private set; }

        /// <summary>
        /// Point sur l'Ordonne (Y)
        /// </summary>
        public float Ordonne { get; private set; }

        public Vecteur2D()
        {
            
        }


        /// <summary>
        /// Constructeur d'un point
        /// </summary>
        /// <param name="abscisse">Point sur l'Abscisse</param>
        /// <param name="ordonne">Point sur l'Ordonne</param>
        public Vecteur2D(float abscisse, float ordonne) : this()
        {
            Abscisse = abscisse;
            Ordonne = ordonne;

        }

        public Vecteur2D(Vecteur2D otherVecteur2D) 
            :this(otherVecteur2D.Abscisse, otherVecteur2D.Ordonne)
        {
            
        }

        /// <summary>
        /// Calculer la Norme du vecteur {(0,0), (abscisse, ordonnee)}
        /// </summary>
        /// <returns>Retourne la norme</returns>
        public virtual double Norme()
        {
            //Sqrt(x^2 + y^2)
            return Math.Sqrt(Math.Pow(Abscisse, 2) + Math.Pow(Ordonne, 2));
        }

        public override string? ToString()
        {
            return $"X = {Abscisse} - Y = {Ordonne}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Vecteur2D d &&
                   Abscisse == d.Abscisse &&
                   Ordonne == d.Ordonne;
        }
    }
}
