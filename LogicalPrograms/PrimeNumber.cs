using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
   class PrimeNumber
    {
        public static void GetPrimeNumber()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && n > 1)
            {
                Console.WriteLine("{0} is a Prime number.", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime number.", n);
            }
        }
    }
}
