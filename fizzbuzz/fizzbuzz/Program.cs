using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for ( i =1; i<= 100; i++)
            {

                Console.Write(i);

                if( i % 5 == 0 && i % 10 == 0)
                {
                    Console.Write (" FizzBuzz");
                }
                else if ( i % 10 == 0)
                {
                    Console.Write(" Buzz");
                }
                else if ( i% 5 == 0)
                {
                    Console.Write(" Fizz");

                }
                Console.WriteLine();
            }
        }

    }
}