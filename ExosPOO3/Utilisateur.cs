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
        private string? _prenom;
        private string? _nom;
        private int _age;

        public string Prenom { get => _prenom; set => Prenom = value; }
        public string Nom { get => _nom; set => Nom = value; }
        public int Age { get => _age; set => Age = value; }

        // Constructeurs
        public Utilisateur(string prenom, string nom, int age)
        {
            Prenom = prenom;
            Nom = nom;
            Age = age;
        }

        // Methodes
 
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
