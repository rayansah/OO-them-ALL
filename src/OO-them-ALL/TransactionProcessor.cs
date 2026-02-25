/// ETML
/// Auteur : Rayan Sahbani
/// Date : 23.02.2026
///Description : projet Bancomat
namespace OO_them_ALL
{
    class TransactionProcessor
    {

        private int cash = 1000;
        private string withDrawCash;
        private bool valueOkDraw;
        private int withDrawBalance = 0;
        private int[] tabDraw = Array.Empty<int>();
        private int size = 1;
        private int index = 0;

        
        

        public void withDraw()
        {
            Console.Clear();
            // Display withdrawal menu
            Console.WriteLine("\t=========Retirer de l'argent==========\n");
            Console.WriteLine($"Votre richesse s'éléve à : {cash}");
            Console.Write("Veuillez choisir le montant à retirer : ");
            withDrawCash = Console.ReadLine();
            while (valueOkDraw == false)
            {
                
                if (int.TryParse(withDrawCash, out withDrawBalance))
                {
                    // Check if the balance is sufficient
                    if (withDrawBalance > cash)
                    {
                        while (withDrawBalance > cash)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Votre solde n'ai pas suffisant pour retirer ce montant");
                            Console.ResetColor();
                            Console.Write("Veuillez choisir le montant à retirer : ");
                            withDrawBalance = Convert.ToInt32(Console.ReadLine());
                         
                        }

                    }
                    // Update the account balance
                    cash -= withDrawBalance;
                    
                    Array.Resize(ref tabDraw, size);
                    tabDraw[index] = withDrawBalance;
                    index++;
                    size++;
                        
                    
                    valueOkDraw = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Entrée invalide ! Veuillez entrer un nombre : ");
                    Console.ResetColor();
                    withDrawCash = Console.ReadLine();
                }

            }
            valueOkDraw = false;

        }
        public void checkBalance()
        {
            Console.Clear();
            // Show balance information
            Console.WriteLine("\t========= Consultation de votre solde ==========\n");
            Console.WriteLine($"  Votre richesse s'éléve à : {cash}\n");
            Console.WriteLine("Retour en arrière, Appuyez sur Enter");
            Console.ReadLine();
        }

        public void receipt(AuthentificationManager manager)
        {
            Console.Clear();
            // Print receipt header
            Console.WriteLine("┌────────────────────────────────────────┐");
            Console.WriteLine("│\tReçu de Banque RS7");
            Console.WriteLine("");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Date       : {DateTime.Now:dd/MM/yyyy HH:mm}");
            Console.WriteLine();
            Console.WriteLine("├────────────────────────────────────────┤");
            // Show operation type
            if (withDrawBalance != 0)
            {
                Console.WriteLine($"│ Opération  : Retrait");
            }
            else
            {
                Console.WriteLine($"│ Opération  : Aucune");
            }
            // Print account and transaction details
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Compte     : {manager.CardNumber}");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Montant    :                           ");
            for (index = 0; index < tabDraw.Length; index++)
            {
                Console.WriteLine($"│               -{tabDraw[index]} fr              ");
            }
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Solde dispo: {cash} CHF              ");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine("│  validée avec succès        ");
            Console.WriteLine("│ Merci de votre confiance    Banque RS7                 ");
            Console.WriteLine("└────────────────────────────────────────┘");
            Console.ReadLine();
        }
    }
}
