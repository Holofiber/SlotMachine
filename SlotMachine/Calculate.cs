using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NLog;

namespace SlotMachine
{
    public class Calculate
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();

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
            Logger.Trace("set image and bets" + bets);

            this.slotP1 = slotP1;
            this.slotP2 = slotP2;
            this.slotP3 = slotP3;
            this.bets = bets;

            Logger.Trace("ok");
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
                    if (image == image3) CalculateProfit(3);
                    else if (image == image2) CalculateProfit(4);
                    else if (image == image1) CalculateProfit(5);
                    else if (image == image7) CalculateProfit(1000);
                    return;
                }
                else if (count == 2 && (image == image2 || image == image3))
                {
                    CalculateProfit(2);
                    return;
                }
                else if (count == 1 && image == image3 )
                {
                    CalculateProfit(1);
                    return;
                }
            }

            Logger.Trace("Calcalate profit" + Profit);
        }

        public long CalculateProfit(int cof)
        {
            return Profit = Profit + bets * cof;
        }
    }
}