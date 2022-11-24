using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class EvenOrOdd
    {
        public static void EvenOdd()
        {

            // declare variable
            int n;

            //take input
            Console.Write("Enter the number = ");
            n = Convert.ToInt32(Console.ReadLine());

            //check if n is even or odd
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");

            // wait for user to press any key
            Console.ReadKey();
        }
    }
}

