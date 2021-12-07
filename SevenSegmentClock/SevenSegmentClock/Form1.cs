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

        int flag = 1;
        int flagHour = 1;

        public Form1()
        {
            InitializeComponent();
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
            string hours = DateTime.Now.ToString("hh");

            int hoursOnes = Convert.ToInt32(hours.Substring(1));
            int hoursTens = Convert.ToInt32(hours.Remove(1, 1));

            //for days
            string days = DateTime.Now.ToString("dd");

            int daysOnes = Convert.ToInt32(days.Substring(1));
            int daysTens = Convert.ToInt32(days.Remove(1, 1));

            //AM or PM
            string meridiem = DateTime.Now.ToString("tt");

            sevenSegment(secondsOnes, "Seconds", "Ones");
            sevenSegment(secondsTens, "Seconds", "Tens");

            sevenSegment(minutesOnes, "Minutes", "Ones");
            sevenSegment(minutesTens, "Minutes", "Tens");

            sevenSegment(hoursOnes, "Hours", "Ones");
            sevenSegment(hoursTens, "Hours", "Tens");

            sevenSegment(daysOnes, "Days", "Ones");
            sevenSegment(daysTens, "Days", "Tens");

            BlinkingDot();
            Meridiem(meridiem.ToUpper());
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

                case "Hours":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = On;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = Off;
                                    break;

                                case 1:
                                    btnHrs1A.BackColor = Off;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = Off;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = Off;
                                    btnHrs1G.BackColor = Off;
                                    break;

                                case 2:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = Off;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = On;
                                    btnHrs1F.BackColor = Off;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 3:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = Off;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 4:
                                    btnHrs1A.BackColor = Off;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = Off;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 5:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = Off;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 6:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = Off;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = On;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 7:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = Off;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = Off;
                                    btnHrs1G.BackColor = Off;
                                    break;

                                case 8:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = On;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = On;
                                    break;

                                case 9:
                                    btnHrs1A.BackColor = On;
                                    btnHrs1B.BackColor = On;
                                    btnHrs1C.BackColor = On;
                                    btnHrs1D.BackColor = On;
                                    btnHrs1E.BackColor = Off;
                                    btnHrs1F.BackColor = On;
                                    btnHrs1G.BackColor = On;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = On;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = Off;
                                    break;

                                case 1:
                                    btnHrs2A.BackColor = Off;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = Off;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = Off;
                                    btnHrs2G.BackColor = Off;
                                    break;

                                case 2:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = Off;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = On;
                                    btnHrs2F.BackColor = Off;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 3:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = Off;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 4:
                                    btnHrs2A.BackColor = Off;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = Off;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 5:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = Off;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 6:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = Off;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = On;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 7:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = Off;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = Off;
                                    btnHrs2G.BackColor = Off;
                                    break;

                                case 8:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = On;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = On;
                                    break;

                                case 9:
                                    btnHrs2A.BackColor = On;
                                    btnHrs2B.BackColor = On;
                                    btnHrs2C.BackColor = On;
                                    btnHrs2D.BackColor = On;
                                    btnHrs2E.BackColor = Off;
                                    btnHrs2F.BackColor = On;
                                    btnHrs2G.BackColor = On;
                                    break;
                            }
                            break;
                    }
                    break;

                case "Days":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = On;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = Off;
                                    break;

                                case 1:
                                    btnDay1A.BackColor = Off;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = Off;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = Off;
                                    btnDay1G.BackColor = Off;
                                    break;

                                case 2:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = Off;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = On;
                                    btnDay1F.BackColor = Off;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 3:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = Off;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 4:
                                    btnDay1A.BackColor = Off;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = Off;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 5:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = Off;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 6:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = Off;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = On;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 7:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = Off;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = Off;
                                    btnDay1G.BackColor = Off;
                                    break;

                                case 8:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = On;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = On;
                                    break;

                                case 9:
                                    btnDay1A.BackColor = On;
                                    btnDay1B.BackColor = On;
                                    btnDay1C.BackColor = On;
                                    btnDay1D.BackColor = On;
                                    btnDay1E.BackColor = Off;
                                    btnDay1F.BackColor = On;
                                    btnDay1G.BackColor = On;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = On;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = Off;
                                    break;

                                case 1:
                                    btnDay2A.BackColor = Off;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = Off;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = Off;
                                    btnDay2G.BackColor = Off;
                                    break;

                                case 2:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = Off;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = On;
                                    btnDay2F.BackColor = Off;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 3:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = Off;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 4:
                                    btnDay2A.BackColor = Off;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = Off;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 5:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = Off;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 6:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = Off;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = On;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 7:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = Off;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = Off;
                                    btnDay2G.BackColor = Off;
                                    break;

                                case 8:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = On;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = On;
                                    break;

                                case 9:
                                    btnDay2A.BackColor = On;
                                    btnDay2B.BackColor = On;
                                    btnDay2C.BackColor = On;
                                    btnDay2D.BackColor = On;
                                    btnDay2E.BackColor = Off;
                                    btnDay2F.BackColor = On;
                                    btnDay2G.BackColor = On;
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
                btnBlinker.BackColor = Off;
                flag *= -1;
            }
            else
            {
                btnBlinker.BackColor = On;
                flag *= -1;
            }
        }

        private void Meridiem(string state)
        {
            labelMeridiem.Text = state;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
