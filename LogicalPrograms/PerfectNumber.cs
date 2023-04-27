using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void GetPerffectNumber()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("{0} is a perfect number.", n);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number.", n);
            }
        }
    }
}
