using System;
using System.Collections.Generic;
using System.Text;

namespace Week2
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                int secret = RandomNumber(1, 100);
                do
                {
                    
                    int guess = Utils.GetNumber("Enter number between 1 and 100: ", 100);
                    int highOrLow = PlayGame(secret, guess);

                    if (highOrLow == 0)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too " + (highOrLow == 1 ? "High" : "Low"));
                    }

                } while (true);
                response = Utils.GetInput("Want a new game? ");
            } while (! response.Equals("N"));
        }
        static int PlayGame(int secret, int guess)
        {
            return (secret == guess) ? 0 : (guess < secret) ? -1 : 1;
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

       
    }
}
