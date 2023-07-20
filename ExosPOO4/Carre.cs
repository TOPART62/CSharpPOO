using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO4
{
    internal class Carre : Figure
    {
        /*          <-+cote->
         *          A       B
         * 
         *    -cote
         * 
         *          D       C
         */

        // Attributs & Propriétés
        public double Cote { get; set; }
        public Point B => new Point(A.X + Cote, A.Y);
        // Syntaxe d'implémentation de "get" !
        // Peut s'écrire : public Point B { get => new Point(A.X + Cote, A.Y); }
        public Point C => new Point(A.X + Cote, A.Y - Cote);
        public Point D => new Point(A.X , A.Y - Cote);

        //Constructeurs
        public Carre(Point a, double cote) : base(a)    
        {
            this.Cote = cote;
        }
        public Carre(double x, double y, double cote) : base(x,y)
        {
            this.Cote = cote;
        }

        //Méthodes
        public override string ToString()
        {
            //return base.ToString();
            return $"Carré ABCD de coté {Cote}" +
                $"\nA = {A}" +
                $"\nB = {B}" +
                $"\nC = {C}" +
                $"\nD = {D}";
        }


    }
}
