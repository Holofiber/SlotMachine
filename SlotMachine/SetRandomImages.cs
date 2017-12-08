using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;


namespace SlotMachine
{
    public  class SetRandomImages
    {
        public static Logger log = LogManager.GetCurrentClassLogger();

        Image image1 = Image.FromFile("Source/1.png");
        Image image2 = Image.FromFile("Source/2.png");
        Image image3 = Image.FromFile("Source/3.png");
     //   Image image4 = Image.FromFile("Source/4.png");
        Image image7 = Image.FromFile("Source/7.png");

        public int P1 { get; private set; }
        public int P2 { get; private set; }
        public int P3 { get; private set; }

        private readonly PictureBox slot1;
        private readonly PictureBox slot2;
        private readonly PictureBox slot3;

        public void SetImagesAccordingToValue()
        {
            P1 = GetRandomImageNumber();
            P2 = GetRandomImageNumber();
            P3 = GetRandomImageNumber();
            
            SetImageAccordingToValue(slot1, P1);
            SetImageAccordingToValue(slot2, P2);
            SetImageAccordingToValue(slot3, P3);
        }
        
        public SetRandomImages(int p1, int p2, int p3, 
            PictureBox slot1, PictureBox slot2, PictureBox slot3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.slot1 = slot1;
            this.slot2 = slot2;
            this.slot3 = slot3;
        }
        
        private int GetRandomImageNumber()
        {
            int random = SlotMachine.IntUtil.Random(100);

            log.Debug("random image is " + random);

            if (random < 20)
            {
                return 1;
            }
            else if (random < 40)
            {
                return 2;
            }
            else if (random > 40 & random < 60)
            {
                return 3;
            }
            else if (random > 60 & random < 95)
            {
                return 4;
            }
            else
            {
                return 7;
            }

            
        }
        private void SetImageAccordingToValue(PictureBox pictureBox, int pictureNumber)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();

                if ( pictureNumber==1)
                {
                    pictureBox.Image = image1;
                }
                else if (pictureNumber==2)
                {
                    pictureBox.Image = image2;
                }
                else if (pictureNumber == 3)
                {
                    pictureBox.Image = image3;
                }
              //  else if (pictureNumber == 4)
               // {
             //       pictureBox.Image = image4;
              //  }
                else if (pictureNumber == 7)
                {
                    pictureBox.Image = image7;
                }
            }
        }
    }
}
