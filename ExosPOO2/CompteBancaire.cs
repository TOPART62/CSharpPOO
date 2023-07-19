using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO2
{
    internal abstract class CompteBancaire
    {
        // Attributs & Propriétés
        private decimal _solde;
        private string? _client;
        private List<Operation>? _listOperations;
        
        public decimal Solde{ get; set; } = 0;
        public string Client { get; set; } = "Client par défaut";
        public List<Operation>? ListOperations{ get; set; }

        // Constructeurs

        //Methods
        public void AfficherCompteBancaire()
        {
            Console.WriteLine($"\tEmployé ==> Client : {this.Client}, Solde = {this.Solde}");
            Console.WriteLine($"\t\tListes des operations : ");
            foreach ( Operation op in _listOperations ) 
            { 
                Console.WriteLine( op.ToString()); 
            }
        }
    }

    

}
