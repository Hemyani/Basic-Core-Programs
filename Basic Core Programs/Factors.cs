using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Factors
    {
        public static void Number()
        {
            int num, i;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors are the: ");
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}


