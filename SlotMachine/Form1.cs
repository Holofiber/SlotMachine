using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SlotMachine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        public long credits = 100;
        public int bets = 5;
        public int slotPicture1;
        public int slotPicture2;
        public int slotPicture3;
        public int slotPicture4;
        public Stack<string> StatisticStack = new Stack<string>();
        private int imagesP1;
        private int imagesP2;
        private int imagesP3;
        private long yourprofit;
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            pbSlot1.Image = Image.FromFile("Source/1.png");
            pbSlot2.Image = Image.FromFile("Source/1.png");
            pbSlot3.Image = Image.FromFile("Source/1.png");
        }

      
        private void btnSpin_Click(object sender, EventArgs e)
        {
            try
            {
                bets = Convert.ToInt32(tbBet.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("wrong enter number");
                return;
            }

            if ((credits < bets) || (bets <= 0))
            {
                MessageBox.Show("Check your Bet");
                return;
            }
            
            credits = credits - bets;
            tbCredit.Text = credits.ToString();

            SetRandomImages setImages = new SetRandomImages(slotPicture1, slotPicture2, slotPicture3,
                pbSlot1, pbSlot2, pbSlot3);

            setImages.SetImagesAccordingToValue();
            imagesP1 = setImages.P1;
            imagesP2 = setImages.P2;
            imagesP3 = setImages.P3;
            
            Calculate calculateProfit = new Calculate(imagesP1, imagesP2, imagesP3, bets);
           
            calculateProfit.CalculateProfit();
            
            var profit = calculateProfit.Profit;
            
            credits = credits + profit;
            tbWin.Text = profit.ToString(); 
            tbCredit.Text = credits.ToString();
            yourprofit = profit;
            HistoryBox();

            tbWin.Focus();
            tbWin.TabIndex = 1;
        }

        private void HistoryBox()
        {
            StatisticStack.Push(yourprofit.ToString());
            tbStatistic.Clear();
            foreach (var history in StatisticStack)
            {
                tbStatistic.AppendText($"\n{history}\t");
            }
        }
        
        private void tbBet_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddCredit_Click(object sender, EventArgs e)
        {
            credits = credits + 100;
            tbCredit.Text = credits.ToString();
        }
    }
}