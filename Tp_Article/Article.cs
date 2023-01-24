using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Article
{
    internal class Article
    {
        public static float TauxTVA { get; private set; } = 20;

        public string Designation { get; private set; }
        public string Reference { get; private set; }
        public float PrixHT { get; private set; }

        public Article()
        {
            Designation = "Par defaut";
            Reference = "N/A";
            PrixHT = 0;
        }

        public Article(string designation, string reference)
            : this()
        {
            Designation = designation;
            Reference = reference;
            PrixHT = 0;

        }

        public Article(string designation, string reference, float prixHT)
            : this(designation, reference)
        {
            PrixHT = prixHT;

        }

        public Article(Article other)
            : this(other.Designation, other.Reference, other.PrixHT)
        {

        }


        public float PrixTTC()
        {
            return PrixHT * (1 + (TauxTVA / 100));
        }


        public void AfficherArticle()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $@"Référence : {Reference}
Designation : {Designation}
PrixHT : {PrixHT} euros
PrixTTC : {PrixTTC()} euros
TauxTVA : {TauxTVA}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Article article &&
                   Designation == article.Designation &&
                   Reference == article.Reference;
        }
    }

}
