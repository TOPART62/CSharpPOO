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
        
        public decimal Solde{ get; set; } = 0;
        public string Client { get; set; } = "Client par défaut";
        
        //Methods
        public void AfficherCompteBancaire()
        {
            Console.WriteLine($"\tEmployé ==> Client : {this.Client}, Solde = {this.Solde}");
            Console.WriteLine($"\t\tListes des operations : ");
            List<Operation> lstOperations = new List<Operation>();  
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
            //Saisie du client
            Console.Write("Veuillez saisir le nom du client : ");
            this.Client = Console.ReadLine()!.ToUpper();

            //Saisie du solde du client
            Console.Write("Veuillez saisir le solde du client : ");
            decimal dcmTmp = 0;
            while ((!Decimal.TryParse(Console.ReadLine(), out dcmTmp)) || (dcmTmp < 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.Solde = dcmTmp;

            //Saisie des operations
            Console.Write("Veuillez saisir le nombre d'operation à ajouter au compte bancaire : ");
            int intTmp = 0;
            while ((!int.TryParse(Console.ReadLine(), out intTmp)) || (intTmp < 0) || (intTmp > 10))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            
        }

        public virtual void CréerUnCompteBancaire()
        {
           
        }
    }

    

}
