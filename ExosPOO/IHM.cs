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
        public static (int menu, char type) Start()
        {
            Console.WriteLine("=== Gestion des employés ===\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Ajouter un employé");
                Console.WriteLine("2. Afficher le salaire des employés");
                Console.WriteLine("3. Rechercher un employé");
                Console.WriteLine("0. Quitter\n");
                Console.ResetColor();

                Console.Write("Entrez votre choix : ");
                string userChoice = Console.ReadLine()!;
                int intChoixMenu;
                while (!int.TryParse(userChoice, out intChoixMenu) && intChoixMenu < 0 || intChoixMenu > 3)
                    Console.Write("Saisie invalide ! Réésayer : ");

                Console.WriteLine("Voulez-vous ajouter un salarié ? Ou plus précisement un commercial ? S ou C ?");
                userChoice = Console.ReadLine()!;
                char chrChoixType;
                while (!char.TryParse(userChoice, out chrChoixType) && chrChoixType != 'S' && chrChoixType != 'C')
                    Console.Write("Saisie invalide ! Réésayer : ");

                return (intChoixMenu, chrChoixType);
            }
        }

        public static (string nom, string service, string categorie, decimal salaire) FillEmploye()
        {
            Console.Write("Veuillez saisir le nom : ");
            string strNom = Console.ReadLine()!;

            Console.Write("Veuillez saisir le service : ");
            string strService = Console.ReadLine()!;

            Console.Write("Veuillez saisir la catégorie : ");
            string strCategorie = Console.ReadLine()!;

            Console.Write("Veuillez saisir le salaire : ");
            decimal dcmSalaire;
            if (!decimal.TryParse(Console.ReadLine(), out dcmSalaire)) dcmSalaire = 0;

            return (strNom, strService, strCategorie, dcmSalaire);  
        }
    }
}
