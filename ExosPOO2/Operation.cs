using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOOCompteBancaire
{
    internal class Operation
    {
        //COnst & Enum
        const string Depot = "Dépot";
        const string Retrait = "Retrait";
        public enum EnumStatut { Depot, Retrait }

        // Attributs et Propriétés
        private int _idOperation;
        private decimal _amount;
        private EnumStatut _statut;

        public int IdOperations { get => _idOperation; set => IdOperations = value; }
        public decimal Amount { get => _amount; set => Amount = value; }
        public EnumStatut Statut { get => _statut; set => Statut = value; }

        //Méthodes
        public override string ToString()
        {
            if (this.Statut == EnumStatut.Depot)
                return ($"\t\t\tMontant du dépot ({IdOperations}): {Amount} ");
            else
                return ($"\t\t\tMontant du retrait ({IdOperations}): {Amount} ");
        }
        public void FillOperation()
        {
            //Saisie du statut de l'opération
            Console.Write("S'agit-il d'un dépot ou d'un retrait ? D ou R ?  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string strUserChoice = Console.ReadLine()!.ToUpper();
            Console.ResetColor();
            char chrChoix;
            while (!char.TryParse(strUserChoice, out chrChoix) && chrChoix != 'D' && chrChoix != 'R')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                strUserChoice = Console.ReadLine()!;
                Console.ResetColor();
            }
            if (chrChoix == 'D')
                this.Statut = EnumStatut.Depot;
            else
                this.Statut = EnumStatut.Retrait;

            //Saisie du numero de l'opération
            Console.Write("Veuillez saisir le numéro de l'opération : ");
            int intTmp = 0;
            while (!int.TryParse(Console.ReadLine(), out intTmp))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.IdOperations = intTmp;

            //Saisie du montant de l'opération
            Console.Write("Veuillez saisir le montant de l'opération : ");
            intTmp = 0;
            while (!int.TryParse(Console.ReadLine(), out intTmp))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tSaisie invalide ! Réésayer : ");
                Console.ResetColor();
            }
            this.IdOperations = intTmp;

        }
        public void CreerListeOperations()
        {

        }
    }
}
