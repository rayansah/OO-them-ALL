

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
            Console.Write("Numéro de carte (ex: 0212XXXXXXXXXXXX) :  ");
            cardNumber = Console.ReadLine();

            // Loop until the card number is correct
            while (valueOkNumCarte == false)
            {


                if (long.TryParse(cardNumber, out long numeroCartValid))
                {
                    if (cardNumber.Length == cardNumberLength)
                    {
                        // Ask for the PIN code
                        Console.Write("\nCode PIN (ex: 11XXXX) : ");
                        pinCode = Console.ReadLine();

                        // Loop until the PIN is correct
                        while (valueOkPIN == false)
                        {
                            if (int.TryParse(pinCode, out validPin))
                            {
                                if (pinCode.Length == PinLength)
                                {
                                    // Go to the menu if authentication is successful
                                    Menu.menuOption();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                                    Console.ResetColor();
                                    valueOkPIN = false;
                                    pinCode = Console.ReadLine();
                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Votre PIN n'est pas correcte ! Merci de réessayer : ");
                                Console.ResetColor();
                                valueOkPIN = false;
                                pinCode = Console.ReadLine();
                            }

                        }
                        valueOkNumCarte = true;
                    }
                    else
                    {
                        // Card number length error
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                        Console.ResetColor();
                        cardNumber = Console.ReadLine();
                        valueOkNumCarte = false;
                    }

                }
                else
                {
                    // Card number format error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Votre numero de carte n'est pas correcte ! Merci de réessayer : ");
                    Console.ResetColor();
                    cardNumber = Console.ReadLine();
                    valueOkNumCarte = false;
                }
            }
        }


       
        public static void VerifyCode()
        {
            Console.Clear();

            // Show entered information
            Console.WriteLine($"Votre numéro de compte : {cardNumber}");
            Console.WriteLine($"Votre PIN : {pinCode}");
            Console.WriteLine("\n\nRetour en arrière, Appuyez sur Enter");
            Console.ReadLine();
        }
    }
}
