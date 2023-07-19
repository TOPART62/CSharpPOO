using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO
{
    internal class IHM
    {
        public static int StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Gestion des employés ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t1. Ajouter un employé");
                Console.WriteLine("\t2. Afficher le salaire des employés");
                Console.WriteLine("\t3. Rechercher un employé");
                Console.WriteLine("\t0. Quitter\n");
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
        public static char StartType()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n === Gestion des employés ===\n");
            Console.ResetColor();
            while (true)
            {
                Console.Write("Voulez-vous ajouter un salarié ? Ou plus précisement un commercial ? S ou C ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strUserChoice = Console.ReadLine()!;
                Console.ResetColor();
                char chrChoixType;
                while (!char.TryParse(strUserChoice, out chrChoixType) && chrChoixType != 'S' && chrChoixType != 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strUserChoice = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return Char.ToUpper(chrChoixType);
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
    }
}
