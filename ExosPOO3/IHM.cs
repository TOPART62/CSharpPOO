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
        public static (string strNomForum, int intNbAbonnesForum, int intNbNouvellesForum, char chrYN) StartForum()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Première étape : Création du forum ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.Write("Quel est le nom de ce forum ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strNomForum = Console.ReadLine()!;
                Console.ResetColor();

                Console.Write("Combien d'abonnés ce forum aura-t-il ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strNbAbonnesForum= Console.ReadLine()!;
                Console.ResetColor();
                int intNbAbonnesForum;
                while (!int.TryParse(strNbAbonnesForum, out intNbAbonnesForum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strNbAbonnesForum = Console.ReadLine()!;
                    Console.ResetColor();
                }

                Console.Write("Combien de nouvelles ce forum aura-t-il ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strNbNouvellesForum = Console.ReadLine()!;
                Console.ResetColor();
                int intNbNouvellesForum;
                while (!int.TryParse(strNbNouvellesForum, out intNbNouvellesForum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strNbNouvellesForum = Console.ReadLine()!;
                    Console.ResetColor();
                }

                Console.Write("Ce forum aura-t-il un moderateur ?  Y or N ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strYN = Console.ReadLine().ToUpper();
                Console.ResetColor();
                char chrYN;
                while (!char.TryParse(strYN, out chrYN) && (chrYN != 'Y') && (chrYN != 'N'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strYN = Console.ReadLine()!;
                    Console.ResetColor();
                }
                return (strNomForum, intNbAbonnesForum, intNbNouvellesForum, chrYN);
            }
        }
    
        public static (string strNomModerateur, string strPrenomModerateur, int intAgeModerateur) StartModerateur()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Affectation d'un moderateur au forum ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.Write("Quel est le nom du moderateur ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strNomModerateur = Console.ReadLine()!;
                Console.ResetColor();

                Console.Write("Quel est le prénom du moderateur ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strPrenomModerateur = Console.ReadLine()!;
                Console.ResetColor();

                Console.Write("Quel est l'age du moderateur ?  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string strAgeModerateur = Console.ReadLine()!;
                Console.ResetColor();
                int intAgeModerateur;
                while (!int.TryParse(strAgeModerateur, out intAgeModerateur))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tSaisie invalide ! Réésayer : ");
                    strAgeModerateur = Console.ReadLine()!;
                    Console.ResetColor();
                }

                return (strNomModerateur, strPrenomModerateur, intAgeModerateur);
            }
        }
        public static int StartMenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Menu principal ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t1. Voir les abonnés");
                Console.WriteLine("\t2. Ajouter un abonné");
                Console.WriteLine("\t3. Bannir un abonné");
                Console.WriteLine("\t4. Voir les nouvelles");
                Console.WriteLine("\t5. Consulter une nouvelle");
                Console.WriteLine("\t6. Ajouter une nouvelle");
                Console.WriteLine("\t7. Répondre à une nouvelle");
                Console.WriteLine("\t8. Supprimer une nouvelle");
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
        public static string StartCreationEmploye()
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
        public virtual (string prenom, string nom, int age) FillUtilisateur()
        {
            Console.Write("Veuillez saisir le prénom : ");
            string strPrenom = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir le nom : ");
            string strNom = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir l'age : ");
            int intAge;
            while ((!int.TryParse(Console.ReadLine(), out intAge)) || (intAge < 0) || (intAge > 120))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }

            return (strPrenom, strNom, intAge);
        }
    }
