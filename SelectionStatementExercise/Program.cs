namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number between 1 and 1000");

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {

                Console.Write("Enter your guess: ");
                int userInput;

                //I'm still trying to get why Tryparse is even needed
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write("Enter your guess: ");
                }

                //if statements are objectively my favorite thing to do in C# so far
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high, try again!");
                }
                else
                {
                    Console.WriteLine($"You guessed it!!! My favorite number was {favNumber}.");
                    guessedCorrectly = true;
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
