

namespace OO_them_ALL
{
    static class Menu
    {
        public static bool returnToMenu = true;
        public static string choix;
        public static string[] options = { "Vérifier Code", "Retirer", "Consulter Solde", "Imprimer reçu", "Fermer la session" };
        public static void menuOption()
        {
            // Loop while the user stays in the menu
            while (returnToMenu)
            {
                Console.Clear();
                Console.WriteLine("\n\t========Votre Compte========\n");
                // Display menu options
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + 1 + ") " + options[i]);
                }

                // Ask the user to choose an option
                Console.Write("\n\t Votre choix : ");
                AuthentificationManager.valueOkPIN = true;
                choix = Console.ReadLine();

                // Execute action based on user choice
                switch (choix)
                {
                    case "1":
                        AuthentificationManager.VerifyCode();
                        break;
                    case "2":
                        TransactionProcessor.withDraw();
                        break;
                    case "3":
                        TransactionProcessor.checkBalance();
                        break;
                    case "4":
                        TransactionProcessor.receipt();
                        break;
                    case "5":
                        // Exit the session
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
