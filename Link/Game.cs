using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Link
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Board_Move);
        }
        private bool insideBorder(int x, int y)
        {
            //Point[] map = new Point[];
            //getBoardBoarders();
            if (x > 230 || x < 10)
            {

                //locLabel.Text = link.Location.ToString();
                return false;
            }
            if (y > 160 || y < 10)
            {

                //locLabel.Text = link.Location.ToString();
                return false;
            }
            else
            {
                //locLabel.Text = link.Location.ToString();
                return true;
            }
        }
        private void Board_Move(object sender, KeyEventArgs e)
        {
            int Y = link.Location.Y;
            int X = link.Location.X;
            bool inside = true;
            inside = insideBorder(X,Y);
            if (e.KeyCode == Keys.W)
            {
                int walk = 0;
                walk++;
                if (walk%1==0)
                {
                    link.Image = Link.Properties.Resources.link_up1;
                    locLabel.Text = walk.ToString();
                    if (inside)
                        link.Location = new Point(X, Y - 5);
                    else
                        link.Location = new Point(X, Y + 5);
                }
                if (walk%1==1)
                {
                    link.Image = Link.Properties.Resources.link_down1;
                    locLabel.Text = walk.ToString();
                    if (inside)
                        link.Location = new Point(X, Y - 5);
                    else
                        link.Location = new Point(X, Y + 5);
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (inside)
                {
                    link.Location = new Point(X-5,Y);
                }
                else
                {
                    link.Location = new Point(X+5,Y);
                }

                link.Image = Link.Properties.Resources.link_left1;
            }
            if (e.KeyCode == Keys.S)
            {
                if (inside)
                {
                    link.Location = new Point(X,Y+5);
                }
                else
                {
                    link.Location = new Point(X,Y-5);
                }

                link.Image = Link.Properties.Resources.link_down1;
            }
            if (e.KeyCode == Keys.D)
            {
                if (inside)
                {
                    link.Location = new Point(X+5,Y);
                }
                else
                {
                    link.Location = new Point(X-5,Y);
                }
                link.Image = Link.Properties.Resources.link_right1;
            }
        }
        
        //private void map_Load()
        //{
        //    map[0] = new Point(0,210);
        //    map[1] = new Point(250, 210); 
        //    map[2] = new Point(500, 210);
        //    map[3] = new Point(750, 210);
        //    map[4] = new Point(1000, 210);
        //    map[5] = new Point(1250, 210);
        //    map[6] = new Point(1500, 210);
        //    map[7] = new Point(1750, 210);
        //    map[8] = new Point(2000, 210);
        //    map[9] = new Point(2250, 210);
        //    map[10] = new Point(2500, 210);
        //    map[11] = new Point(2750, 210);
        //    map[12] = new Point(3000, 210);
        //    map[13] = new Point(3250, 210);
        //    map[14] = new Point(3500, 210);
        //    map[15] = new Point(3750, 210);
        //    map[16] = new Point(4000, 210);
        //    map[17] = new Point(0, 420);
        //    map[18] = new Point(250, 420);
        //    map[19] = new Point(500, 420);
        //    map[20] = new Point(750, 420);
        //    map[21] = new Point(1000, 420);
        //    map[22] = new Point(1250, 420);
        //    map[23] = new Point(1500, 420);
        //    map[24] = new Point(1750, 420);
        //    map[25] = new Point(2000, 420);
        //    map[26] = new Point(2250, 420);
        //    map[27] = new Point(2500, 420);
        //    map[28] = new Point(2750, 420);
        //    map[29] = new Point(3000, 420);
        //    map[30] = new Point(3250, 420);
        //    map[31] = new Point(3500, 420);
        //    map[32] = new Point(3750, 420);
        //    map[33] = new Point(4000, 420);
        //    map[34] = new Point(0, 630);
        //    map[35] = new Point(250, 630);
        //    map[36] = new Point(500, 630);
        //    map[37] = new Point(750, 630);
        //    map[38] = new Point(1000, 630);
        //    map[39] = new Point(1250, 630);
        //    map[40] = new Point(1500, 630);
        //    map[41] = new Point(1750, 630);
        //    map[42] = new Point(2000, 630);
        //    map[43] = new Point(2250, 630);
        //    map[44] = new Point(2500, 630);
        //    map[45] = new Point(2750, 630);
        //    map[46] = new Point(3000, 630);
        //    map[47] = new Point(3250, 630);
        //    map[48] = new Point(3500, 630);
        //    map[49] = new Point(3750, 630);
        //    map[50] = new Point(4000, 630);
        //    map[51] = new Point(0, 840);
        //    map[52] = new Point(250, 840);
        //    map[53] = new Point(500, 840);
        //    map[54] = new Point(750, 840);
        //    map[55] = new Point(1000, 840);
        //    map[56] = new Point(1250, 840);
        //    map[57] = new Point(1500, 840);
        //    map[58] = new Point(1750, 840);
        //    map[59] = new Point(2000, 840);
        //    map[60] = new Point(2250, 840);
        //    map[61] = new Point(2500, 840);
        //    map[62] = new Point(2750, 840);
        //    map[63] = new Point(3000, 840);
        //    map[64] = new Point(3250, 840);
        //    map[65] = new Point(3500, 840);
        //    map[66] = new Point(3750, 840);
        //    map[67] = new Point(4000, 840);
        //    map[68] = new Point(0, 1050);
        //    map[69] = new Point(250, 1050);
        //    map[70] = new Point(500, 1050);
        //    map[71] = new Point(750, 1050);
        //    map[72] = new Point(1000, 1050);
        //    map[73] = new Point(1250, 1050);
        //    map[74] = new Point(1500, 1050);
        //    map[75] = new Point(1750, 1050);
        //    map[76] = new Point(2000, 1050);
        //    map[78] = new Point(2250, 1050);
        //    map[79] = new Point(2500, 1050);
        //    map[80] = new Point(2750, 1050);
        //    map[82] = new Point(3000, 1050);
        //    map[83] = new Point(3250, 1050);
        //    map[84] = new Point(3500, 1050);
        //    map[85] = new Point(3750, 1050);
        //    map[86] = new Point(4000, 1050);
        //    map[87] = new Point(0, 1260);
        //    map[88] = new Point(250, 1260);
        //    map[89] = new Point(500, 1260);
        //    map[90] = new Point(750, 1260);
        //    map[91] = new Point(1000, 1260);
        //    map[92] = new Point(1250, 1260);
        //    map[93] = new Point(1500, 1260);
        //    map[94] = new Point(1750, 1260);
        //    map[95] = new Point(2000, 1260);
        //    map[96] = new Point(2250, 1260);
        //    map[97] = new Point(2500, 1260);
        //    map[98] = new Point(2750, 1260);
        //    map[99] = new Point(3000, 1260);
        //    map[100] = new Point(3250, 1260);
        //    map[101] = new Point(3500, 1260);
        //    map[102] = new Point(3750, 1260);
        //    map[103] = new Point(4000, 1260);
        //    map[104] = new Point(0, 1470);
        //    map[105] = new Point(250, 1470);
        //    map[106] = new Point(500, 1470);
        //    map[107] = new Point(750, 1470);
        //    map[108] = new Point(1000, 1470);
        //    map[109] = new Point(1250, 1470);
        //    map[110] = new Point(1500, 1470);
        //    map[112] = new Point(1750, 1470);
        //    map[113] = new Point(2000, 1470);
        //    map[114] = new Point(2250, 1470);
        //    map[115] = new Point(2500, 1470);
        //    map[116] = new Point(2750, 1470);
        //    map[117] = new Point(3000, 1470);
        //    map[118] = new Point(3250, 1470);
        //    map[119] = new Point(3500, 1470);
        //    map[120] = new Point(3750, 1470);
        //    map[121] = new Point(4000, 1470);
        //}

        private void map_move()
        { 
            
        }
    }
}
