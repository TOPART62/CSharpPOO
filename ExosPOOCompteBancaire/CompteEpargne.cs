using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class CompteEpargne : CompteBancaire
    {
        public override void AfficherCompteBancaire()
        {
            Console.WriteLine("=== Compte épargne === ");
            base.AfficherCompteBancaire();

        }

    }
}
