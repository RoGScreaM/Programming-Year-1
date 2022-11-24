using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n*****Example 1*****\n");

            //for(int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("The value of i is {0}", i);
            //}

            /* Console.WriteLine("\n*****Example 2*****\n");

             for (int i = 10; i >= 0; i--)
             {
                 Console.WriteLine("The value of i is {0}", i);
             }
            */

            /*
            Console.WriteLine("\n*****Example 3*****\n");

            for (int i = 20; i > 0; i-=2)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
            (THE ABOVE EXAMPLES ARE IF U USE AN INT)
            */

            /*
            Console.WriteLine("\n*****Example 4*****\n");

            String name = "Chetan c";
            for(int i = 0; i < name.Length;i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            */

            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year", year);

            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
         


            Console.ReadLine();
        }
    }
}
