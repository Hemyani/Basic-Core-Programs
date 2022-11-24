using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class MaximumNum
    {
        public static void MaxNum()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}