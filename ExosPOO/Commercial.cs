using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO
{
    internal class Commercial : Salarie
    {
        // Attributs / Propriétés
        private decimal _salaire;
        private decimal _commissionPourcentage;
        private decimal _chiffreDAffaire;
        public decimal CommissionPourcentage 
        { 
            get => _commissionPourcentage; 
            set
            {
                TotalSalaires -= (_commissionPourcentage* _chiffreDAffaire/100);
                _commissionPourcentage = value;
                TotalSalaires += (_commissionPourcentage * _chiffreDAffaire / 100);
            }
        }
        public decimal ChiffreDAffaire
        {
            get => _chiffreDAffaire;
            set
            {
                TotalSalaires -= (_commissionPourcentage * _chiffreDAffaire / 100);
                _chiffreDAffaire = value;
                TotalSalaires += (_commissionPourcentage * _chiffreDAffaire / 100);
            }
        }

        public Commercial() : base()
        {
            NombreSalaries++;
            Salaire = 16236;
        }

        public Commercial(string nom, string service, string categorie, decimal salaire, decimal commissionPourcentage, decimal chiffreDAffaire) : 
                    base(nom, service, categorie, salaire)
        {
            Nom = nom;
            Service = service;
            Categorie = categorie;
            Salaire = salaire;
            CommissionPourcentage = commissionPourcentage;
            ChiffreDAffaire = chiffreDAffaire;
        }

        public override string ToString()
        {
            return ("Le commercial : " + Nom);
        }
        public override void AfficherSalaire()
        {
            Console.Write($"Le salaire de {Nom} est de {Salaire} euros, ");
            Console.WriteLine($"et le salaire réel est de {(Salaire + (CommissionPourcentage * ChiffreDAffaire / 100))} euros");
        }
        public override void AfficherEmploye()
        {
            base.AfficherEmploye(); 
            Console.WriteLine($"\t\tCommission : {this.CommissionPourcentage}, Chiffre d'affaire : {this.ChiffreDAffaire}");
        }
        public override void FillEmploye()
        {
            // Saisie des paramètres "Salarié"
            base.FillEmploye();

            // Saisie des paramètres "Commercial" 
            Console.Write("Veuillez saisir le pourcentage de commission en pourcentage : ");
            decimal dcmTmp;
            while ((!Decimal.TryParse(Console.ReadLine(), out dcmTmp)) || (dcmTmp <= 0) || (dcmTmp > 100))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.CommissionPourcentage = dcmTmp;

            Console.Write("Veuillez saisir le chiffre d'affaire : ");
            while ((!Decimal.TryParse(Console.ReadLine(), out dcmTmp)) || (dcmTmp < 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.ChiffreDAffaire = dcmTmp;
        }
    }
}
