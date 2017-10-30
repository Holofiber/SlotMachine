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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static long credits = 100;
        public static long total = 0;
        public static int bets = 5;

        public static int p1;
        public static int p2;
        public static int p3;



        private void Form1_Load(object sender, EventArgs e)
        {
            slot1.Image = Image.FromFile("1.png");
            slot2.Image = Image.FromFile("2.png");
            slot3.Image = Image.FromFile("3.png");
        }

        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }

            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credits >= bets)
            {
                credits = credits - bets;
                textBox1.Text = credits.ToString();

                for (var i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 4);
                    p2 = IntUtil.Random(1, 4);
                    p3 = IntUtil.Random(1, 4);

                }

                if (slot1.Image != null)
                {
                    slot1.Image.Dispose();
                    slot1.Image = Image.FromFile(p1.ToString() + ".png");
                }
                if (slot2.Image != null)
                {
                    slot2.Image.Dispose();
                    slot2.Image = Image.FromFile(p2.ToString() + ".png");
                }
                if (slot3.Image != null)
                {
                    slot3.Image.Dispose();
                    slot3.Image = Image.FromFile(p3.ToString() + ".png");
                }

                total = 0;

                if (p1 == 3) total = total + 5;
                if (p1 == 2 & p2 == 2) total = total + 10;
                if (p1 == 3 & p2 == 3) total = total + 10;
                if (p1 == 3 & p2 == 3 & p3 ==3) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 ==2) total = total + 30;
                if (p1 == 1 & p2 == 1 & p3 ==1) total = total + 50;

                credits = credits + total;
                textBox3.Text = total.ToString();
                textBox1.Text = credits.ToString();


            }
        }
    }
}
