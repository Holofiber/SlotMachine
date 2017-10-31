using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDixtiDictionary = new ConcurrentDictionary<string, string>();
            
             var random = new Random();

            for (int j = 0; j < 200; j++)
            {
                var rnd = random.NextDouble();
                if (rnd < 7)
                {
                    Console.WriteLine("{0:F2} +", rnd);
                }
                else if (rnd > 9)
                {
                    Console.WriteLine(rnd);
                }
                else 
                {
                    Console.WriteLine("{0:F2} -", rnd);
                }
                

            }
           // Console.Write(" {0:F2} ", random.NextDouble());
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
