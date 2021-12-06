using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenSegmentClock
{
    public partial class Form1 : Form
    {
        Color On = Color.Red;
        Color Off = Color.Gainsboro;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string seconds = DateTime.Now.ToString("ss");

            int secondsOnes = Convert.ToInt32(seconds.Substring(1));
            int secondsTens = Convert.ToInt32(seconds.Remove(1, 1));

            txtBoxCheckTime.Text = seconds;

            sevenSegment(secondsOnes, "Ones");
            sevenSegment(secondsTens, "Tens");
        }

        private void sevenSegment(int num, string indicator)
        {
            if (indicator == "Ones")
            {
                switch (num)
                {
                    case 0:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = On;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = Off;
                        break;

                    case 1:
                        btnSec1A.BackColor = Off;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = Off;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = Off;
                        btnSec1G.BackColor = Off;
                        break;

                    case 2:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = Off;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = On;
                        btnSec1F.BackColor = Off;
                        btnSec1G.BackColor = On;
                        break;

                    case 3:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = Off;
                        btnSec1G.BackColor = On;
                        break;

                    case 4:
                        btnSec1A.BackColor = Off;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = Off;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = On;
                        break;

                    case 5:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = Off;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = On;
                        break;

                    case 6:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = Off;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = On;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = On;
                        break;

                    case 7:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = Off;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = Off;
                        btnSec1G.BackColor = Off;
                        break;

                    case 8:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = On;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = On;
                        break;

                    case 9:
                        btnSec1A.BackColor = On;
                        btnSec1B.BackColor = On;
                        btnSec1C.BackColor = On;
                        btnSec1D.BackColor = On;
                        btnSec1E.BackColor = Off;
                        btnSec1F.BackColor = On;
                        btnSec1G.BackColor = On;
                        break;
                }
            }
            else if (indicator == "Tens")
            {
                switch (num)
                {
                    case 0:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = On;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = Off;
                        break;

                    case 1:
                        btnSec2A.BackColor = Off;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = Off;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = Off;
                        btnSec2G.BackColor = Off;
                        break;

                    case 2:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = Off;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = On;
                        btnSec2F.BackColor = Off;
                        btnSec2G.BackColor = On;
                        break;

                    case 3:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = Off;
                        btnSec2G.BackColor = On;
                        break;

                    case 4:
                        btnSec2A.BackColor = Off;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = Off;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = On;
                        break;

                    case 5:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = Off;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = On;
                        break;

                    case 6:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = Off;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = On;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = On;
                        break;

                    case 7:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = Off;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = Off;
                        btnSec2G.BackColor = Off;
                        break;

                    case 8:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = On;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = On;
                        break;

                    case 9:
                        btnSec2A.BackColor = On;
                        btnSec2B.BackColor = On;
                        btnSec2C.BackColor = On;
                        btnSec2D.BackColor = On;
                        btnSec2E.BackColor = Off;
                        btnSec2F.BackColor = On;
                        btnSec2G.BackColor = On;
                        break;
                }
            }
        }
    }
}
