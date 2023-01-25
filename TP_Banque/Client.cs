using TP_Banque.Comptes;

namespace TP_Banque
{
    /// <summary>
    /// Représente un client de la banque
    /// </summary>
    internal class Client
    {
        /// <summary>
        /// Nom du client
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Prenom du client
        /// </summary>
        public string Prenom { get; private set; }

        /// <summary>
        /// Liste des comptes du client
        /// </summary>
        private List<Compte> _comptes = new List<Compte>();

        /// <summary>
        /// Constructeur par défault
        /// </summary>
        public Client() { }

        /// <summary>
        /// Constructeur avec nom et prénom
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="prenom">Prénom du client</param>
        public Client(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        /// <summary>
        /// Permet d'ajouter un compte au client
        /// </summary>
        /// <param name="compte">Compte à ajouter</param>
        public void AjouterUnCompte(Compte compte)
        {
            _comptes.Add(compte);
        }

        /// <summary>
        /// Permet d'afficher le compte du client
        /// </summary>
        public void AfficherComptes()
        {
            //Technique avec boucle for

            //for(int i = 0; i < _comptes.Count; i++)
            //{
            //    Compte compte = _comptes[i];
            //    Console.WriteLine(compte);
            //}

            //Technique avec foreach
            foreach(Compte compte in _comptes)
            {
                Console.WriteLine(compte);
            }
        }
     }
}