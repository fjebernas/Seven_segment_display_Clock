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
        Color Off = ColorTranslator.FromHtml("#272626");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string seconds = DateTime.Now.ToString("ss");
            labelTime.Text = seconds;

            int secondsOnes = Convert.ToInt32(seconds.Substring(1));
            int secondsTens = Convert.ToInt32(seconds.Remove(1, 1));

            string minutes = DateTime.Now.ToString("mm");
            labelMinutes.Text = minutes;

            int minutesOnes = Convert.ToInt32(minutes.Substring(1));
            int minutesTens = Convert.ToInt32(minutes.Remove(1, 1));


            sevenSegment(secondsOnes, "Seconds", "Ones");
            sevenSegment(secondsTens, "Seconds", "Tens");

            sevenSegment(minutesOnes, "Minutes", "Ones");
            sevenSegment(minutesTens, "Minutes", "Tens");
        }

        private void sevenSegment(int num, string indicator, string placeValue)
        {
            switch (indicator)
            {
                case "Seconds":
                    switch (placeValue)
                    {
                        case "Ones":
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
                            break;

                        case "Tens":
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
                            break;
                    }
                    break;

                case "Minutes":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = On;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = Off;
                                    break;

                                case 1:
                                    btnMin1A.BackColor = Off;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = Off;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = Off;
                                    btnMin1G.BackColor = Off;
                                    break;

                                case 2:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = Off;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = On;
                                    btnMin1F.BackColor = Off;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 3:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = Off;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 4:
                                    btnMin1A.BackColor = Off;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = Off;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 5:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = Off;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 6:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = Off;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = On;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 7:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = Off;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = Off;
                                    btnMin1G.BackColor = Off;
                                    break;

                                case 8:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = On;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = On;
                                    break;

                                case 9:
                                    btnMin1A.BackColor = On;
                                    btnMin1B.BackColor = On;
                                    btnMin1C.BackColor = On;
                                    btnMin1D.BackColor = On;
                                    btnMin1E.BackColor = Off;
                                    btnMin1F.BackColor = On;
                                    btnMin1G.BackColor = On;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = On;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = Off;
                                    break;

                                case 1:
                                    btnMin2A.BackColor = Off;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = Off;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = Off;
                                    btnMin2G.BackColor = Off;
                                    break;

                                case 2:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = Off;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = On;
                                    btnMin2F.BackColor = Off;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 3:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = Off;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 4:
                                    btnMin2A.BackColor = Off;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = Off;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 5:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = Off;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 6:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = Off;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = On;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 7:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = Off;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = Off;
                                    btnMin2G.BackColor = Off;
                                    break;

                                case 8:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = On;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = On;
                                    break;

                                case 9:
                                    btnMin2A.BackColor = On;
                                    btnMin2B.BackColor = On;
                                    btnMin2C.BackColor = On;
                                    btnMin2D.BackColor = On;
                                    btnMin2E.BackColor = Off;
                                    btnMin2F.BackColor = On;
                                    btnMin2G.BackColor = On;
                                    break;
                            }
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

    }
}
