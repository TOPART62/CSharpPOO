using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class Client
    {
        //Attributs et Propriétés
        private int _id;    
        private string? _nom;   
        private string? _prenom;
        private string? _tel;    
        private List<CompteBancaire>? _listComptesBancaires;

        public int ID { get => _id; set => ID = value; }
        public string? Nom { get => _nom; set => Nom = value; }
        public string? Prenom { get => _prenom; set => Prenom = value; }
        public string? Tel { get => _tel; set => Tel = value; }
        public List<CompteBancaire>? ListComptesBancaires { get; set; }

    }
}
