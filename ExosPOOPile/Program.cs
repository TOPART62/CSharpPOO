namespace ExosPOOPile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pile de string
            Pile<string> stringPile = new Pile<string>();

            int intUserChoice = 0;
            do
            {
                intUserChoice = IHM.StartMenuPrincipal();
                switch (intUserChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1: // Empiler
                        stringPile.Empiler("turlututu");
                        stringPile.Empiler("chapeau");
                        stringPile.Empiler("pointu");
                        stringPile.Empiler("!!!");
                        stringPile.AfficherPile();
                        break;

                    case 2: // Depiler
                        break;

                    case 3: // Récupérer à X
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice != 0);
        }
    }
}