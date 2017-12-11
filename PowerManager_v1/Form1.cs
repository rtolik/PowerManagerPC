using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace PowerManager_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        public enum MonitorState
        {
            MonitorStateOn = -1,
            MonitorStateOff = 2,
            MonitorStateStandBy = 1
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);


        void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            SetMonitorInState(MonitorState.MonitorStateOff);
        }

        private void SetMonitorInState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, (int)state);
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
            SetMonitorInState(MonitorState.MonitorStateOn);
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLeft.Text= (int.Parse(TimeLeft.Text)-1).ToString();
            if(int.Parse(TimeLeft.Text)==5)
            {
                SetMonitorInState(MonitorState.MonitorStateOff);
            }
        }
    }
}
