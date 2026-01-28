using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

namespace OO_them_ALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = {"Vérifier Code", "Retirer", "Consulter Solde", "Imprimer reçu", "Fermer la session" };
            int[] tabRetirer = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int argent = 100;
            string numeroCart;
            string pinCart;
            bool valueOkNumCarte;
            bool valueOkPIN;
            int pinCartValid = 0;
            bool valid = true;
            valueOkNumCarte = false;
            valueOkPIN = false;
            int retrait = 0;
            string choix;
            bool retour = true;
            int NumCorrect = 16;
            int PinCorrect = 6;
            menu();
            void menu()
            {
               

                Console.Clear();
                Console.WriteLine("\t══════════ BIENVENUE CHEZ RS7 ══════════\n");
                Console.WriteLine("\t══════════ MENU PRINCIPAL ══════════\n");
                Console.Write("Numéro de carte (ex: 0212XXXXXXXXXXXX) :  ");
                numeroCart = Console.ReadLine();

                while (valueOkNumCarte == false) 
                {   
                    
                    
                    if (long.TryParse(numeroCart, out long numeroCartValid))
                    {
                        if (numeroCart.Length == NumCorrect)
                        {
                            Console.Write("\nCode PIN (ex: 11XXXX) : ");
                            pinCart = Console.ReadLine();
                            while (valueOkPIN == false)
                            {
                                if (int.TryParse(pinCart, out pinCartValid))
                                {
                                    if (pinCart.Length == PinCorrect)
                                    {
                                        compte();
                                    }
                                    else
                                    {
                                        Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                                        valueOkPIN = false;
                                        pinCart = Console.ReadLine();
                                    }
                                    
                                }
                                else
                                {
                                    Console.Write("Votre PIN n'est pas correcte ! Merci de réessayer : ");
                                    valueOkPIN = false;
                                    pinCart = Console.ReadLine();
                                }
                                
                            }
                            valueOkNumCarte = true;
                        }
                        else
                        {
                            Console.Write("Votre numero de carte ne comporte pas le bon nombre de chiffres, réessayer : ");
                            numeroCart = Console.ReadLine();
                            valueOkNumCarte = false;
                        }
                        
                    }
                    else 
                    {
                        Console.Write("Votre numero de carte n'est pas correcte ! Merci de réessayer : ");
                        numeroCart = Console.ReadLine() ;
                        valueOkNumCarte= false;
                    }

                }
                void compte()
                {
                    while (retour)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t========Votre Compte========\n");
                        for (int i = 0; i < options.Length; i++)
                        {
                            Console.WriteLine( i+1 + ") " + options[i]);
                        }
                        Console.Write("\n\t Votre choix : ");
                        valueOkPIN = true;
                        choix = Console.ReadLine();

                        switch (choix)
                        {
                            case "1":
                                VerifierCode();
                                break;
                            case "2":
                                retirer();
                                break;
                            case "3":
                                ConsulterSolde();
                                break;
                            case "4":
                                recu();
                                break;
                            case "5":
                                retour = false;
                                Console.Clear();
                                Console.WriteLine("Fermeture de la session");
                                Console.WriteLine("Appuyez sur une touche");
                                break;
                            default:
                                break;
                        }
                    }
                    
                }
                void VerifierCode()
                {
                    Console.Clear ();
                    Console.WriteLine($"Votre numéro de compte : {numeroCart}");
                    Console.WriteLine($"Votre PIN : {pinCart}");
                    Console.WriteLine("\n\nRetour en arrière, Appuyez sur Enter");
                    Console.ReadLine();
                }
                void retirer()
                {
                    Console.Clear();
                    Console.WriteLine("\t=========Retirer de l'argent==========\n");
                    Console.WriteLine($"Votre richesse s'éléve à : {argent}");
                    Console.Write("Veuillez choisir le montant à retirer : ");
                    retrait = Convert.ToInt32 (Console.ReadLine());
                    if (retrait > argent)
                    {
                        while(retrait > argent)
                        {
                            Console.WriteLine("Votre solde n'ai pas suffisant pour retirer ce montant");
                            Console.Write("Veuillez choisir le montant à retirer : ");
                            retrait = Convert.ToInt32(Console.ReadLine());
                        }
                       
                    }
                    argent -= retrait;
                
                }
                void ConsulterSolde()
                {
                    Console.Clear();
                    Console.WriteLine("\t========= Consultation de votre solde ==========\n");
                    Console.WriteLine($"  Votre richesse s'éléve à : {argent}\n");
                    Console.WriteLine("Retour en arrière, Appuyez sur Enter");
                    Console.ReadLine();
                }
                void recu()
                {
                    Console.Clear();
                    Console.WriteLine("┌────────────────────────────────────────┐");
                    Console.WriteLine("│\tReçu de Banque RS7");
                    Console.WriteLine("");
                    Console.WriteLine("├────────────────────────────────────────┤");
                    Console.WriteLine($"│ Date       : {DateTime.Now:dd/MM/yyyy HH:mm}");
                    Console.WriteLine();
                    Console.WriteLine("├────────────────────────────────────────┤");
                    if (retrait != 0)
                    {
                        Console.WriteLine($"│ Opération  : Retrait");
                    }
                    else
                    {
                        Console.WriteLine($"│ Opération  : Aucune");
                    }
                    Console.WriteLine("├────────────────────────────────────────┤");
                    Console.WriteLine($"│ Compte     : {numeroCart}");
                    Console.WriteLine("├────────────────────────────────────────┤");
                    Console.WriteLine($"│ Montant    : -{retrait} fr              ");
                    Console.WriteLine("├────────────────────────────────────────┤");
                    Console.WriteLine($"│ Solde dispo: {argent} fr              ");
                    Console.WriteLine("├────────────────────────────────────────┤");
                    Console.WriteLine("│  validée avec succès        ");
                    Console.WriteLine("│ Merci de votre confiance    Banque RS7                 ");
                    Console.WriteLine("└────────────────────────────────────────┘");
                    Console.ReadLine();
                }
                
                    
                    

                



            }

        }
    }
}
