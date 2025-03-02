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

                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write("Enter your guess: ");
                }

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

            Console.WriteLine("\nNow, let's talk about school subjects.");
            Console.Write("What is your favorite school subject? ");
            string favoriteSubject = Console.ReadLine().Trim().ToLower();

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math is cool. That's also my favorite!");
                    break;
                case "science":
                    Console.WriteLine("I always found science to be fascinating! It helps us understand the world around us.");
                    break;
                case "history":
                    Console.WriteLine("History is extremely important! It teaches us how we got where we are, and why we live the way we do.");
                    break;
                case "english":
                    Console.WriteLine("English is great for expressing thoughts and creativity.");
                    break;
                case "art":
                    Console.WriteLine("Art allows creativity to flourish in amazing ways!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    string userResponse = Console.ReadLine();
                    Console.WriteLine($"That's a plausible reason");
                    break;
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
