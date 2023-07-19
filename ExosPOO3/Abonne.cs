using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO3
{
    internal class Abonne : Utilisateur
    {
        // Attributs & Propriétés
        private Nouvelle _idNouvelle;

        public Nouvelle IdNouvelle { get; set; }

        //Constructeurs
        public Abonne(string prenom, string nom, int age) : base(prenom, nom, age)
        {
        }

        // Methodes
        public void VoirLesAbonnes()
        {

        }
        public void AjouterUnAbonne()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            lstSalarie.Add(this);
            Console.WriteLine($"\nL'employé {Nom} du service {Service} a été ajouté à l'entreprise.");
            Console.ResetColor();
        }
    }
}
