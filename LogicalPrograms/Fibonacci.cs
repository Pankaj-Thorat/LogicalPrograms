using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public static void FibonacciSeries()
        {
            int sum = 0;
            int a= 0;
            int b = 1;
            for (int i = 0;  i< 10; i++)
            {
                sum = a + b ;
                a = b;
                b = sum;
                
                Console.WriteLine(sum);
            }
            
        }

    }
}
