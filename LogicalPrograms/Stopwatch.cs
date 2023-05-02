using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Stopwatch
    {
        public static void GetTimestamp() 
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch...");
            Console.ReadKey();

            DateTime stopTime = DateTime.Now;
            TimeSpan elapsedTime = stopTime - startTime;

            Console.WriteLine("Elapsed time is: " + elapsedTime);
        }
    }
}
