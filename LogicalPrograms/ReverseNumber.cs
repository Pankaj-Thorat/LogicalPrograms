using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int reversedNumber = 0;
            while (n != 0)
            {
                int remainder = n % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                n /= 10;
            }

            Console.WriteLine("Reversed number is: {0}", reversedNumber);
        }
    }
}
