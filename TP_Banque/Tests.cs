using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Banque.Comptes;

namespace TP_Banque
{
    /// <summary>
    /// Classe de tests
    /// </summary>
    internal static class Tests
    {

        public static bool ShouldBeOkWithAClientPrintHisBankAccount()
        {
            Client client = new Client("Champion", "Didier");
            Compte compte1 = new Compte(client, 100);

            client.AfficherComptes();
            return true;
        }

        public static bool ShouldBeOkWithAClientPrintTwoBankAccount()
        {
            Client client = new Client("Champion", "Didier");
            Compte compte1 = new Compte(client, 100);
            Compte compte2 = new Compte(client, 90000);
            client.AfficherComptes();
            return true;
        }
    }
}
