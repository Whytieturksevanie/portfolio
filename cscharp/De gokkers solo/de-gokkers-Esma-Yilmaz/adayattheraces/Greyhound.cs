using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adayattheraces
{
    class Greyhound
    {
        public int StartingPostion { get; set; }
        public int RacetrackLength { get; set; }
        public PictureBox MypictureBox { get; set; }
        public Random Randomizer { get; set; }

        public Greyhound(PictureBox MypictureBox)
        {
            this.MypictureBox = MypictureBox;
        }

        public bool Run()
        {
            Point p = MypictureBox.Location;
            int distance = Randomizer.Next(1,5);
            p.X += distance;
            MypictureBox.Location = p;

            if (p.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public void TakeStartingPosition()
        {
            Point p = MypictureBox.Location;
            p.X = StartingPostion;
            MypictureBox.Location = p;
        }
    }
}
