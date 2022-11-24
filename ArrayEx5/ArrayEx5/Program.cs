using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***** Top Players *****");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the No of Players: ");
            int size = int.Parse(Console.ReadLine());

            string[] players = new string[size];
            int[] goals = new int[size];

            Console.WriteLine("***************");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0;i < size; i++)
            {
                Console.Write("\nEnter the player name: ");
                players[i] = Console.ReadLine();
                Console.Write("\nHow many goals has {0} scored: ", players[i]);
                goals[i] = int.Parse(Console.ReadLine());

            }
                

                Console.WriteLine("\n**************\n");
                Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < size; i++)
               {
                Console.WriteLine("{0} has scored {1} goals",players[i],goals[i]);
               }




            Console.ReadLine();

        }
    }
}
