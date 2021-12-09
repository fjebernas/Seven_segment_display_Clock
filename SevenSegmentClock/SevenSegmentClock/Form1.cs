using SevenSegmentClock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        
        Color BlueOn = ColorTranslator.FromHtml("#0E1EFF");
        Color BlueOff = ColorTranslator.FromHtml("#101122");

        Color OrangeOn = Color.Orange;
        Color OrangeOff = ColorTranslator.FromHtml("#35250B");

        Color backgroundColor = Color.Black;

        int flag = 1;
        string hourFormat = "hh";

        bool isCollapsed;
        bool isTwentyHourFormat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMeridiemAM.BackColor = backgroundColor;
            labelMeridiemPM.BackColor = backgroundColor;

            label12Hour.ForeColor = OrangeOn;
            label24Hour.ForeColor = OrangeOff;

            labelDayNameDD.ForeColor = GreenOff;
            labelMonthDD.ForeColor = BlueOff;
            labelDayDD.ForeColor = BlueOff;
            labelYearDD.ForeColor = BlueOff;
            labelHourDD.ForeColor = RedOff;
            labelMinuteDD.ForeColor = RedOff;
            labelSecondDD.ForeColor = RedOff;
            labelMeridiemDD.ForeColor = RedOff;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBoxEditDate.Checked == false)
            {
                //for seconds
                string secondDigits = DateTime.Now.ToString("ss");

                //for minutes
                string minuteDigits = DateTime.Now.ToString("mm");

                //for hours
                string hourDigits = DateTime.Now.ToString(hourFormat);

                //AM or PM
                string meridiem = DateTime.Now.ToString("tt");

                //for day name
                string dayName = DateTime.Now.ToString("dddd");

                //for month name
                string monthName = DateTime.Now.ToString("MMMM");

                //for the day of the month
                string dayDigits = DateTime.Now.ToString("dd");

                //for the year
                string yearDigits = DateTime.Now.ToString("yyyy");

                //Calling the functions
                SecondsController(secondDigits);
                MinutesController(minuteDigits);
                HoursController(hourDigits);

                if (!isTwentyHourFormat)
                {
                    Meridiem(meridiem);
                }

                BlinkingDot();
                DayNameController(dayName);
                MonthNameController(monthName);
                DayDigitsController(dayDigits);
                YearDigitsController(yearDigits);
            } 
            else if (checkBoxEditDate.Checked == true)
            {
                SecondsController(comboBoxSecondDigits.Text);
                MinutesController(comboBoxMinuteDigits.Text);
                HoursController(comboBoxHourDigits.Text);

                Meridiem(comboBoxMeridiem.Text.ToLower());
                DayNameController(comboBoxDayNames.Text);
                MonthNameController(comboBoxMonthNames.Text);
                DayDigitsController(comboBoxDayDigits.Text);
                YearDigitsController(comboYearDigits.Text);
            }
        }

        private void SecondsController(string secondDigits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "secondsBtn")
                {
                    x.BackColor = RedOff;
                }
            }

            List<Button> OnesZero = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1C, btnSec1D, btnSec1E, btnSec1F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnSec1B, btnSec1C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1G, btnSec1E, btnSec1D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1G, btnSec1C, btnSec1D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnSec1F, btnSec1G, btnSec1B, btnSec1C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnSec1A, btnSec1F, btnSec1G, btnSec1C, btnSec1D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnSec1A, btnSec1F, btnSec1G, btnSec1C, btnSec1D, btnSec1E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1C, btnSec1D, btnSec1E, btnSec1F, btnSec1G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnSec1A, btnSec1B, btnSec1C, btnSec1D, btnSec1F, btnSec1G
            };

            ////////////////////

            List<Button> TwosZero = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2C, btnSec2D, btnSec2E, btnSec2F
            };

            List<Button> TwosOne = new List<Button>
            {
                btnSec2B, btnSec2C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2G, btnSec2E, btnSec2D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2G, btnSec2C, btnSec2D
            };

            List<Button> TwosFour = new List<Button>
            {
                btnSec2F, btnSec2G, btnSec2B, btnSec2C
            };

            List<Button> TwosFive = new List<Button>
            {
                btnSec2A, btnSec2F, btnSec2G, btnSec2C, btnSec2D
            };

            List<Button> TwosSix = new List<Button>
            {
                btnSec2A, btnSec2F, btnSec2G, btnSec2C, btnSec2D, btnSec2E
            };

            List<Button> TwosSeven = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2C
            };

            List<Button> TwosEight = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2C, btnSec2D, btnSec2E, btnSec2F, btnSec2G
            };

            List<Button> TwosNine = new List<Button>
            {
                btnSec2A, btnSec2B, btnSec2C, btnSec2D, btnSec2F, btnSec2G
            };

            switch (secondDigits)
            {
                case "00":
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "01":
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "02":
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "03":
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "04":
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "05":
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "06":
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "07":
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "08":
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "09":
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "10":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "11":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "12":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "13":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "14":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "15":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "16":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "17":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "18":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "19":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "20":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "21":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "22":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "23":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "24":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "25":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "26":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "27":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "28":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "29":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "30":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "31":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "32":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "33":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "34":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "35":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "36":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "37":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "38":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "39":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "40":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "41":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "42":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "43":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "44":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "45":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "46":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "47":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "48":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "49":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "50":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "51":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "52":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "53":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "54":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "55":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "56":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "57":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "58":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "59":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void MinutesController(string minuteDigits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "minutesBtn")
                {
                    x.BackColor = RedOff;
                }
            }

            List<Button> OnesZero = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1C, btnMin1D, btnMin1E, btnMin1F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnMin1B, btnMin1C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1G, btnMin1E, btnMin1D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1G, btnMin1C, btnMin1D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnMin1F, btnMin1G, btnMin1B, btnMin1C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnMin1A, btnMin1F, btnMin1G, btnMin1C, btnMin1D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnMin1A, btnMin1F, btnMin1G, btnMin1C, btnMin1D, btnMin1E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1C, btnMin1D, btnMin1E, btnMin1F, btnMin1G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnMin1A, btnMin1B, btnMin1C, btnMin1D, btnMin1F, btnMin1G
            };

            ////////////////////

            List<Button> TwosZero = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2C, btnMin2D, btnMin2E, btnMin2F
            };

            List<Button> TwosOne = new List<Button>
            {
                btnMin2B, btnMin2C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2G, btnMin2E, btnMin2D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2G, btnMin2C, btnMin2D
            };

            List<Button> TwosFour = new List<Button>
            {
                btnMin2F, btnMin2G, btnMin2B, btnMin2C
            };

            List<Button> TwosFive = new List<Button>
            {
                btnMin2A, btnMin2F, btnMin2G, btnMin2C, btnMin2D
            };

            List<Button> TwosSix = new List<Button>
            {
                btnMin2A, btnMin2F, btnMin2G, btnMin2C, btnMin2D, btnMin2E
            };

            List<Button> TwosSeven = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2C
            };

            List<Button> TwosEight = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2C, btnMin2D, btnMin2E, btnMin2F, btnMin2G
            };

            List<Button> TwosNine = new List<Button>
            {
                btnMin2A, btnMin2B, btnMin2C, btnMin2D, btnMin2F, btnMin2G
            };

            switch (minuteDigits)
            {
                case "00":
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "01":
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "02":
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "03":
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "04":
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "05":
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "06":
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "07":
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "08":
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "09":
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "10":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "11":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "12":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "13":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "14":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "15":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "16":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "17":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "18":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "19":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "20":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "21":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "22":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "23":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "24":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "25":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "26":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "27":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "28":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "29":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "30":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "31":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "32":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "33":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "34":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "35":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "36":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "37":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "38":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "39":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "40":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "41":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "42":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "43":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "44":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "45":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "46":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "47":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "48":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "49":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "50":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "51":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "52":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "53":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "54":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "55":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "56":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "57":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "58":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "59":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void HoursController(string hourDigits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "hoursBtn")
                {
                    x.BackColor = RedOff;
                }
            }

            List<Button> OnesZero = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1C, btnHrs1D, btnHrs1E, btnHrs1F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnHrs1B, btnHrs1C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1G, btnHrs1E, btnHrs1D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1G, btnHrs1C, btnHrs1D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnHrs1F, btnHrs1G, btnHrs1B, btnHrs1C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnHrs1A, btnHrs1F, btnHrs1G, btnHrs1C, btnHrs1D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnHrs1A, btnHrs1F, btnHrs1G, btnHrs1C, btnHrs1D, btnHrs1E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1C, btnHrs1D, btnHrs1E, btnHrs1F, btnHrs1G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnHrs1A, btnHrs1B, btnHrs1C, btnHrs1D, btnHrs1F, btnHrs1G
            };

            ////////////////////

            List<Button> TwosZero = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2C, btnHrs2D, btnHrs2E, btnHrs2F
            };

            List<Button> TwosOne = new List<Button>
            {
                btnHrs2B, btnHrs2C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2G, btnHrs2E, btnHrs2D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2G, btnHrs2C, btnHrs2D
            };

            List<Button> TwosFour = new List<Button>
            {
                btnHrs2F, btnHrs2G, btnHrs2B, btnHrs2C
            };

            List<Button> TwosFive = new List<Button>
            {
                btnHrs2A, btnHrs2F, btnHrs2G, btnHrs2C, btnHrs2D
            };

            List<Button> TwosSix = new List<Button>
            {
                btnHrs2A, btnHrs2F, btnHrs2G, btnHrs2C, btnHrs2D, btnHrs2E
            };

            List<Button> TwosSeven = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2C
            };

            List<Button> TwosEight = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2C, btnHrs2D, btnHrs2E, btnHrs2F, btnHrs2G
            };

            List<Button> TwosNine = new List<Button>
            {
                btnHrs2A, btnHrs2B, btnHrs2C, btnHrs2D, btnHrs2F, btnHrs2G
            };

            switch (hourDigits)
            {
                case "00":
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "01":
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "02":
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "03":
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "04":
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "05":
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "06":
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "07":
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "08":
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "09":
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in TwosZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "10":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "11":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "12":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "13":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "14":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "15":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "16":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "17":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "18":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "19":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "20":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "21":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "22":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "23":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "24":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "25":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "26":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "27":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "28":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "29":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "30":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "31":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "32":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "33":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "34":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "35":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "36":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "37":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "38":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "39":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "40":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "41":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "42":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "43":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "44":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "45":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "46":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "47":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "48":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "49":
                    foreach (Button x in TwosFour)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "50":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesZero)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "51":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "52":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "53":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "54":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "55":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "56":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "57":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "58":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = RedOn;
                    }
                    break;

                case "59":
                    foreach (Button x in TwosFive)
                    {
                        x.BackColor = RedOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = RedOn;
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
            else if (flag == -1)
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

        private void btnHourFormat_Click(object sender, EventArgs e)
        {
            if (hourFormat == "HH")
            {
                hourFormat = "hh";
                label12Hour.ForeColor = OrangeOn;
                label24Hour.ForeColor = OrangeOff;
                btnHourFormat.Text = "To 24hr Format";
                labelMeridiemAM.ForeColor = RedOff;
                labelMeridiemPM.ForeColor = RedOff;
                isTwentyHourFormat = false;
            } 
            else if (hourFormat == "hh")
            {
                hourFormat = "HH";
                label24Hour.ForeColor = OrangeOn;
                label12Hour.ForeColor = OrangeOff;
                btnHourFormat.Text = "To 12hr Format";
                labelMeridiemAM.ForeColor = RedOff;
                labelMeridiemPM.ForeColor = RedOff;
                isTwentyHourFormat = true;
            }
        }

        private void DayNameController(string day)
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
                btn7A, btn7T, btn7U, btn7F, btn7R, btn7S, btn7K, btn7E, btn7P
            };

            List<Button> Tuesday = new List<Button>
            {
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2Q, btn2U, btn2S, btn2K,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4A, btn4B, btn4C, btn4D, btn4E, btn4I, btn4J, btn4K, btn4L, btn4M, btn4N, btn4O, btn4P, btn4T, btn4U,
                btn5B, btn5C, btn5D, btn5R, btn5H, btn5J, btn5K, btn5L, btn5T, btn5P, btn5E, btn5M, btn5U,

                btn6A, btn6B, btn6C, btn6D, btn6F, btn6G, btn6H, btn6J, btn6K, btn6L, btn6M, btn6N, btn6O, btn6P,
                btn7G, btn7B, btn7C, btn7D, btn7F, btn7H, btn7M, btn7N, btn7O, btn7P, btn7T, btn7U, btn7I, btn7R,
                btn8A, btn8T, btn8U, btn8F, btn8R, btn8S, btn8K, btn8E, btn8P
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
                btn9A, btn9T, btn9U, btn9F, btn9R, btn9S, btn9K, btn9E, btn9P
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
                btn8A, btn8T, btn8U, btn8F, btn8R, btn8S, btn8K, btn8E, btn8P
            };

            List<Button> Friday = new List<Button>
            {
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2N, btn2O, btn2P, btn2T, btn2U, btn2M,
                btn3A, btn3B, btn3C, btn3D, btn3F, btn3H, btn3M, btn3N, btn3O, btn3P, btn3T, btn3U, btn3I, btn3R,
                btn4C, btn4Q, btn4U, btn4S, btn4K,

                btn5A, btn5B, btn5C, btn5D, btn5F, btn5G, btn5H, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P,
                btn6G, btn6B, btn6C, btn6D, btn6F, btn6H, btn6M, btn6N, btn6O, btn6P, btn6T, btn6U, btn6I, btn6R,
                btn7A, btn7T, btn7U, btn7F, btn7R, btn7S, btn7K, btn7E, btn7P
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
                btn8A, btn8T, btn8U, btn8F, btn8R, btn8S, btn8K, btn8E, btn8P
            };

            List<Button> Sunday = new List<Button>
            {
                btn2B, btn2C, btn2D, btn2R, btn2H, btn2J, btn2K, btn2L, btn2T, btn2P, btn2E, btn2M, btn2U,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P,
                btn4B, btn4C, btn4D, btn4F, btn4G, btn4H, btn4I, btn4M, btn4N, btn4O, btn4P,

                btn5A, btn5B, btn5C, btn5D, btn5F, btn5G, btn5H, btn5J, btn5K, btn5L, btn5M, btn5N, btn5O, btn5P,
                btn6G, btn6B, btn6C, btn6D, btn6F, btn6H, btn6M, btn6N, btn6O, btn6P, btn6T, btn6U, btn6I, btn6R,
                btn7A, btn7T, btn7U, btn7F, btn7R, btn7S, btn7K, btn7E, btn7P
            };

            switch (day)
            {
                case "Monday":
                    foreach (Button x in Monday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Tuesday":
                    foreach (Button x in Tuesday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Wednesday":
                    foreach (Button x in Wednesday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Thursday":
                    foreach (Button x in Thursday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Friday":
                    foreach (Button x in Friday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Saturday":
                    foreach (Button x in Saturday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                case "Sunday":
                    foreach (Button x in Sunday)
                    {
                        x.BackColor = GreenOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void MonthNameController(string month)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "monthBtn")
                {
                    x.BackColor = BlueOff;
                }
            }

            List<Button> January = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3G, btnDate3H, btnDate3I, btnDate3M, btnDate3N, btnDate3O, btnDate3P,
            };

            List<Button> February = new List<Button>
            {
                btnDate1A, btnDate1B, btnDate1C, btnDate1D, btnDate1E, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1M,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3B, btnDate3C, btnDate3D, btnDate3A, btnDate3N, btnDate3J, btnDate3K, btnDate3L, btnDate3T, btnDate3P, btnDate3F, btnDate3M, btnDate3U, btnDate3H, btnDate3O, btnDate3R
            };

            List<Button> March = new List<Button>
            {
                btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1A, btnDate1B, btnDate1Q, btnDate1U, btnDate1D, btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1I,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3H, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3I, btnDate3R,
            };

            List<Button> April = new List<Button>
            {
                btnDate1G, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1H, btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1I, btnDate1R,
                btnDate2A, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2R,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3H, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3I, btnDate3R,
            };

            List<Button> May = new List<Button>
            {
                btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1A, btnDate1B, btnDate1Q, btnDate1U, btnDate1D, btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1I,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3A, btnDate3T, btnDate3U, btnDate3F, btnDate3R, btnDate3S, btnDate3K, btnDate3E, btnDate3P
            };

            List<Button> June = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3G, btnDate3H, btnDate3I, btnDate3M, btnDate3N, btnDate3O, btnDate3P,
            };

            List<Button> July = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3A, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3I, btnDate3J, btnDate3K, btnDate3L,
            };

            List<Button> August = new List<Button>
            {
                btnDate1G, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1H, btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1I, btnDate1R,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3C, btnDate3B, btnDate3N, btnDate3O, btnDate3P, btnDate3H, btnDate3J, btnDate3K, btnDate3L, btnDate3D, btnDate3R, btnDate3U
            };

            List<Button> September = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1R, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1T, btnDate1P, btnDate1E, btnDate1M, btnDate1U, btnDate1R,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3R,
            };

            List<Button> October = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2E, btnDate2I, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3C, btnDate3Q, btnDate3U, btnDate3S, btnDate3K, btnDate3A, btnDate3B, btnDate3D, btnDate3E,
            };

            List<Button> November = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1I, btnDate1M, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3A, btnDate3P, btnDate3T, btnDate3S, btnDate3R, btnDate3E, btnDate3F,
            };

            List<Button> December = new List<Button>
            {
                btnDate1A, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1M, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3B, btnDate3C, btnDate3D, btnDate3E, btnDate3I, btnDate3J, btnDate3K, btnDate3L, btnDate3N, btnDate3O, btnDate3P,
            };

            switch (month)
            {
                case "January":
                    foreach (Button x in January)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "February":
                    foreach (Button x in February)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "March":
                    foreach (Button x in March)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "April":
                    foreach (Button x in April)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "May":
                    foreach (Button x in May)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "June":
                    foreach (Button x in June)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "July":
                    foreach (Button x in July)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "August":
                    foreach (Button x in August)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "September":
                    foreach (Button x in September)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "October":
                    foreach (Button x in October)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "November":
                    foreach (Button x in November)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "December":
                    foreach (Button x in December)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                default:
                    break;
            }
        }
        
        private void DayDigitsController(string digits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "dayDigitBtn")
                {
                    x.BackColor = BlueOff;
                }
            }

            List<Button> Zero = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2E, btnDateDay2F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2G, btnDateDay2E, btnDateDay2D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2G, btnDateDay2C, btnDateDay2D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnDateDay2F, btnDateDay2G, btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnDateDay2A, btnDateDay2F, btnDateDay2G, btnDateDay2C, btnDateDay2D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnDateDay2A, btnDateDay2F, btnDateDay2G, btnDateDay2C, btnDateDay2D, btnDateDay2E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2E, btnDateDay2F, btnDateDay2G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2F, btnDateDay2G
            };

            ////////////////////

            List<Button> TwosOne = new List<Button>
            {
                btnDateDay1B, btnDateDay1C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnDateDay1A, btnDateDay1B, btnDateDay1G, btnDateDay1E, btnDateDay1D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnDateDay1A, btnDateDay1B, btnDateDay1G, btnDateDay1C, btnDateDay1D
            };

            switch (digits)
            {
                case "01":
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "02":
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "03":
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "04":
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "05":
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "06":
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "07":
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "08":
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "09":
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "10":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "11":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "12":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "13":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "14":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "15":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "16":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "17":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "18":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "19":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "20":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "21":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "22":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "23":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "24":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "25":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "26":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "27":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "28":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "29":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "30":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "31":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void YearDigitsController(string digits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "yearDigitBtn")
                {
                    x.BackColor = BlueOff;
                }
            }

            List<Button> Zero = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4C, btnDateYear4D, btnDateYear4E, btnDateYear4F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnDateYear4B, btnDateYear4C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4G, btnDateYear4E, btnDateYear4D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4G, btnDateYear4C, btnDateYear4D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnDateYear4F, btnDateYear4G, btnDateYear4B, btnDateYear4C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnDateYear4A, btnDateYear4F, btnDateYear4G, btnDateYear4C, btnDateYear4D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnDateYear4A, btnDateYear4F, btnDateYear4G, btnDateYear4C, btnDateYear4D, btnDateYear4E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4C, btnDateYear4D, btnDateYear4E, btnDateYear4F, btnDateYear4G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnDateYear4A, btnDateYear4B, btnDateYear4C, btnDateYear4D, btnDateYear4F, btnDateYear4G
            };

            ////////////////////

            List<Button> TwosOne = new List<Button>
            {
                btnDateYear3B, btnDateYear3C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnDateYear3A, btnDateYear3B, btnDateYear3G, btnDateYear3E, btnDateYear3D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnDateYear3A, btnDateYear3B, btnDateYear3G, btnDateYear3C, btnDateYear3D
            };

            
            switch (digits)
            {
                case "2015":
                    yearCompleter();
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2016":
                    yearCompleter();
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2017":
                    yearCompleter();
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2018":
                    yearCompleter();
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2019":
                    yearCompleter();
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2020":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2021":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2022":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2023":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2024":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                case "2025":
                    yearCompleter();
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = BlueOn;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = BlueOn;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void checkBoxEditDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditDate.Checked == true)
            {
                 foreach (Control x in Controls)
                {
                    if (x.Tag == "hoursBtn" || x.Tag == "minutesBtn" || x.Tag == "secondsBtn" || x.Tag == "blinkerBtn")
                    {
                        x.BackColor = RedOff;
                    }
                }

                labelMeridiemAM.ForeColor = RedOff;
                labelMeridiemPM.ForeColor = RedOff;

                label12Hour.ForeColor = OrangeOff;
                label24Hour.ForeColor = OrangeOff;

                comboBoxDayNames.Enabled = true;
                comboBoxMonthNames.Enabled = true;
                comboBoxDayDigits.Enabled = true;
                comboYearDigits.Enabled = true;
                comboBoxHourDigits.Enabled = true;
                comboBoxMinuteDigits.Enabled = true;
                comboBoxSecondDigits.Enabled = true;
                comboBoxMeridiem.Enabled = true;

                labelDayNameDD.ForeColor = GreenOn;
                labelMonthDD.ForeColor = BlueOn;
                labelDayDD.ForeColor = BlueOn;
                labelYearDD.ForeColor = BlueOn;
                labelHourDD.ForeColor = RedOn;
                labelMinuteDD.ForeColor = RedOn;
                labelSecondDD.ForeColor = RedOn;
                labelMeridiemDD.ForeColor = RedOn;
            } 
            else
            {
                List<ComboBox> comboBoxes = new List<ComboBox>
                {
                    comboBoxDayNames, comboBoxMonthNames, comboBoxDayDigits, comboYearDigits, comboBoxHourDigits,
                    comboBoxMinuteDigits, comboBoxSecondDigits, comboBoxMeridiem
                };

                foreach (ComboBox x in comboBoxes)
                {
                    x.SelectedIndex = -1;
                }

                comboBoxDayNames.Enabled = false;
                comboBoxMonthNames.Enabled = false;
                comboBoxDayDigits.Enabled = false;
                comboYearDigits.Enabled = false;
                comboBoxHourDigits.Enabled = false;
                comboBoxMinuteDigits.Enabled = false;
                comboBoxSecondDigits.Enabled = false;
                comboBoxMeridiem.Enabled = false;

                labelDayNameDD.ForeColor = GreenOff;
                labelMonthDD.ForeColor = BlueOff;
                labelDayDD.ForeColor = BlueOff;
                labelYearDD.ForeColor = BlueOff;
                labelHourDD.ForeColor = RedOff;
                labelMinuteDD.ForeColor = RedOff;
                labelSecondDD.ForeColor = RedOff;
                labelMeridiemDD.ForeColor = RedOff;

                label12Hour.ForeColor = OrangeOn;
                label24Hour.ForeColor = OrangeOff;

                foreach (Control x in Controls)
                {
                    if (x.Tag == "blinkerBtn")
                    {
                        x.BackColor = RedOn;
                    }
                }
            }
        }

        private void yearCompleter()
        {
            List<Button> Two_ = new List<Button>
            {
                btnDateYear1A, btnDateYear1B, btnDateYear1G, btnDateYear1E, btnDateYear1D
            };

            List<Button> _Zero = new List<Button>
            {
                btnDateYear2A, btnDateYear2B, btnDateYear2C, btnDateYear2D, btnDateYear2E, btnDateYear2F
            };

            foreach (Button x in Two_)
            {
                x.BackColor = BlueOn;
            }

            foreach (Button x in _Zero)
            {
                x.BackColor = BlueOn;
            }
        }

        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnDropDown.Image = Resources.Up;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnDropDown.Image = Resources.Down;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            timerDropDown.Start();
        }

        private void linkLabelMyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/fjebernas");
            Process.Start(sInfo);
        }
    }
}
