﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant() : base()
        {
        }
        public CompteCourant(decimal solde, string client, List<Operation>? operations) : base(solde, client, operations)
        {
        }
        public override void CréerUnCompteBancaire()
        {
            base.CréerUnCompteBancaire();
        }
        public override void AfficherCompteBancaire()
        {
            Console.WriteLine("=== Compte courant === ");
            base.AfficherCompteBancaire();

        }
    }
}