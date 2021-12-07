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
        Color RedOn = Color.Red;
        Color RedOff = ColorTranslator.FromHtml("#261010");

        Color GreenOn = ColorTranslator.FromHtml("#09E21F");
        Color GreenOff = ColorTranslator.FromHtml("#0B1A0D");
        
        Color backgroundColor = Color.Black;

        int flag = 1;
        string hourFormat = "hh";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxBackground.BackColor = backgroundColor;

            labelMeridiemAM.BackColor = backgroundColor;
            labelMeridiemPM.BackColor = backgroundColor;

            foreach (Control x in Controls)
            {
                if (x.Tag == "dayBtn")
                {
                    x.BackColor = RedOff;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for seconds
            string seconds = DateTime.Now.ToString("ss");

            int secondsOnes = Convert.ToInt32(seconds.Substring(1));
            int secondsTens = Convert.ToInt32(seconds.Remove(1, 1));

            //for minutes
            string minutes = DateTime.Now.ToString("mm");

            int minutesOnes = Convert.ToInt32(minutes.Substring(1));
            int minutesTens = Convert.ToInt32(minutes.Remove(1, 1));

            //for hours
            string hours = DateTime.Now.ToString(hourFormat);

            int hoursOnes = Convert.ToInt32(hours.Substring(1));
            int hoursTens = Convert.ToInt32(hours.Remove(1, 1));

            //AM or PM
            string meridiem = DateTime.Now.ToString("tt");

            //for day name
            string dayName = DateTime.Now.ToString("ddd");

            //for month name
            string monthName = DateTime.Now.ToString("MMMM");

            sevenSegment(secondsOnes, "Seconds", "Ones");
            sevenSegment(secondsTens, "Seconds", "Tens");

            sevenSegment(minutesOnes, "Minutes", "Ones");
            sevenSegment(minutesTens, "Minutes", "Tens");

            sevenSegment(hoursOnes, "Hours", "Ones");
            sevenSegment(hoursTens, "Hours", "Tens");


            BlinkingDot();
            Meridiem(meridiem);
            dayNameController(dayName);
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
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOn;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnSec1A.BackColor = RedOff;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOff;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOff;
                                    btnSec1G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOff;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOn;
                                    btnSec1F.BackColor = RedOff;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOff;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnSec1A.BackColor = RedOff;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOff;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOff;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOff;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOn;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOff;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOff;
                                    btnSec1G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOn;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnSec1A.BackColor = RedOn;
                                    btnSec1B.BackColor = RedOn;
                                    btnSec1C.BackColor = RedOn;
                                    btnSec1D.BackColor = RedOn;
                                    btnSec1E.BackColor = RedOff;
                                    btnSec1F.BackColor = RedOn;
                                    btnSec1G.BackColor = RedOn;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOn;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnSec2A.BackColor = RedOff;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOff;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOff;
                                    btnSec2G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOff;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOn;
                                    btnSec2F.BackColor = RedOff;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOff;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnSec2A.BackColor = RedOff;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOff;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOff;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOff;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOn;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOff;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOff;
                                    btnSec2G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOn;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnSec2A.BackColor = RedOn;
                                    btnSec2B.BackColor = RedOn;
                                    btnSec2C.BackColor = RedOn;
                                    btnSec2D.BackColor = RedOn;
                                    btnSec2E.BackColor = RedOff;
                                    btnSec2F.BackColor = RedOn;
                                    btnSec2G.BackColor = RedOn;
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
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOn;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnMin1A.BackColor = RedOff;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOff;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOff;
                                    btnMin1G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOff;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOn;
                                    btnMin1F.BackColor = RedOff;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOff;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnMin1A.BackColor = RedOff;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOff;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOff;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOff;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOn;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOff;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOff;
                                    btnMin1G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOn;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnMin1A.BackColor = RedOn;
                                    btnMin1B.BackColor = RedOn;
                                    btnMin1C.BackColor = RedOn;
                                    btnMin1D.BackColor = RedOn;
                                    btnMin1E.BackColor = RedOff;
                                    btnMin1F.BackColor = RedOn;
                                    btnMin1G.BackColor = RedOn;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOn;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnMin2A.BackColor = RedOff;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOff;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOff;
                                    btnMin2G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOff;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOn;
                                    btnMin2F.BackColor = RedOff;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOff;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnMin2A.BackColor = RedOff;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOff;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOff;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOff;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOn;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOff;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOff;
                                    btnMin2G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOn;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnMin2A.BackColor = RedOn;
                                    btnMin2B.BackColor = RedOn;
                                    btnMin2C.BackColor = RedOn;
                                    btnMin2D.BackColor = RedOn;
                                    btnMin2E.BackColor = RedOff;
                                    btnMin2F.BackColor = RedOn;
                                    btnMin2G.BackColor = RedOn;
                                    break;
                            }
                            break;
                    }
                    break;

                case "Hours":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOn;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnHrs1A.BackColor = RedOff;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOff;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOff;
                                    btnHrs1G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOff;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOn;
                                    btnHrs1F.BackColor = RedOff;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOff;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnHrs1A.BackColor = RedOff;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOff;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOff;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOff;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOn;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOff;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOff;
                                    btnHrs1G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOn;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnHrs1A.BackColor = RedOn;
                                    btnHrs1B.BackColor = RedOn;
                                    btnHrs1C.BackColor = RedOn;
                                    btnHrs1D.BackColor = RedOn;
                                    btnHrs1E.BackColor = RedOff;
                                    btnHrs1F.BackColor = RedOn;
                                    btnHrs1G.BackColor = RedOn;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOn;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOff;
                                    break;

                                case 1:
                                    btnHrs2A.BackColor = RedOff;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOff;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOff;
                                    btnHrs2G.BackColor = RedOff;
                                    break;

                                case 2:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOff;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOn;
                                    btnHrs2F.BackColor = RedOff;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 3:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOff;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 4:
                                    btnHrs2A.BackColor = RedOff;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOff;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 5:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOff;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 6:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOff;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOn;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 7:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOff;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOff;
                                    btnHrs2G.BackColor = RedOff;
                                    break;

                                case 8:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOn;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOn;
                                    break;

                                case 9:
                                    btnHrs2A.BackColor = RedOn;
                                    btnHrs2B.BackColor = RedOn;
                                    btnHrs2C.BackColor = RedOn;
                                    btnHrs2D.BackColor = RedOn;
                                    btnHrs2E.BackColor = RedOff;
                                    btnHrs2F.BackColor = RedOn;
                                    btnHrs2G.BackColor = RedOn;
                                    break;
                            }
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void BlinkingDot()
        {
            if (flag == 1)
            {
                btnBlinker.BackColor = RedOff;
                flag *= -1;
            }
            else
            {
                btnBlinker.BackColor = RedOn;
                flag *= -1;
            }
        }

        private void Meridiem(string state)
        {
            if (state == "am")
            {
                labelMeridiemAM.ForeColor = RedOn;
                labelMeridiemPM.ForeColor = RedOff;
            }
            else if (state == "pm")
            {
                labelMeridiemAM.ForeColor = RedOff;
                labelMeridiemPM.ForeColor = RedOn;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHourFormat_Click(object sender, EventArgs e)
        {
            if (hourFormat == "HH")
            {
                hourFormat = "hh";
                btnHourFormat.Text = "To 24hr Format";
            } 
            else if (hourFormat == "hh")
            {
                hourFormat = "HH";
                btnHourFormat.Text = "To 12hr Format";
            }
        }

        private void dayNameController(string day)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "dayBtn")
                {
                    x.BackColor = GreenOff;
                }
            }

            List<Button> Monday = new List<Button>
            {
                btn2M, btn2N, btn2O, btn2P, btn2A, btn2B, btn2Q, btn2U, btn2D, btn2E, btn2F, btn2G, btn2H, btn2I,
                btn3B, btn3C, btn3D, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4B, btn4C, btn4D, btn4F, btn4G, btn4H, btn4I, btn4M, btn4N, btn4O, btn4P,

                btn5A, btn5B, btn5C, btn5D, btn5F, btn5G, btn5H, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P,
                btn6G, btn6B, btn6C, btn6D, btn6F, btn6H, btn6M, btn6N, btn6O, btn6P, btn6T, btn6U, btn6I, btn6R,
                btn7A, btn7T, btn7U, btn7F, btn7G, btn7R, btn7S, btn7K, btn7E, btn7O, btn7P
            };

            List<Button> Tuesday = new List<Button>
            {
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2Q, btn2U, btn2S, btn2K,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4A, btn4B, btn4C, btn4D, btn4E, btn4I, btn4J, btn4K, btn4L, btn4M, btn4N, btn4O, btn4P, btn4T, btn4U,
                btn5B, btn5C, btn5D, btn5R, btn5H, btn5J, btn5K, btn5L, btn5T, btn5P, btn5E, btn5M, btn5U,

                btn6A, btn6B, btn6C, btn6D, btn6F, btn6G, btn6H, btn6J, btn6K, btn6L, btn6M, btn6N, btn6O, btn6P,
                btn7G, btn7B, btn7C, btn7D, btn7F, btn7H, btn7M, btn7N, btn7O, btn7P, btn7T, btn7U, btn7I, btn7R,
                btn8A, btn8T, btn8U, btn8F, btn8G, btn8R, btn8S, btn8K, btn8E, btn8O, btn8P
            };

            List<Button> Wednesday = new List<Button>
            {
                btn1A, btn1E, btn1F, btn1G, btn1H, btn1J, btn1L, btn1N, btn1O, btn1P, btn1S, btn1U,
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2I, btn2J, btn2K, btn2L, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U,
                btn3A, btn3B, btn3C, btn3D, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3M, btn3N, btn3O, btn3P,

                btn4B, btn4C, btn4D, btn4F, btn4G, btn4H, btn4I, btn4M, btn4N, btn4O, btn4P,
                btn5A, btn5B, btn5C, btn5D, btn5E, btn5I, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P, btn5T, btn5U,
                btn6B, btn6C, btn6D, btn6R, btn6H, btn6J, btn6K, btn6L, btn6T, btn6P, btn6E, btn6M, btn6U,

                btn7A, btn7B, btn7C, btn7D, btn7F, btn7G, btn7H, btn7J, btn7K, btn7L, btn7M, btn7N, btn7O, btn7P,
                btn8G, btn8B, btn8C, btn8D, btn8F, btn8H, btn8M, btn8N, btn8O, btn8P, btn8T, btn8U, btn8I, btn8R,
                btn9A, btn9T, btn9U, btn9F, btn9G, btn9R, btn9S, btn9K, btn9E, btn9O, btn9P
            };

            List<Button> Thursday = new List<Button>
            {
                btn1A, btn1B, btn1C, btn1D, btn1E, btn1Q, btn1U, btn1S, btn1K,
                btn2A, btn2E, btn2I, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U, btn2F, btn2G, btn2H, btn2R,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4A, btn4B, btn4C, btn4D, btn4F, btn4H, btn4M, btn4N, btn4O, btn4P, btn4T, btn4U, btn4I, btn4R,
                btn5B, btn5C, btn5D, btn5R, btn5H, btn5J, btn5K, btn5L, btn5T, btn5P, btn5E, btn5M, btn5U,

                btn6A, btn6B, btn6C, btn6D, btn6F, btn6G, btn6H, btn6J, btn6K, btn6L, btn6M, btn6N, btn6O, btn6P,
                btn7G, btn7B, btn7C, btn7D, btn7F, btn7H, btn7M, btn7N, btn7O, btn7P, btn7T, btn7U, btn7I, btn7R,
                btn8A, btn8T, btn8U, btn8F, btn8G, btn8R, btn8S, btn8K, btn8E, btn8O, btn8P
            };

            List<Button> Friday = new List<Button>
            {
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2N, btn2O, btn2P, btn2T, btn2U, btn2M,
                btn3A, btn3B, btn3C, btn3D, btn3F, btn3H, btn3M, btn3N, btn3O, btn3P, btn3T, btn3U, btn3I, btn3R,
                btn4C, btn4Q, btn4U, btn4S, btn4K,

                btn5A, btn5B, btn5C, btn5D, btn5F, btn5G, btn5H, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P,
                btn6G, btn6B, btn6C, btn6D, btn6F, btn6H, btn6M, btn6N, btn6O, btn6P, btn6T, btn6U, btn6I, btn6R,
                btn7A, btn7T, btn7U, btn7F, btn7G, btn7R, btn7S, btn7K, btn7E, btn7O, btn7P
            };

            List<Button> Saturday = new List<Button>
            {
                btn1B, btn1C, btn1D, btn1R, btn1H, btn1J, btn1K, btn1L, btn1T, btn1P, btn1E, btn1M, btn1U,
                btn2G, btn2B, btn2C, btn2D, btn2F, btn2H, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U, btn2I, btn2R,
                btn3C, btn3Q, btn3U, btn3S, btn3K, btn3A, btn3B, btn3D, btn3E,

                btn4A, btn4E, btn4F, btn4G, btn4H, btn4J, btn4K, btn4L, btn4N, btn4O, btn4P,
                btn5A, btn5B, btn5C, btn5D, btn5F, btn5H, btn5M, btn5N, btn5O, btn5P, btn5T, btn5U, btn5I, btn5R,

                btn6A, btn6B, btn6C, btn6D, btn6F, btn6G, btn6H, btn6J, btn6K, btn6L, btn6M, btn6N, btn6O, btn6P,
                btn7G, btn7B, btn7C, btn7D, btn7F, btn7H, btn7M, btn7N, btn7O, btn7P, btn7T, btn7U, btn7I, btn7R,
                btn8A, btn8T, btn8U, btn8F, btn8G, btn8R, btn8S, btn8K, btn8E, btn8O, btn8P
            };

            List<Button> Sunday = new List<Button>
            {
                btn2B, btn2C, btn2D, btn2R, btn2H, btn2J, btn2K, btn2L, btn2T, btn2P, btn2E, btn2M, btn2U,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4B, btn4C, btn4D, btn4F, btn4G, btn4H, btn4I, btn4M, btn4N, btn4O, btn4P,

                btn5A, btn5B, btn5C, btn5D, btn5F, btn5G, btn5H, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P,
                btn6G, btn6B, btn6C, btn6D, btn6F, btn6H, btn6M, btn6N, btn6O, btn6P, btn6T, btn6U, btn6I, btn6R,
                btn7A, btn7T, btn7U, btn7F, btn7G, btn7R, btn7S, btn7K, btn7E, btn7O, btn7P
            };

            switch (day)
            {
                case "Mon":
                    foreach (Button x in Monday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Tue":
                    foreach (Button x in Tuesday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Wed":
                    foreach (Button x in Wednesday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Thu":
                    foreach (Button x in Thursday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Fri":
                    foreach (Button x in Friday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Sat":
                    foreach (Button x in Saturday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Sun":
                    foreach (Button x in Sunday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
