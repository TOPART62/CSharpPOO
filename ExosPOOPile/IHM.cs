using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOPile
{
    internal class IHM
    {
        public static int StartMenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Menu principal ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t1. Empiler");
                Console.WriteLine("\t2. Dépiler");
                Console.WriteLine("\t3. Récupérer à X");
                Console.WriteLine("\t0. Quitter\n");
                Console.ResetColor();

                Console.Write("\nEntrez votre choix : ");
                string userChoice = Console.ReadLine()!;
                Console.WriteLine("  ");
                int intChoixMenu;
                while (!int.TryParse(userChoice, out intChoixMenu) && intChoixMenu < 0 || intChoixMenu > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    userChoice = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return (intChoixMenu);
            }
        }
    }
}
