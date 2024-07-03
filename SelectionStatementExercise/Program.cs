namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 22;
            Console.WriteLine("Guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber) { Console.WriteLine("Good guess, but too low."); }
            else if (userInput > favNumber) { Console.WriteLine("Sorry, too high."); }
            else if (userInput == favNumber) { Console.WriteLine("You guessed it!"); }
        }
    }
}
