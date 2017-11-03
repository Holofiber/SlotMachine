using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SlotMachine
{
  public  class SetRandomImages
    {
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
                pictureBox.Image = Image.FromFile("Source/" + pictureNumber + ".png");
            }
        }

    }
}
