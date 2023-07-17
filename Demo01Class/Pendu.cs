using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo01Class
{
    internal class Pendu
    {
        //Attributs d'instances
        private string? _masque;
        private int _nbEssais;
        private string? _motATrouver;
        
        // Properties 
        public string Masque { get => _masque!; set => _masque = value; }
        public int NbEssais { get => _nbEssais; set => _nbEssais = value; }
        public string MotATrouver { get => _motATrouver!; set => _motATrouver = value; }

        // Constructors
        public Pendu()
        {
        }

        // Methods
        public void TestChar(char chrDigit)
        {
            int IntI = 0;
            foreach (Char chrI in this.MotATrouver)
            {
                if (chrDigit.ToString().ToLower() == chrI.ToString().ToLower())
                    this.Masque = this.Masque.Substring(0, IntI) + chrI.ToString().ToLower() + this.Masque.Substring(IntI + 1); ;
                IntI++;
            }
        }
        public bool TestWin()
        {
            if (this.MotATrouver.ToLower() == this.Masque.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tCONGRATULATIONS !!! ");
                Console.ResetColor();
                return true;
            }
            else
            {
                //AffichagePendu(this.NbEssais, int nbEssaiMax)
                Console.WriteLine("Le mot à trouver est : " + this.Masque);
                Console.WriteLine($"Il vous reste {this.NbEssais} essais ...");
                return false;
            }
        }

        public void FillValues()
        {
            Console.WriteLine(" === Paramètres de partie === ");
            String strSaisie = "";
            do
            {
                Console.WriteLine("Voulez-vous un nombre d'essais spécifique (10 par défaut) ? Y/N ?");
                strSaisie = Console.ReadLine()!;
                strSaisie = strSaisie.ToUpper();    
                if ((strSaisie != "Y") && (strSaisie != "N"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\tErreur de saisie!!! Veuillez resaisir ! Y/N ? ");
                    Console.ResetColor();
                    strSaisie = Console.ReadLine()!;
                }
            } while ((strSaisie != "Y") && (strSaisie != "N"));

            int intNbEssais = 10;
            if (strSaisie == "Y")
            { 
                Boolean boolSaisieOK = false;
                do
                {
                    Console.WriteLine("Combien d'essais voulez-vous");
                    boolSaisieOK = int.TryParse(Console.ReadLine(), out intNbEssais);
                    if (!boolSaisieOK)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\tErreur de saisie!!! Veuillez resaisir le nombre d'essais : ");
                        Console.ResetColor();
                        boolSaisieOK = int.TryParse(Console.ReadLine(), out intNbEssais);
                    }
                } while (!boolSaisieOK);
            }
            this.NbEssais = intNbEssais;
        }
        public void SearchRandomWordGenerateMask()
        {
            Random rndMotAleatoire = new Random();
            string[] strMotSecret = { "turlututu", "chapeau", "pointu" };
            int rndNumber = rndMotAleatoire.Next(0, strMotSecret.Length);
            this.MotATrouver = strMotSecret[rndNumber].ToLower();
        }
        public void GenerateMask()
        {
            foreach (char s in this.MotATrouver) this.Masque += '*';
        }
        public static void AffichagePendu(int noEssai, int nbEssaiMax)
        {
            string[,] penduAscii = {
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            "},
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "--------    "},
                {"           ",
                "            ",
                "            ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"_____      ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |        O ",
                " |       /|\\",
                " |       / \\",
                " |          ",
                "--------    "},
            };
            int noPendu = noEssai == 0 ? 0 : (noEssai * 8 / nbEssaiMax);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(penduAscii[noPendu, i]);
            }
        }
    }
}
