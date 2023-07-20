using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO4
{
    internal class Triangle : Figure
    {
        // On considerera tout triangle isocèle
        /*         
         *                  A               
         * 
         * 
         * hauteur
         * 
         * 
         *          C               B
         *          <-    base     ->
         */

        // Attributs & Propriétés
        public double Base { get; set; }
        public double Hauteur{ get; set; }

        public Point B { get => new Point(A.X + (Base/2), A.Y - Hauteur); }
        public Point C => new Point(A.X + -(Base/2), A.Y - Hauteur);

        // Constructeur 
        public Triangle(Point a, double dlbBase, double dblHauteur) : base(a)
        {
            this.Base = dlbBase;
            this.Hauteur = dblHauteur;
        }
        public Triangle(double x, double y, double dlbBase, double dblHauteur) : base(x, y)
        {
            this.Base = dlbBase;
            this.Hauteur = dblHauteur;
        }

        //Méthodes
        public override string ToString()
        {
            //return base.ToString();
            return $"Triangle ABC de base {Base} et de Hauteur {Hauteur}" +
                $"\nA = {A}" +
                $"\nB = {B}" +
                $"\nC = {C}";
        }
    }
}
