using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Class
{
    internal class Salarie
    {
        //Attributs d'instances
        private string? _idUser;
        private string? _service;
        private string? _category;
        private string? _name;
        private double _salary;
        //Attributs de classe
        private static int _nbSalaries = 0;
        private static double _totalSalary = 0;

        // Properties 
        public string? IdUser { get => _idUser; set => _idUser = value; }
        public string? Service { get => _service; set => _service = value; }
        public string? Category { get => _category; set => _category = value; }
        public string? Name { get => _name; set => _name = value; }
        public double Salary 
        { 
            get => _salary;
            set 
            {
                double dblsalary = _totalSalary - _salary;
                _salary = value;
                _totalSalary = dblsalary + value;
            }
        }
        public static int NbSalaries { get => _nbSalaries; set => _nbSalaries = value; }
        public static double TotalSalary {get => _totalSalary;set => _totalSalary = value;}

        // Constructors
        public Salarie()
        {
            _salary = 0;
            _nbSalaries++;
        }
        public Salarie(string idUser, string service, string category, string name, double salary) : this() 
        {
            _idUser = idUser;
            _service = service;
            _category = category;
            _name = name;
            _salary = salary;
            _totalSalary = _totalSalary + salary;
        }

        // Methods
        public override String ToString()
        {
            return ("Le salaire de " + Name + " est de " + Salary + ".");
        }
        public void DisplaySalary()
        {
            Console.WriteLine(this.ToString());
        }
        public static void DisplayTotal()
        {
            Console.WriteLine($"Le montant total des {Salarie.NbSalaries} salariés est de {Salarie.TotalSalary} !");
        }
        public static void Init0()
        {
            Salarie.NbSalaries = 0; 
            Salarie.TotalSalary = 0;   
        }
    }
}
