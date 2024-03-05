namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            int gamePlay = int.Parse(Console.ReadLine());

            while (gamePlay == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Game Loading...");
                int menuOptions = int.Parse(Console.ReadLine());
            }
            while (gamePlay == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Choose which file you wanna play: ");
                int menuOptions = int.Parse(Console.ReadLine());
            }
            while (gamePlay == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Audio");
                Console.WriteLine("Graphics");
                Console.WriteLine("Character Layers");
                Console.WriteLine("Visuals");
                int menuOptions = int.Parse(Console.ReadLine());
            }
            while (gamePlay == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Are you sure you wanna close this application? 1/0?");
                gamePlay = int.Parse(Console.ReadLine());
            } 
        }
    }
}