using ExosPOO;

namespace ExosPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Init Liste de Salariés
            List<Client> LstClient = new List<Client>()
            {
                new Client()
            };
            List<CompteBancaire> LstCopmtesBancaires = new List<CompteBancaire>()
            {
                //new CompteBancaire(),
            };

            // Sortie de la boucle quand Saisie du menu Quitter
            int intUserChoice = 0;
            do
            {
                intUserChoice = IHM.StartMenu();
                switch (intUserChoice)
                {
                    case 0: // Quitter
                        Environment.Exit(0);
                        break;

                    case 1: // Lister les comptes bancaires
                        foreach (CompteBancaire cptBancaire in LstCopmtesBancaires)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                            cptBancaire.AfficherCompteBancaire();
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                        }
                        break;

                    case 2: // Créer un compte bancaire
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                        //CompteBancaire cptBancaire = new CompteBancaire();
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                        break;

                    case 3: // Effectuer un dépot
                        break;

                    case 4: // Effectuer un retrait
                        break;

                    case 5: // Afficher les operations et le solde
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice != 0);
        }
    }
}