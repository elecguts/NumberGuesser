using System;

namespace NumberGuesser
{
    class Program
    {
        static int formulateNewUpperLimit(int guess)
        {
            //sets the upper limit of guessing to just below the last guess
            var newUpperLimit = guess - 1;
            return newUpperLimit;
        }
        static int formulateNewLowerLimit(int guess)
        {
            //sets the lower limit of guessing to just above the last guess
            var newLowerLimit = guess + 1;
            return newLowerLimit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Please think of a number in your head between 1 and 1024.");
            Console.WriteLine("When I guess a number, type in whether your number is higher, lower, or if I'm correct.");

            var correctGuess = false;
            var lowerLimit = 1;
            var upperLimit = 1024;

            //main loop that sets and resets the guessing boundaries until the user's number is found
            while (correctGuess == false)
            {
                var guess = ((upperLimit + lowerLimit + 1) / 2);
                Console.Write($"Is your number {guess}? ");
                var userInput = Console.ReadLine();
                if (userInput == "correct")
                {
                    Console.WriteLine("I got it!");
                    correctGuess = true;
                }
                else if (userInput == "higher")
                {
                    lowerLimit = formulateNewLowerLimit(guess);
                }
                else if (userInput == "lower")
                {
                    upperLimit = formulateNewUpperLimit(guess);
                }
                else
                {
                    Console.WriteLine("Please respond with higher, lower, or correct.");
                }
            }
        }
    }
}
