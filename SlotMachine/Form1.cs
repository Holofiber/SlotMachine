﻿using System;
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
        public static long profit = 0;
        public static int bets = 5;

        public static int p1;
        public static int p2;
        public static int p3;



        private void Form1_Load(object sender, EventArgs e)
        {
            slot1.Image = Image.FromFile("Source/1.png");
            slot2.Image = Image.FromFile("Source/2.png");
            slot3.Image = Image.FromFile("Source/3.png");
        }

        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null)
                {
                    random = new Random();
                }
            }

            public static double Random()
            {
                Init();
                return random.NextDouble();
            }

            public static int Random(int max)
            {
                Init();
                return random.Next(max);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credits < bets) return;

            credits = credits - bets;
            textBox1.Text = credits.ToString();
            

            SetImagesAccordingToValue();

            profit = 0;

            CalculateProfit();

            credits = credits + profit;
            textBox3.Text = profit.ToString();
            textBox1.Text = credits.ToString();
        }

        private static void CalculateProfit()
        {
            if (p1 == 3) profit = profit + 5;
            if (p1 == 2 & p2 == 2) profit = profit + 10;
            if (p1 == 3 & p2 == 3) profit = profit + 10;
            if (p1 == 3 & p2 == 3 & p3 == 3) profit = profit + 20;
            if (p1 == 2 & p2 == 2 & p3 == 2) profit = profit + 30;
            if (p1 == 1 & p2 == 1 & p3 == 1) profit = profit + 50;
        }

        private void SetImagesAccordingToValue()
        {
            p1 = GetRandomImageNumber();
            p2 = GetRandomImageNumber();
            p3 = GetRandomImageNumber();


            SetImageAccordingToValue(slot1, p1);
            SetImageAccordingToValue(slot2, p2);
            SetImageAccordingToValue(slot3, p3);
        }

        private int GetRandomImageNumber()
        {
            int random = IntUtil.Random(100);

            if (random < 25)
            {
                return 1;
            }
            else if (random < 70)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void SetImageAccordingToValue(PictureBox pictureBox, int pictureNumber)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = Image.FromFile("Source/" + pictureNumber + ".png");
            }
        }
    }
}
