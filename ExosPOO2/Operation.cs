using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO2
{
    internal class Operation
    {
        // Attributs et Propriétés
        private decimal _amount;    
        private CompteBancaire? _compteBancaire;

        public int Amount { get; set; } = 0;
        public CompteBancaire? CompteBancaire { get; set; }

        //Méthodes
        public override string ToString()
        {
            if (this.CompteBancaire is not null)
                return ($"\t\t\tMontant de l'operation: {Amount} sur le compte bancaire {this.CompteBancaire.Client}");
            else
                if (CompteBancaire.Client is not null)
                return ($"\t\t\tLe compte bancaire du client {CompteBancaire.Client} n'existe pas !!!");
            else
                return ($"\t\t\tLe compte bancaire n'a pas de Client !!!");
        }
        // Recherche des operations d'un client
        public List<Operation> ListerLesOperationsDUnCOmpteBancaire()
        {
            if (this.CompteBancaire is not null)
                return ($"\t\t\tMontant de l'operation: {this.Amount} sur le compte bancaire {this.CompteBancaire.Client}");
            else
                return ($"\t\t\tLe compte bancaire du client {this.CompteBancaire.Client} n'existe pas !!!");
        }

    }
}
