using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("*****GUESS A NUMBER*****\n");

            Random ran = new Random();
            int secret = ran.Next(1, 10);
            int guess;
            int counter = 0;


            do
            {
                Console.Write("Guess a number from 1 to 9: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("Well done you are correct\n");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Wrong you are too low\n");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Wrong you are too high\n");
                }

                counter++;
                Console.WriteLine("You have used {0} of 3 chances\n",counter);
            }
            while (guess != secret && counter < 3);
            Console.WriteLine("\nBetter luck next time");
            Console.WriteLine("\nThe number was {0}",secret);



            Console.ReadLine();
        }
    }
}
