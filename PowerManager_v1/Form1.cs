using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PowerManager_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hours =  HoursInput.Text.Equals("") ? 0 : int.Parse(HoursInput.Text);
            int minutes =MinutesInput.Text.Equals("") ? 0 : int.Parse(MinutesInput.Text);
            int time =  hours* 3600 + minutes * 60;
            Process.Start("shutdown", "-s -t " + time + @" -c ""Windows will shutdown!""");
            Timer.Start();
            TimeLeft.Text = time.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLeft.Text= (int.Parse(TimeLeft.Text)-1).ToString();
        }
    }
}
