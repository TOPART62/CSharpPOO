using System.IO;

namespace ExosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Init Liste de Salariés
            List<Salarie> LstSalarie = new List<Salarie>()
            {
                new Salarie("ARTHUR", "00000", "A", 100000),
                new Salarie("CHLOE", "11111", "B", 120000),
                new Salarie("BERNARD", "22222", "C", 200000),
                new Commercial("ISABELLE", "33333", "C", 180000, 5, 950000)
            };

            // Sortie de la boucle quand Saisie du menu Quitter
            int intUserChoice = 0;
            do
            {
                intUserChoice = IHM.StartMenu();
                switch (intUserChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1: // Ajouter un employé
                        char chrUserType = IHM.StartType();
                        if (chrUserType == 'S') 
                        {
                            Salarie newSalarie = new Salarie();
                            newSalarie.FillEmploye();
                            newSalarie.AjouterEmploye(LstSalarie);
                            newSalarie.AfficherEmploye();
                        }
                        else if (chrUserType == 'C')
                        {
                            Commercial newCommercial = new Commercial();
                            newCommercial.FillEmploye();
                            newCommercial.AjouterEmploye(LstSalarie);
                            newCommercial.AfficherEmploye();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\tErreur de saisie !!!");
                            Console.ResetColor();
                        }
                        break;

                    case 2: // Afficher le salaire de tous les employés
                        foreach (Salarie employe in LstSalarie)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                            employe.AfficherSalaire();
                            employe.AfficherEmploye();
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                        }
                        break;

                    case 3: // Rechercher un employé
                        String strName = IHM.StartRecherche();
                        Salarie employeRecherche = new Salarie();
                        employeRecherche = employeRecherche.RechercherEmploye(strName, LstSalarie);
                        if (employeRecherche is null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nLe salarié recherché n'existe pas !!! ");
                            Console.ResetColor();
                        }
                        else
                            employeRecherche.AfficherEmploye();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice != 0); 
        }
    }
}