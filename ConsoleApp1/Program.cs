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
            int k=1, m=1;

            Dictionary<int, int> statsticDictionary = new Dictionary<int, int>();
            for (int i = 0; i<10; i++)
            {
                statsticDictionary.Add(k, m);
                statsticDictionary.Add(2,2);
                k = k + 1;
                m = m++;
                foreach (var statistic in statsticDictionary)
                {
                    Console.WriteLine("{0}  {1}", statistic.Key, statistic.Value);
                }
            }
            Console.WriteLine();

            var myDixtiDictionary = new ConcurrentDictionary<string, string>();
            
             var random = new Random();

            //for (int j = 0; j < 200; j++)
            //{
            //    var rnd = random.NextDouble();
            //    if (rnd < 7)
            //    {
            //        Console.WriteLine("{0:F2} +", rnd);
            //    }
            //    else if (rnd > 9)
            //    {
            //        Console.WriteLine(rnd);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("{0:F2} -", rnd);
            //    }
                

            //}
           // Console.Write(" {0:F2} ", random.NextDouble());
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
