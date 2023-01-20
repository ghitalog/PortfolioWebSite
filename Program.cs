using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing
{
    class Program3123
    {
        const int range = 100;
        static void Main(string[] args)
        {
            bool keePlaying = true;
            do
            {
                Random randomNumberGenerator = new Random();
                int realNumber = randomNumberGenerator.Next(range);
                //Console.Write("Please guess a number between 0 and: ", range);
                int guess = readIntFromConsole("Please guess a number between 0 and " + (range - 1) + ": ");
                int amountGueess = 1;

                while (guess != realNumber)
                {
                    amountGueess++;
                    //Console.WriteLine("You guessed wrong, try something {0}: ", guess > realNumber ? "Lower" : "Higher");
                    //guess = Convert.ToInt32(Console.ReadLine());
                    guess = readIntFromConsole("You guessed wrong, try something : " + (guess > realNumber ? "Lower" : "Higher") + ": ");
                }
                Console.WriteLine("You guessed right, it took you {0}", amountGueess);
                Console.WriteLine("Do you want to play again (y/n): ");
                string playOption = Console.ReadLine();

                if (playOption.ToLower().Contains("n"))
                {
                    keePlaying = false;
                }


            } while (keePlaying);
            Console.WriteLine("Thank you for playing this game.");


            Console.ReadLine();
        }
        public static int readIntFromConsole(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

    }

}



