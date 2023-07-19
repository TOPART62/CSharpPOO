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
        
        public override void AjouterUnUtilisateur()
        {
            base.AjouterUnUtilisateur();    
            Abonne newAbonne = new Abonne();
            newCommercial.FillEmploye();
            newCommercial.AjouterEmploye(LstSalarie);
            newCommercial.AfficherEmploye();

        }
    }
}
