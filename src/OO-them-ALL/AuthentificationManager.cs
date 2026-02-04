

namespace OO_them_ALL
{
    static class AuthentificationManager
    {
        public static string cardNumber;
        public static bool valueOkNumCarte;
        public static int cardNumberLength = 16;
        public static string pinCode;
        public static bool valueOkPIN;
        public static int validPin = 0;
        public static int PinLength = 6;
        

        public static void checkCard()
        {
            Console.Clear();
            Console.WriteLine("\t══════════ BIENVENUE CHEZ RS7 ══════════\n");
            Console.WriteLine("\t══════════ MENU PRINCIPAL ══════════\n");
            Console.Write("Numéro de carte (ex: 0212XXXXXXXXXXXX) :  ");
            cardNumber = Console.ReadLine();
            
            while (valueOkNumCarte == false)
            {


                if (long.TryParse(cardNumber, out long numeroCartValid))
                {
                    if (cardNumber.Length == cardNumberLength)
                    {
                        Console.Write("\nCode PIN (ex: 11XXXX) : ");
                        pinCode = Console.ReadLine();
                        while (valueOkPIN == false)
                        {
                            if (int.TryParse(pinCode, out validPin))
                            {
                                if (pinCode.Length == PinLength)
                                {
                                    Menu.menuOption();
                                }
                                else
                                {
                                    Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                                    valueOkPIN = false;
                                    pinCode = Console.ReadLine();
                                }

                            }
                            else
                            {
                                Console.Write("Votre PIN n'est pas correcte ! Merci de réessayer : ");
                                valueOkPIN = false;
                                pinCode = Console.ReadLine();
                            }

                        }
                        valueOkNumCarte = true;
                    }
                    else
                    {
                        Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                        cardNumber = Console.ReadLine();
                        valueOkNumCarte = false;
                    }

                }
                else
                {
                    Console.Write("Votre numero de carte n'est pas correcte ! Merci de réessayer : ");
                    cardNumber = Console.ReadLine();
                    valueOkNumCarte = false;
                }
            }
        }


       
        public static void VerifierCode()
        {
            Console.Clear();
            Console.WriteLine($"Votre numéro de compte : {cardNumber}");
            Console.WriteLine($"Votre PIN : {pinCode}");
            Console.WriteLine("\n\nRetour en arrière, Appuyez sur Enter");
            Console.ReadLine();
        }
    }
}
