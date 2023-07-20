using ExosPOO;
using System.Numerics;
using System.Reflection.Metadata;

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
            int intUserChoice1 = 0;
            do
            {
                intUserChoice1 = IHM.StartMenu();
                switch (intUserChoice1)
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
                        int intUserChoice2;
                        do
                        {
                            intUserChoice2 = IHM.StartCreationCompte();
                            switch (intUserChoice2)
                            {
                                case 0: // Annuler la création de compte
                                    break;
                                case 1: //Créer un compte courant => P (Compte Payant), E (Compte Epargne) ou C (Compte Courant)
                                    char chrChoixTypeCompte = IHM.StartTypeCompteBancaire();
                                    if (chrChoixTypeCompte == 'P')
                                    {
                                        ComptePayant compte= new ComptePayant();
                                        compte.FillCompteBancaire();
                                    }
                                    else if (chrChoixTypeCompte == 'E')
                                    {
                                        CompteEpargne compte = new CompteEpargne();
                                        compte.FillCompteBancaire();
                                    }
                                    else if (chrChoixTypeCompte == 'C')
                                    {
                                        CompteCourant compte = new CompteCourant();
                                        compte.FillCompteBancaire();
                                    }
                                    break;

                                case 2: //Créer un compte épargne
                                    break;

                                case 3: ////Créer un compte payant
                                    break;

                                default:
                                    Console.Clear();
                                    break
;
                            }
                        } while (intUserChoice2 != 0);
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
            } while (intUserChoice1 != 0);
        }
    }
}