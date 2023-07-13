using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Class
{
    internal class Chaise
    {
        //Attributs
        private int? _nbPieds;
        private string? _materiaux;
        private string? _couleur;

        // Propriétés 
        public int? NbPieds { get => _nbPieds; set => _nbPieds = value; }
        public string? Materiaux { get => _materiaux; set => _materiaux = value; }
        public string? Couleur { get => _couleur; set => _couleur = value; }

        // Constructeurs
        public Chaise(int nbPieds, string materiaux, string couleur)
        {
            this.NbPieds = nbPieds;
            this.Materiaux = materiaux;
            this.Couleur = couleur;
        }

        // Méthodes
        public override String ToString()
        {
            return ("Je suis une chaise avec " + NbPieds + " pieds, en " + Materiaux + " et de couleur " + Couleur + ".");
        }

        public void Afficher()
        {
            //Console.WriteLine($"Je suis une chaise avec {NbPieds} pieds, en {Materiaux} et de couleur {Couleur}.");
            Console.WriteLine(this.ToString());
        }
    }
}
