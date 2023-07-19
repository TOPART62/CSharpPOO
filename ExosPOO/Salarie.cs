using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO
{
    internal class Salarie
    {
        // Attributs / Propriétés
        private decimal _matricule;
        private decimal _salaire;

        public decimal Matricule
        {
            get => _matricule;
            set
            {
                MatriculeLastIndex++;
                _matricule = MatriculeLastIndex;
            } 
        }
        public decimal Salaire
        {
            get => _salaire;
            set 
            {
                TotalSalaires -= _salaire;
                _salaire = value;
                TotalSalaires += _salaire;
            }
        }
        public string Nom { get; set; } = "Salarié par défaut";
        public string Service { get; set; } = "Service par défaut";
        public string Categorie { get; set; } = "Catégorie par défaut";
        public static int NombreSalaries { get; set; } = 0; 
        public static decimal TotalSalaires { get; set; } = 0;
        public static int MatriculeLastIndex { get; set; } = 0; 

        //Constructeurs
        public Salarie()
        {
            Matricule = MatriculeLastIndex + 1;
            NombreSalaries++;
            Salaire = 16236;
        }

        public Salarie(string nom, string service, string categorie, decimal salaire) : this()
        {
            Nom = nom;
            Service = service;
            Categorie = categorie;
            Salaire = salaire;
        }

        // Méthodes
        public static void RemiseAZero()
        {
            NombreSalaries = 0;
            TotalSalaires = 0;
        }
        public override string ToString() 
        { 
            return ("Le salarié : " + Nom);
        }

        public void AjouterEmploye(List<Salarie> lstSalarie)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            lstSalarie.Add(this);
            Console.WriteLine($"\nL'employé {Nom} du service {Service} a été ajouté à l'entreprise.");
            Console.ResetColor();
        }
        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }
        public virtual void AfficherEmploye()
        {
            Console.WriteLine($"\tEmployé ==> Matricule : {this.Matricule}, Nom = {this.Nom}, Service : {this.Service}, Catégorie : {this.Categorie}, Salaire : {this.Salaire}");
        }
        public Salarie RechercherEmploye(String name, List<Salarie> lstSalarie)
        {
            foreach (Salarie item in lstSalarie)
                if (item.Nom.Contains(name))
                    return item;
            return null;
        }
        public virtual void FillEmploye()
        {
            Console.Write("Veuillez saisir le nom : ");
            this.Nom = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir le service : ");
            this.Service = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir la catégorie : ");
            this.Categorie = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir le salaire : ");
            decimal dcmTmp;
            while ((!Decimal.TryParse(Console.ReadLine(), out dcmTmp)) || (dcmTmp < 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.Salaire = dcmTmp;
        }
    }
}
