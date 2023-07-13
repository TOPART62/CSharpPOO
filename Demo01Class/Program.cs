using System.Xml.Linq;

namespace Demo01Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // exo 1 Chaise
            Chaise objChaise1 = new Chaise(4, "Bois", "Blanche");
            objChaise1.Afficher();
            Chaise objChaise2 = new Chaise(2, "Métal", "Noire");
            objChaise2.Afficher();
            Chaise objChaise3 = new Chaise(6, "Plastique", "Bleue");
            objChaise3.Afficher();
            */

            // exo 2 Salarié
            // public Salarie(string idUser, string service, string category, string name, double salary)
            List<Salarie> listSalarie = new List<Salarie>
            {
                (new Salarie("M001", "11111", "A", "Chloé", 24000)),
                (new Salarie("M001", "22222", "B", "Emma", 30000)),
                (new Salarie("M003", "33333", "C", "Georges", 26000))
            };
            // Boucle Salarié
            foreach (var itemSalarie in listSalarie)
            {
                itemSalarie.DisplaySalary();
            }

            // Montant total
            new Salarie.DisplayTotalValues();
            //Console.WriteLine("Le montant total des salaires des " + listSalarie.Count + " est de : ");
        }
    }
}