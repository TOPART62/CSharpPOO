namespace ExosPOOPile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pile de string
            Pile<string> stringPile = new Pile<string>();
            //Init Pile
            Console.WriteLine("=== Init de la pile ===");   
            stringPile.Empiler("turlututu");
            stringPile.Empiler("chapeau");
            stringPile.Empiler("pointu");
            stringPile.Empiler("!!!");
            stringPile.AffichagePile();

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
                        stringPile.Empiler(IHM.SaisirStringPile()); 
                        stringPile.AffichagePile();
                        break;

                    case 2: // Depiler
                        stringPile.Depiler();
                        stringPile.AffichagePile();
                        break;

                    case 3: // Récupérer à X
                        int intPosition = IHM.SaisirPositionPile();
                        string strValue = stringPile.Recuperer(intPosition);
                        if (intPosition < stringPile.NbElements)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nA la position {intPosition}, on a la valeur <{strValue}> !!! ");
                            Console.ResetColor();
                        }
                        else
                            Console.WriteLine("Il n'y a pas de valeur à cette position !!");
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice != 0);
        }
    }
}