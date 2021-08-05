using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "wealth";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;



            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {

                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;


                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You Win!");
            }




            Console.ReadLine();
        }
    }
}
