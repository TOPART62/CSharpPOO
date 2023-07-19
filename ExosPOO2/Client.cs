using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO2
{
    internal class Client
    {
        //Attributs et Propriétés
        private int _id;    
        private string? _nom;   
        private string? _prenom;
        private string? _tel;    
        private List<CompteBancaire>? _listComptesBancaires;

        public int ID { get; set; } = 0;
        public string Nom { get; set; } = "Nom Client par défaut";
        public string Prenom { get; set; } = "Prénom Client par défaut";
        public string Tel { get; set; } = "Téléphone Client par défaut";
        public List<CompteBancaire>? ListComptesBancaires { get; set; }

    }
}
