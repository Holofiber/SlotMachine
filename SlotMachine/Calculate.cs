using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
   public class Calculate
    {
        
        public long Profit { get; private set; }
        private readonly int imagesP1;
        private readonly int imagesP2;
        private readonly int imagesP3;
        private readonly int bets;
        

        public Calculate(int imagesP1, int imagesP2, int imagesP3, int bets)
        {
            this.imagesP1 = imagesP1;
            this.imagesP2 = imagesP2;
            this.imagesP3 = imagesP3;
            this.bets = bets;

        }
        private int image1 = 1;
        private int image2 = 2;
        private int image3 = 3;
        private int image7 = 7;


        public void CalculateProfit()
        {
            
            if (imagesP1 == image3 & imagesP2 == image3 & imagesP3 == image3)
            {
                Profit = Profit + bets * 3;
            }
            else if (imagesP1 == image2 & imagesP2 == image2 & imagesP3 == image2)
            {
                Profit = Profit + bets * 4;
            }
            else if (imagesP1 == image1 & imagesP2 == image1 & imagesP3 == image1)
            {
                Profit = Profit + bets * 5;
            }
            else if ((imagesP1 == image2 & imagesP2 == image2) || (imagesP1 == image2) & (imagesP3 == image2) || (imagesP2 == 2) & (imagesP3 == image2))
            {
                Profit = Profit + bets * 2;
            }
            else if ((imagesP1 == image3 & imagesP2 == image3) || (imagesP1 == image3 & imagesP3 == image3) || (imagesP2 == image3) & (imagesP3 == image3))
            {
                Profit = Profit + bets * 2;
            }
            else if ((imagesP1 == image3) || (imagesP2 == image3) || (imagesP3 == image3))
            {
                Profit = Profit + bets;
            }
            else if (imagesP1 == image7 & imagesP2 == image7 & imagesP3 == image7)
            {
                Profit = Profit + bets * 1000;
            }

            

        }
    }
}
