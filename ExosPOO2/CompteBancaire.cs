using ExosPOO;
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

        //Methods
        public void AfficherCompteBancaire()
        {
            Console.WriteLine($"\tEmployé ==> Client : {this.Client}, Solde = {this.Solde}");
            Console.WriteLine($"\t\tListes des operations : ");
            foreach ( Operation op in ListOperations) 
            {
                if (ListOperations is null)
                    Console.WriteLine($"Le client {this.Client} n'a pas fait d'operation !!! ");
                else
                    Console.WriteLine( op.ToString()); 
            }
        }

        public void FillCompteBancaire()
        {
            Console.Write("Veuillez saisir le nom du client: ");
            this.Client = Console.ReadLine()!.ToUpper();

            Console.Write("Veuillez saisir le solde du client : ");
            decimal dcmTmp;
            while ((!Decimal.TryParse(Console.ReadLine(), out dcmTmp)) || (dcmTmp < 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.Solde = dcmTmp;
        }
        
        public virtual void CréerUnCompteBancaire()
        {
           
        }
    }

    

}
