using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO3
{
    internal class Forum
    {
        // Attributs et Propriétés
        private string _nom;
        private DateTime _date;
        private List<Abonne> _lstAbonnes;
        private List<Nouvelle> _lstNouvelles;
        private Moderateur _moderateur;

        public string Nom { get; set; } = "Forum par défaut";
        public DateTime Date { get { return _date;} set { _date = value; } }
        public List<Abonne> LstAbonnes { get; set; }
        public List<Nouvelle> LstNouvelles { get; set; }
        public Moderateur IdModerateur { get; set; }

        // Constructeurs
        public Forum(string nom, DateTime date, List<Abonne> lstAbonne, List<Nouvelle> lstNouvelles, Moderateur idModerateur)
        {
            Nom = nom;
            Date = date;
            LstAbonnes = lstAbonne;
            LstNouvelles = lstNouvelles;
            IdModerateur = idModerateur;
        }


    }
}
