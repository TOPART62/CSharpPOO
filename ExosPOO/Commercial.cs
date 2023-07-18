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
        private decimal __commissionPourcentage;
        private decimal _chiffreDAffaire;
        public new decimal Salaire
        {
            get => _salaire;
            set 
            {
                TotalSalaires -= _salaire;
                _salaire = value;
                TotalSalaires += _salaire;
            }
        }
        public decimal CommissionPourcentage 
        { 
            get => __commissionPourcentage; 
            set
            {
                TotalSalaires -= (__commissionPourcentage* _chiffreDAffaire/100);
                _salaire = value;
                TotalSalaires += (__commissionPourcentage * _chiffreDAffaire / 100);
            }
        }
        public decimal ChiffreDAffaire
        {
            get => _chiffreDAffaire;
            set
            {
                TotalSalaires -= (__commissionPourcentage * _chiffreDAffaire / 100);
                _chiffreDAffaire = value;
                TotalSalaires += (__commissionPourcentage * _chiffreDAffaire / 100);
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
            base.AfficherSalaire();
            Console.WriteLine($"Le salaire réel de {Nom} est de {(Salaire + (CommissionPourcentage * ChiffreDAffaire / 100))} euros");
        }
    }
}
