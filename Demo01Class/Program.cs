using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Demo01Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // exo 1 Chaise
            Chaise objChaise1 = new Chaise(4, "Bois", "Blanche");
            objChaise1.Afficher();
            Chaise objChaise2 = new Chaise(2, "Métal", "Noire");
            objChaise2.Afficher();
            Chaise objChaise3 = new Chaise(6, "Plastique", "Bleue");
            objChaise3.Afficher();
            */

            /*
            // exo 2 Salarié
            // public Salarie(string idUser, string service, string category, string name, double salary)
            List<Salarie> listSalarie = new List<Salarie>
            {
                (new Salarie("M001", "11111", "A", "Chloé", 24000)),
                (new Salarie("M001", "22222", "B", "Emma", 30000)),
                (new Salarie("M003", "33333", "C", "Georges", 26000))
            };

            // Boucle Salarié
            foreach (Salarie itemSalarie in listSalarie) itemSalarie.DisplaySalary();
            // Montant total & nb total
            Salarie.DisplayTotal();

            // Changement de salaire de Chloé
            Salarie salarieChloe = new Salarie();
            foreach (Salarie itemSalarie in listSalarie)
            {
                Console.WriteLine(itemSalarie.Name);
                if (itemSalarie.Name == "Chloé")
                {
                    salarieChloe = itemSalarie;
                }
            }
            
            salarieChloe.Salary = 500000;
            Salarie.DisplayTotal();

            // Init 0
            Salarie.Init0();
            Salarie.DisplayTotal();
            */

            
            // exo 3 Pendu
            // Creation de l'instance pendu
            Pendu itemPendu = new Pendu();  

            // Saisie du nombre d'essais
            itemPendu.FillValuesForStarting();

            // Recherche d'un mot aléatoire
            itemPendu.SearchRandomWordGenerateMask();

            // Init du mot à trouver
            itemPendu.GenerateMask();

            // Affichage du nombre d'essais
            Console.WriteLine("Jeu du pendu généré !!! Nombre d'essais : " + itemPendu.NbEssais + " !");
            Console.WriteLine("Le mot à trouver est : " + itemPendu.Masque);
            Console.WriteLine($"Il vous reste {itemPendu.NbEssais} essais ...");
            
            Boolean boolWinner = false; 
            do
            {
                if (itemPendu.NbEssais == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tYOU'VE LOST !!! ");
                    Console.ResetColor();
                }
                else
                {
                    Char chrDigit;
                    Console.Write($"Veuillez saisir une lettre : ");
                    Boolean boolSaisieOK = char.TryParse(Console.ReadLine(), out chrDigit);
                    while (!boolSaisieOK)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\tErreur de saisie!!! Veuillez resaisir la lettre : ");
                        Console.ResetColor();
                        boolSaisieOK = char.TryParse(Console.ReadLine(), out chrDigit);
                    }
                    itemPendu.TestChar(chrDigit);

                    boolWinner = itemPendu.TestWin();

                    if (!boolWinner)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\t\tCONGRATULATIONS !!! ");
                        Console.ResetColor();
                    }
                    else
                    {
                        itemPendu.NbEssais--;
                        Console.WriteLine("Le mot à trouver est : " + itemPendu.Masque);
                        Console.WriteLine($"Il vous reste {itemPendu.NbEssais} essais ...");
                        Pendu.AffichagePendu(itemPendu.NbEssais, itemPendu.NbEssaisMax);
                    }
                }
            } while (!boolWinner && (itemPendu.NbEssais >= 0));

            /*
            // exo 4 Citerne
            //Saisie des citernes 
            WaterTank watertank1 = new WaterTank(20, 20, 10);    
            WaterTank watertank2 = new WaterTank(10, 10, 5);

            Console.WriteLine($"Poids total de la citerne 1 : {watertank1.TotalWeightCalculation()}");
            Console.WriteLine($"Poids total de la citerne 2 : {watertank2.TotalWeightCalculation()}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"Quantité d'eau dans la citerne 1 : {watertank1.CompletedLevel}");
            watertank1.AffichageCiterne();
            Console.WriteLine($"Quantité d'eau dans la citerne 2 : {watertank2.CompletedLevel}");
            watertank2.AffichageCiterne();
            Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalFillLevels}");
            Console.WriteLine("----------------------");

            int excessWater = watertank1.Fill(11);
            Console.WriteLine($"Quantité d'eau dans la citerne 1 après ajout de 11 litres: {watertank1.CompletedLevel}/{watertank1.MaxCapacity}");
            Console.WriteLine($"Excès d'eau récupéré : {excessWater}");

            int waterTaken = watertank2.Empty(11);
            Console.WriteLine($"Quantité d'eau dans la citerne 2 après tentative de retrait de 11 litres: {watertank2.CompletedLevel}/{watertank2.MaxCapacity}");
            Console.WriteLine($"Quantité d'eau récupérée : {waterTaken}");
            Console.WriteLine("----------------------");

            Console.WriteLine($"Quantité d'eau dans la citerne 1 : {watertank1.CompletedLevel}");
            watertank1.AffichageCiterne();
            Console.WriteLine($"Quantité d'eau dans la citerne 2 : {watertank2.CompletedLevel}");
            watertank2.AffichageCiterne();

            Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalFillLevels}");

            Console.WriteLine($"Poids total de la citerne 1 : {watertank1.TotalWeightCalculation()}");
            Console.WriteLine($"Poids total de la citerne 2 : {watertank2.TotalWeightCalculation()}");
            */   
        }
    }
}