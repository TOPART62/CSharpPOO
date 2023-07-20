namespace ExosPOO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carre carre = new(2,4,2);
            Console.WriteLine(carre);
            /*
            Rectangle rectangle = new(2, 4, 3, 5);
            Console.WriteLine(rectangle);

            Triangle triangle = new(2, 4, 4, 5);
            Console.WriteLine(triangle);
            */
            //Deplacement du carré
            carre.Deplacement(1, 3);
            Console.WriteLine("\n" + carre);
        }
    }
}