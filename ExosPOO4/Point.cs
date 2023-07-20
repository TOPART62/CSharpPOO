using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO4
{
    internal class Point : IDeplacable
    {
        //attributs & Propriétés
        public double X { get; set; }    
        public double Y { get; set; }

        //Constructeurs
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Méthodes
        public override string ToString()
        {
            //return base.ToString();
            return $"{X};{Y}";
        }
        public void Deplacement(double x, double y)
        {
            X += x;  
            Y += y;
        }

    }
}
