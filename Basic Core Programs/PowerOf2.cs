using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class PowerOf2
    {
        public static void Power()
        {
            int Base, Power, Result = 1;
            Console.WriteLine("Enter the Base");
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power");
            Power = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Power; i++)
            {
                Result = Result * Base;
            }
            Console.WriteLine("Result of Base {0} and Power {1} is {2}", Base, Power, Result);
            Console.ReadKey();
        }
    }
}