using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class IntUtil
    {
        private static Random random;

        private static void Init()
        {
            if (random == null)
                random = new Random();
        }

        //public static double Random()
        //{
        //    Init();
        //    return random.NextDouble();
        //}

        public static int Random(int max)
        {
            Init();
            return random.Next(max);
        }
    }
}
