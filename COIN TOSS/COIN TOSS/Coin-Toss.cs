using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COIN_TOSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*****COIN TOSS*****");

            string guess;
            int ran; 
            string result;

            Random r = new Random();
            ran = r.Next(1,3);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\nEnter heads or tails: ");
            guess = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;


            if (ran == 1 && guess == "heads")
            {
                Console.WriteLine("\nWell done you win , the flip was \"heads\"");
            }
            else if(ran==2 && guess=="tails")
            {
                Console.WriteLine("\nWell done you win , the flip was \"tails\"");
            }
            else
            {
                if(ran == 1)
                {
                    result = "heads";
                }
                else
                {
                    result = "tails";
                }
                Console.WriteLine("\nThe toss was {0} , better luck next time", result);

            }








            Console.ReadLine();
        }
    }
}
