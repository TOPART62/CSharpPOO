using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03Polymorphisme
{
    internal class Dinausaur
    {
        private static int _nombreDeDinos = 0;
        public string Nom { get; set; } = "Dino par défaut";
        public int Age { get; set; } = 0;
        public string Espece { get; set; } = "Espèce par défaut";
        public int NbPates { get; set; } = 4;
        public double Poids { get; set; } = 12;
        public bool PeutVoler { get; set; } = false;
        public string RegimeAlimentaire { get; set; } = "Omnivore";
        public static int NombreDeDinos { get => _nombreDeDinos; }
        public Dinausaur()
        {
            _nombreDeDinos++;
        }
        public Dinausaur(string nom, int age, string espece, bool peutVoler) : this()
        {
            Nom = nom;
            Age = age;
            Espece = espece;
            PeutVoler = peutVoler;
        }
        public void SEnvoler()
        {
            if (PeutVoler)
            {
                Console.WriteLine($"Le dinosaur {Nom} s'envole majestueusement !");
                return;
            }
            Console.WriteLine($"Le dinosaur {Nom} saute et s'écrase sur le sol lamentablement...");
        }
        public override string ToString()
        {
            return $"Le Dinosaur {Nom} est agé de {Age} ans et est de l'espèce {Espece}";
        }
    }
}
