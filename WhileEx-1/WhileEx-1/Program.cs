using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****3 DIGIT NUMBER*****");

            int num = 0;

            do
            {
                Console.Write("Enter 3 digit number: ");
                num = int.Parse(Console.ReadLine());

                if (num < 100 || num > 999)
                {

                    Console.WriteLine("Invalid number press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (num < 100 || num > 999);
            Console.WriteLine("\n\nCorrect your number is {0}", num);
            Console.WriteLine("I am out of loop");

            Console.ReadLine();


            















        }
    }
}
