

namespace OO_them_ALL
{
    static class Menu
    {
        public static bool returnToMenu = true;
        public static string choix;
        public static string[] options = { "Vérifier Code", "Retirer", "Consulter Solde", "Imprimer reçu", "Fermer la session" };
        public static void menuOption()
        {
            while (returnToMenu)
            {
                Console.Clear();
                Console.WriteLine("\n\t========Votre Compte========\n");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + 1 + ") " + options[i]);
                }
                Console.Write("\n\t Votre choix : ");
                AuthentificationManager.valueOkPIN = true;
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AuthentificationManager.VerifierCode();
                        break;
                    case "2":
                        TransactionProcessor.retirer();
                        break;
                    case "3":
                        TransactionProcessor.ConsulterSolde();
                        break;
                    case "4":
                        TransactionProcessor.recu();
                        break;
                    case "5":
                        returnToMenu = false;
                        Console.Clear();
                        Console.WriteLine("Fermeture de la session");
                        Console.WriteLine("Appuyez sur une touche");
                        break;
                    default:
                        break;
                }
            }


        }
        
    }
}
