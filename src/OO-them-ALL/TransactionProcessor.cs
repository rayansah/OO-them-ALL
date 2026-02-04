
namespace OO_them_ALL
{
    static class TransactionProcessor
    {
        public static int cash = 100;
        public static int withDrawCash = 0;

        public static void retirer()
        {
            Console.Clear();
            Console.WriteLine("\t=========Retirer de l'argent==========\n");
            Console.WriteLine($"Votre richesse s'éléve à : {cash}");
            Console.Write("Veuillez choisir le montant à retirer : ");
            withDrawCash = Convert.ToInt32(Console.ReadLine());
            if (withDrawCash > cash)
            {
                while (withDrawCash > cash)
                {
                    Console.WriteLine("Votre solde n'ai pas suffisant pour retirer ce montant");
                    Console.Write("Veuillez choisir le montant à retirer : ");
                    withDrawCash = Convert.ToInt32(Console.ReadLine());
                }

            }
            cash -= withDrawCash;
        }
        public static void ConsulterSolde()
        {
            Console.Clear();
            Console.WriteLine("\t========= Consultation de votre solde ==========\n");
            Console.WriteLine($"  Votre richesse s'éléve à : {cash}\n");
            Console.WriteLine("Retour en arrière, Appuyez sur Enter");
            Console.ReadLine();
        }

        public static void recu()
        {
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────┐");
            Console.WriteLine("│\tReçu de Banque RS7");
            Console.WriteLine("");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Date       : {DateTime.Now:dd/MM/yyyy HH:mm}");
            Console.WriteLine();
            Console.WriteLine("├────────────────────────────────────────┤");
            if (withDrawCash != 0)
            {
                Console.WriteLine($"│ Opération  : Retrait");
            }
            else
            {
                Console.WriteLine($"│ Opération  : Aucune");
            }
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Compte     : {AuthentificationManager.cardNumber}");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine($"│ Montant    : -{withDrawCash} fr              ");
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
