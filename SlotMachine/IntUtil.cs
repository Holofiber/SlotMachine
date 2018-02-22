using System;

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

        public static int Random(int max)
        {
            Init();
            return random.Next(max);
        }
    }
}
