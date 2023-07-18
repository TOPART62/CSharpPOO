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
            lstSalarie.Add(this);
            Console.WriteLine($"L'employé : {Nom} du service {Service} a été ajouté à l'entreprise.");
        }
        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }
        public void RechercherEmploye(Salarie item, List<Salarie> lstSalarie)
        {
            foreach (Salarie itemSalarie in lstSalarie)
            {
                if (itemSalarie.Nom.Contains(this.Nom))
                {
                    item = itemSalarie;
                    break;
                }
            }
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }
        public void FillEmploye()
        {
            Console.Write("Veuillez saisir le nom : ");
            this.Nom = Console.ReadLine()!;

            Console.Write("Veuillez saisir le service : ");
            this.Service = Console.ReadLine()!;

            Console.Write("Veuillez saisir la catégorie : ");
            this.Categorie = Console.ReadLine()!;

            Console.Write("Veuillez saisir le salaire : ");
            decimal dcmSalaire;
            if (!decimal.TryParse(Console.ReadLine(), out dcmSalaire)) this.Salaire = 0;
            else this.Salaire = dcmSalaire;
        }
    }
}
