using ExosPOO;
using static System.Net.Mime.MediaTypeNames;

namespace ExosPOO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init du Forum
            string strNomForum;
            int intNbAbonnesForum, intNbNouvellesForum;
            char chrYN;
            (strNomForum, intNbAbonnesForum, intNbNouvellesForum, chrYN) = IHM.StartForum();

            // Init du Moderateur
            string strNomModerateur, strPrenomModerateur;
            int intAgeModerateur;
            (strNomModerateur, strPrenomModerateur, intAgeModerateur) = IHM.StartModerateur();

            //Menu principal
            int intChoix = IHM.StartMenuPrincipal();

            int intUserChoice = 0;
            do
            {
                intUserChoice = IHM.StartMenuPrincipal();
                switch (intUserChoice)
                {
                     case 0:
                        Environment.Exit(0);
                        break;

                    case 1: // Voir les abonnés
                        break;

                    case 2: // Ajouter un abonné
                        string strPrenom, strNom;
                        int intAge;

                        (strPrenom, strNom, intAge) = IHM.FillUtilisateur();
                        break;

                    case 3: // Bannir un abonné
                        break;

                    case 4: // Voir les nouvelles
                        break;

                    case 5: // Consulter une nouvelle
                        break;

                    case 6: // Ajouter une nouvelle
                        break;

                    case 7: // Répondre à une nouvelle
                        break;

                    case 8: // Supprimer une nouvelle
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice != 0);
        }
    }
}