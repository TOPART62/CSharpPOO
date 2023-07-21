using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class ComptePayant : CompteBancaire
    {
        public override void AfficherCompteBancaire()
        {
            Console.WriteLine("=== Compte payant === ");
            base.AfficherCompteBancaire();

        }

    }
}
