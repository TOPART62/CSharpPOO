using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO4
{
    internal class Rectangle : Figure
    {
        /*          <-    longueur ->
         *          A               B
         * 
         * largeur
         * 
         *          D               C
         */

        // Attributs & Propriétés
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Point B { get => new Point(A.X + Longueur, A.Y); }
        public Point C => new Point(A.X + Longueur, A.Y - Largeur);
        public Point D => new Point(A.X, A.Y - Largeur);


        // Constructeur 
        public Rectangle(Point a, double longueur, double largeur) : base(a)
        {
            this.Longueur = longueur;
            this.Largeur = largeur;
        }
        public Rectangle(double x, double y, double longueur, double largeur) : base(x, y)
        {
            this.Longueur = longueur;
            this.Largeur = largeur;
        }

        //Méthodes
        public override string ToString()
        {
            //return base.ToString();
            return $"Rectangle ABCD de longueur {Longueur} et de largeur {Largeur}" +
                $"\nA = {A}" +
                $"\nB = {B}" +
                $"\nC = {C}" +
                $"\nD = {D}";
        }

    }
}
