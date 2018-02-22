using System.Collections.Generic;
using System.Linq;
using NLog;

namespace SlotMachine
{
    public class Calculate
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public long Profit { get; private set; }
        private readonly int slotP1;
        private readonly int slotP2;
        private readonly int slotP3;
        private readonly int bets;

        private readonly int image1 = 1;
        private readonly int image2 = 2;
        private readonly int image3 = 3;
        private readonly int image7 = 7;

        public Calculate(int slotP1, int slotP2, int slotP3, int bets)
        {
            logger.Trace("set image and bets" + bets);

            this.slotP1 = slotP1;
            this.slotP2 = slotP2;
            this.slotP3 = slotP3;
            this.bets = bets;

            var slotList = new List<int> {slotP1, slotP2, slotP3};

            logger.Trace("ok");
        }

        public void CalculateProfit()
        {
            var slotList = new List<int> {slotP1, slotP2, slotP3};
            var imageList = new List<int> {image1, image2, image3, image7};

            foreach (var image in imageList)
            {
                var count = slotList.Count(item => item == image);
                if (count == 3)
                {
                    if (image == image3) Profit = Profit + bets * 3;
                    else if (image == image2) Profit = Profit + bets * 4;
                    else if (image == image1) Profit = Profit + bets * 5;
                    else if (image == image7) Profit = Profit + bets * 1000;
                    return;
                }
            }


            if (count == 2)
            {
                if (image == image2 || image == image3)
                {
                    Profit = Profit + bets * 2;
                    return;
                }
            }

            else if (count == 1)
            {
                if (image == image3)
                {
                    Profit = Profit + bets;
                    return;
                }
            }


            /*if (slotP1 == image3 & slotP2 == image3 & slotP3 == image3)
            {
                Profit = Profit + bets * 3;
            }
            else if (slotP1 == image2 & slotP2 == image2 & slotP3 == image2)
            {
                Profit = Profit + bets * 4;
            }
            else if (slotP1 == image1 & slotP2 == image1 & slotP3 == image1)
            {
                Profit = Profit + bets * 5;
            }
            else if ((slotP1 == image2 & slotP2 == image2) || (slotP1 == image2) & (slotP3 == image2) || (slotP2 == 2) & (slotP3 == image2))
            {
                Profit = Profit + bets * 2;
            }
            else if ((slotP1 == image3 & slotP2 == image3) || (slotP1 == image3 & slotP3 == image3) || (slotP2 == image3) & (slotP3 == image3))
            {
                Profit = Profit + bets * 2;
            }
            else if (slotP1 == image3 || slotP2 == image3 || slotP3 == image3)
            {
                Profit = Profit + bets;
            }
             else if (slotP1 == image7 & slotP2 == image7 & slotP3 == image7)
             {
                 Profit = Profit + bets * 1000;
             }*/

            logger.Trace("Calcalate profit" + Profit);
        }
    }
}