using System.ComponentModel;
using System.ComponentModel.Design;

namespace OO_them_ALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            menu();
            static void menu()
            {
                string numeroCart;
                string pinCart;
                bool valueOkNumCarte;
                bool valueOkPIN;
                int pinCartValid = 0;
                bool valid = true;
                valueOkNumCarte = false;
                valueOkPIN = false;

                Console.Clear();
                Console.WriteLine("\t══════════ BANCOMAT D' RS7 ══════════\n");
                Console.WriteLine("\t══════════ MENU PRINCIPAL ══════════\n");
                Console.Write("Numéro de carte (ex: 0212 XXXX XXXX XXXX) :  ");
                numeroCart = Console.ReadLine();

                while (valueOkNumCarte == false) 
                {   
                    
                    
                    if (long.TryParse(numeroCart, out long numeroCartValid))
                    {
                        Console.Write("\nCode PIN (ex: 11 XX XX) : ");
                        pinCart = Console.ReadLine();
                        while (valueOkPIN == false)
                        {
                            if (int.TryParse(pinCart, out pinCartValid))
                            {
                                Console.WriteLine("1");
                                Console.WriteLine("2");
                                Console.WriteLine("3");
                                valueOkPIN=true;
                            }
                            else 
                            {
                                Console.Write("Votre numero de carte n'est pas correcte ! Merci de réessayer : ");
                                valueOkPIN=false;
                                pinCart = Console.ReadLine();
                            }
                        }
                        
                        valueOkNumCarte = true;
                    }
                    else 
                    {
                        Console.Write("Votre numero de carte n'est pas correcte ! Merci de réessayer : ");
                        numeroCart = Console.ReadLine() ;
                        valueOkNumCarte= false;
                    }

                }
                
                
                
                    
                    

                



            }

        }
    }
}
