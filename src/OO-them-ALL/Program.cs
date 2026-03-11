/// ETML
/// Auteur : Rayan Sahbani
/// Date : 23.02.2026
///Description : projet Bancomat

using OO_them_ALL;
using System.Security.Cryptography.X509Certificates;

namespace OO_them_ALL
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {


            ClassicTransaction processor = new ClassicTransaction();
            AuthentificationManager manager = new AuthentificationManager();

        
                Menu menu = new Menu(manager);

            
            Console.Clear();

            // Display main menu and ask for card number
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"█████   █████ ███████   █████     ███   █    █ █   █");
            Console.WriteLine(@"█    █ █           █    █    █   █   █  ██   █ █  █ ");
            Console.WriteLine(@"█████   ████      █     █████   ███████ █ █  █ ███  ");
            Console.WriteLine(@"█   █       █    █      █    █  █     █ █  █ █ █  █ ");
            Console.WriteLine(@"█    █  █████   █       █████   █     █ █    █ █   █");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tWelcome to RS7 BANK\n");
            Console.ResetColor(); 
            
            manager.checkCard(menu);
        }

      

            
  
    }
}