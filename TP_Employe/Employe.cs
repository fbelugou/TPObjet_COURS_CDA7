using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    /// <summary>
    /// Représente un employé
    /// </summary>
    internal class Employe
    {

        /// <summary>
        /// Identifiant unique de l'employé
        /// </summary>
        public string Matricule { get; private set; }

        /// <summary>
        /// Nom de l'employé
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Prénom de l'employé
        /// </summary>
        public string Prenom { get; private set; }

        /// <summary>
        /// Date de naissance de l'employé
        /// </summary>
        public DateTime DateDeNaissance { get; private set; }

        /// <summary>
        /// Date d'embauche de l'employé
        /// </summary>
        public DateTime DateDembauche { get; private set; }

        /// <summary>
        /// Salaire de l'employé
        /// </summary>
        public float Salaire { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
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

        /// <summary>
        /// Age de l'employé
        /// </summary>
        /// <returns></returns>
        public int Age()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Now - DateDeNaissance;
            return (zeroTime + span).Year - 1;
        }

        /// <summary>
        /// Permet de calculer l'ancienneté du salarié
        /// </summary>
        /// <returns></returns>
        public int Anciennete()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Now - DateDembauche;
            return (zeroTime + span).Year - 1;
        }

        /// <summary>
        /// Augementation du salaire en fonction de l'anciieneté
        /// </summary>
        /// <returns>Retourne l'augmentation de salaire</returns>
        public float AugmentationDuSalaire()
        {
            float augmentation = 0f;
            switch (Anciennete())
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
Nom Complet : {Nom.ToUpper()} {Prenom.Substring(0, 1).ToUpper()} {Prenom.Substring(1)}
Age : {Age()} ans
Ancienneté : {Anciennete()} ans
Salaire : {Salaire + AugmentationDuSalaire()} euros";
        }

        /// <summary>
        /// Permet d'afficher les informations d'un employé
        /// </summary>
        public void AfficherEmploye()
        {
            Console.WriteLine(this);
        }
    }
}
