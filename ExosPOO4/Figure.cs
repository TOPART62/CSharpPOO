using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosPOO4
{
    internal abstract class Figure
    {
        public Point A { get; private set; }

        protected Figure(Point a)
        {
            A = a;
        }
        protected Figure(double x, double y) 
        { 
            A = new Point(x, y);
        }

        public void Deplacement(double x, double y)
        {
            Console.WriteLine($"\nDéplacement {this.GetType().ToString().Split('.', 2)} de ({x},{y})");
            A.X += x;
            A.Y += y;
        }
    }
}
