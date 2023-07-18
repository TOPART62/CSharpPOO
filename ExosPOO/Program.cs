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
                new Salarie("Arthur", "00000", "A", 1000),
                new Salarie("Chloé", "11111", "B", 1200),
                new Salarie("Bernard", "22222", "C", 2000),
                new Commercial("Isabelle", "33333", "C", 1800, 5, 9500)
            };

            (int intUserChoice, char userType) = IHM.Start();

            switch (intUserChoice)
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1: // Ajouter un employé
                    if (userType == 'S')
                    {
                        Salarie newSalarie = new Salarie();
                        newSalarie.FillEmploye();
                        newSalarie.AjouterEmploye(LstSalarie);
                    }
                    else 
                    {
                        Commercial newCommercial = new Commercial();
                        newCommercial.FillEmploye();
                        newCommercial.AjouterEmploye(LstSalarie);
                    }
                    break;

                case 2: // Afficher le salaire de tous les employés
                    foreach (Salarie employe in LstSalarie) 
                            employe.AfficherSalaire();
                    break;

                case 3: // Rechercher un employé
                    Salarie employeRecherche =  new Salarie();
                    (new Salarie("Ch", "", "", 0)).RechercherEmploye(employeRecherche, LstSalarie);
                    employeRecherche.AfficherSalaire();
                    break;

                default:
                    Console.Clear();
                    break;
            }

        }
    }
}