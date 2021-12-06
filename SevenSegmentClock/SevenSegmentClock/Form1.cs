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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTester_Click(object sender, EventArgs e)
        {
            txtBoxCheckTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
