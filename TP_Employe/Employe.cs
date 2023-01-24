using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    internal class Employe
    {

        public string Matricule { get; private set; }

        public string Nom { get; private set; }

        public string Prenom { get; private set; }

        public DateTime DateDeNaissance { get; private set; }

        public DateTime DateDembauche { get; private set; }

        public float Salaire { get; private set; }

        public Employe()
        {
            Console.WriteLine("Matricule :");
            Matricule = Console.ReadLine();
            Console.WriteLine("Nom :");
            Nom = Console.ReadLine();
            Console.WriteLine("Prénom :");
            Prenom = Console.ReadLine();

            Console.WriteLine("Date de Naissance (jj/mm/aaaa):");
            DateDeNaissance = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Date d'embauche (jj/mm/aaaa):");
            DateDembauche = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Salaire :");
            Salaire = float.Parse(Console.ReadLine());
        }


        public int Age()
        {
            //TODO: Fix with exact value
            //return DateTime.Now.Subtract(DateDeNaissance);
            return DateTime.Now.Year - DateDeNaissance.Year;
        }

        public int Anciennete()
        {
            //TODO: Fix with exact value
            return DateTime.Now.Year - DateDembauche.Year;
        }

        public float AugmentationDuSalaire()
        {
            float augmentation = 0f;
            switch(Anciennete())
            {
                case < 5: 
                    augmentation = Salaire * 0.02f;
                    break;
                case < 10:
                    augmentation = Salaire * 0.05f;
                    break;
                default: 
                    augmentation = Salaire * 0.10f;
                    break;
            }

            return augmentation;
        }

       
        public override string ToString()
        {
            return @$"Matricule: {Matricule}
Nom Complet : {Nom.ToUpper()} {Prenom.Substring(0,1).ToUpper()} {Prenom.Substring(1)}
Age : {Age()} ans
Ancienneté : {Anciennete()} ans
Salaire : {Salaire + AugmentationDuSalaire()} euros";
        }

        public void AfficherEmploye()
        {
            Console.WriteLine(this);
        }
    }
}
