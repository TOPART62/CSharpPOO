using System.Numerics;
using System.Reflection.Metadata;

namespace ExosPOOCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init de la liste des comptes bancaires
            List<CompteBancaire> LstCopmtesBancaires  = new List<CompteBancaire>();

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
                            cptBancaire.AfficherCompteBancaire();
                        }
                        break;

                    case 2: // Créer un compte bancaire
                        int intUserChoice2;
                        do
                        {
                            intUserChoice2 = IHM.StartCreationCompte();
                            switch (intUserChoice2)
                            {
                                case 0: // Annuler la création de compte
                                    break;

                                case 1: //Créer un compte courant 
                                    CompteCourant cptCourant = new CompteCourant();
                                    cptCourant.FillCompteBancaire();
                                    char chrOperationYN = IHM.StartCreationOperation();
                                    if (chrOperationYN == 'Y')
                                    {
                                        Operation operation = new Operation();
                                        operation.FillOperation();
                                    }
                                    break;

                                case 2: //Créer un compte épargne
                                    CompteEpargne cptEpargne = new CompteEpargne();
                                    cptEpargne.FillCompteBancaire();
                                    break;

                                case 3: ////Créer un compte payant
                                    ComptePayant cptPayant = new ComptePayant();
                                    cptPayant.FillCompteBancaire();
                                    break;

                                default:
                                    Console.Clear();
                                    break
;
                            }
                        } while (intUserChoice2 != 0);
                        
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