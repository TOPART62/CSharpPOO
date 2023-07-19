using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO3
{
    internal class Utilisateur
    {
        // Attributd & Propriétés
        private string _prenom;
        private string _nom;
        private int _age;

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }

        // Constructeurs
        public Utilisateur(string prenom, string nom, int age)
        {
            Prenom = prenom;
            Nom = nom;
            Age = age;
        }

        // Methodes
        public virtual void FillUtilisateur()
        {
            Console.Write("Veuillez saisir le prénom : ");
            this.Prenom = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir le nom : ");
            this.Nom = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir l'age : ");
            int intTmp;
            while ((!int.TryParse(Console.ReadLine(), out intTmp)) || (intTmp < 0) || (intTmp > 120)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.Age = intTmp;

        public virtual void AjouterUnUtilisateur()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (this.GetType() == typeof(Abonne) ) 

                Console.WriteLine($"\nL'abonné {Prenom} {Nom} a été créé.");
            else if (this.GetType() == typeof(Moderateur))
                Console.WriteLine($"\nLe moderateur {Prenom} {Nom} a été créé.");
            else
                Console.WriteLine($"\nL'utilisateur {Prenom} {Nom} a été créé.");

            Console.ResetColor();
        }
    }
}
