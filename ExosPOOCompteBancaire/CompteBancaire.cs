using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal abstract class CompteBancaire
    {
        // Attributs & Propriétés
        private decimal _solde;
        private string? _client;
        private List<Operation>? _operations;    
        
        public decimal Solde{ get => _solde; set => Solde = value; }
        public string Client { get => _client!; set => Client = value; }
        public List<Operation>? Operations { get; set; }

        //Constructeurs
        public  CompteBancaire(decimal solde, string client, List<Operation>? operations)
        {
            Solde = solde;
            Client = client;
            Operations = operations;
        }


        //Methods
        public virtual void AfficherCompteBancaire()
        {
            Console.WriteLine($"\tEmployé ==> Client : {this.Client}, Solde = {this.Solde}");
            Console.WriteLine($"\t\tListes des operations : ");
            List<Operation> lstOperations = new List<Operation>();  
            if ((Operations is null) || (Operations.Count == 0))
                Console.WriteLine($"Le client {this.Client} n'a pas fait d'operation !!! ");
            else
            {
                int i = 1;
                foreach (Operation op in this.Operations)
                {
                    Console.WriteLine($"Operation {i} = {op.ToString()}");
                    i++;
                }
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
        }
        public void ListerLesOperationsDUnCOmpteBancaire()
        {
            int i = 1;
            if ((Operations is not null) && (Operations.Count > 0))
            {
                Console.WriteLine($"Sur le compte bancaire {this.Client}");
                foreach (Operation op in Operations)
                {
                    i++;
                    Console.WriteLine($"\t\t\tMontant de l'operation {i} : {op.Amount} ");
                }
            }
        }

        public virtual void CréerUnCompteBancaire()
        {
           
        }
    }

    

}
