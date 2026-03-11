/// ETML
/// Auteur : Rayan Sahbani
/// Date : 23.02.2026
///Description : projet Bancomat

namespace OO_them_ALL
{
    public class AuthentificationManager
    {
        protected string cardNumber="";
        private bool valueOkNumCarte;
        private int cardNumberLength = 16;
        protected string pinCode="";
        private bool valueOkPIN;
        private int validPin = 0;
        private int PinLength = 6;

        public AuthentificationManager()
        { }

        //Constructeur pour l'heritage VIP
        public AuthentificationManager(string cardNumber, string pinCode)
        {
            this.cardNumber = cardNumber;
            this.pinCode = pinCode;
        }
        public string CardNumber
        {
            get { return  cardNumber; } 
        }

        public bool ValueOkPIN
        {
            get { return valueOkPIN; }
            set { valueOkPIN = value; }
        }
        
        public void checkCard(Menu menu)
        {
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
                                    if(cardNumber == "7777777777777777")
                                    {
                                        menu.Processor = new TransactionVIP();
                                    }
                                    else
                                    {
                                        menu.Processor= new ClassicTransaction();
                                    }
                                    menu.menuOption();
                                    
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


       
        public void VerifyCode()
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
