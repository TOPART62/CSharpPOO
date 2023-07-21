using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class IHM
    {
        public static int StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Menu principal ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t1. Lister les comptes bancaires");
                Console.WriteLine("\t2. Créer un compte bancaire");
                Console.WriteLine("\t3. Effectuer un depot");
                Console.WriteLine("\t4. Effectuer un retrait");
                Console.WriteLine("\t5. Afficher les operations et le solde");
                Console.WriteLine("\t0. Quitter le programme\n");
                Console.ResetColor();

                Console.Write("\nEntrez votre choix : ");
                string userChoice = Console.ReadLine()!;
                Console.WriteLine("  ");
                int intChoixMenu;
                while (!int.TryParse(userChoice, out intChoixMenu) && intChoixMenu < 0 || intChoixMenu > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    userChoice = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return (intChoixMenu);
            }
        }
        public static int StartCreationCompte()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t1. Créer un compte courant");
                Console.WriteLine("\t\t\t2. Créer un compte épargne");
                Console.WriteLine("\t\t\t3. Créer un compte payant");
                Console.WriteLine("\t\t\t0. Annuler la création de compte\n");
                Console.ResetColor();

                Console.Write("\nEntrez votre choix : ");
                string userChoice = Console.ReadLine()!;
                Console.WriteLine("  ");
                int intChoixMenu;
                while (!int.TryParse(userChoice, out intChoixMenu) && intChoixMenu < 0 || intChoixMenu > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    userChoice = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return (intChoixMenu);
            }
        }
        
        public static string StartRecherche()
        {
            while (true)
            {
                Console.Write("\nQuel est le nom du salarié que vous recherchez ? ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string userName = Console.ReadLine()!.ToUpper();
                Console.ResetColor();
                return userName;
            }
        }
        public static char StartCreationOperation()
        {
            while (true)
            {
                Console.Write("Voulez-vous créer des opérations ?  Y ou N ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strUserChoice = Console.ReadLine()!.ToUpper();
                Console.ResetColor();
                char chrChoixType;
                while (!char.TryParse(strUserChoice, out chrChoixType) && chrChoixType != 'Y' && chrChoixType != 'N')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strUserChoice = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return Char.ToUpper(chrChoixType);
            }
        }
    }
}
