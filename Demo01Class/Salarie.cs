using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Class
{
    internal class Salarie
    {
        //Attributs
        private string _idUser;
        private string _service;
        private string _category;
        private string _name;
        private double _salary;
        static int _nbSalaries;
        static double _totalSalary;

        // Properties 
        public string IdUser { get => _idUser; set => _idUser = value; }
        public string Service { get => _service; set => _service = value; }
        public string Category { get => _category; set => _category = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public static int NbSalaries { get => _nbSalaries; set => _nbSalaries = value; }
        public static double Totalsalarie { get => _totalSalary; set => _totalSalary = value; }

        // Constructors
        public Salarie(string idUser, string service, string category, string name, double salary)
        {
            _idUser = idUser;
            _service = service;
            _category = category;
            _name = name;
            _salary = salary;
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
        public static void DisplayTotalValues()
        {
            Console.WriteLine($"Le montant total des {NbSalaries} salariés est de {Totalsalarie} !");
        }
    }
}
