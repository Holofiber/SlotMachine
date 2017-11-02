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

   
        public void CalculateProfit()
        {
            
            if (imagesP1 == 3 & imagesP2 == 3 & imagesP3 == 3)
            {
                Profit = Profit + bets * 3;
            }
            else if (imagesP1 == 2 & imagesP2 == 2 & imagesP3 == 2)
            {
                Profit = Profit + bets * 4;
            }
            else if (imagesP1 == 1 & imagesP2 == 1 & imagesP3 == 1)
            {
                Profit = Profit + bets * 5;
            }
            else if ((imagesP1 == 2 & imagesP2 == 2) || (imagesP1 == 2) & (imagesP3 == 2) || (imagesP2 == 2) & (imagesP3 == 2))
            {
                Profit = Profit + bets * 2;
            }
            else if ((imagesP1 == 3 & imagesP2 == 3) || (imagesP1 == 3 & imagesP3 == 3) || (imagesP2 == 3) & (imagesP3 == 3))
            {
                Profit = Profit + bets * 2;
            }
            else if ((imagesP1 == 3) || (imagesP2 == 3) || (imagesP3 == 3))
            {
                Profit = Profit + bets;
            }
        }
    }
}
