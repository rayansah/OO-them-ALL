/// ETML
/// Auteur : Rayan Sahbani
/// Date : 23.02.2026
///Description : projet Bancomat
namespace OO_them_ALL
{
    class Menu
    {
        private AuthentificationManager _manager;
        private TransactionProcessor _processor;
        private bool returnToMenu = true;
        private string choix;
        private string[] options = { "Vérifier Code", "Retirer", "Consulter Solde", "Imprimer reçu", "Fermer la session" };

        public Menu(TransactionProcessor processor, AuthentificationManager manager)
        {
            _processor = processor;
            _manager = manager;
        }

        public void menuOption()
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
                _manager.ValueOkPIN = true;
                choix = Console.ReadLine();

                // Execute action based on user choice
                switch (choix)
                {
                    case "1":
                        _manager.VerifyCode();
                        break;
                    case "2":
                        _processor.withDraw();
                        break;
                    case "3":
                        _processor.checkBalance();
                        break;
                    case "4":
                        _processor.receipt(this._manager);
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
