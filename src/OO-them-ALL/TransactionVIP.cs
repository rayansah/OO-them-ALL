using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OO_them_ALL
{
    public class TransactionVIP : ClassicTransaction
    {
        public TransactionVIP()
          { }
        

        public override void withDraw()
        {
            Console.Clear();
            // Display withdrawal menu
            Console.WriteLine("\t=========Retirer de l'argent==========                      VIP\n");
            Console.WriteLine($"Votre richesse s'éléve à : {cash}");
            Console.Write("Veuillez choisir le montant à retirer : ");
            withDrawCash = Console.ReadLine();

            if (int.TryParse(withDrawCash, out withDrawBalance))
            {

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
    }
}

