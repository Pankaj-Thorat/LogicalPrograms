using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your Program");
            Console.WriteLine("1.Fibonacci Series \n2.Perfect Number \n3.Prime Number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Fibonacci.FibonacciSeries(); break;
                case 2:
                    PerfectNumber.GetPerffectNumber(); break;
                case 3:
                    PrimeNumber.GetPrimeNumber(); break;
                default: Console.WriteLine("Try again, Please enter valid input!"); break;
            }
                
        }
    }
}
