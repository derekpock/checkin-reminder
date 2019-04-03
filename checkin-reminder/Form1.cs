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

namespace checkin_reminder
{
    enum CheckinState
    {
        CheckedIn,
        CheckedOut
    }
    public partial class Form1 : Form
    {
        CheckinState state;

        public Form1()
        {
            InitializeComponent();
            state = CheckinState.CheckedOut;
            prepareState(state);
        }

        private void butCheck_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case CheckinState.CheckedIn:
                    state = CheckinState.CheckedOut;
                    prepareState(state);
                    Process.Start("C:\\Program Files\\internet explorer\\iexplore.exe");
                    Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "/new-window https://engprojects.garmin.com/effort");
                    break;

                case CheckinState.CheckedOut:
                    state = CheckinState.CheckedIn;
                    prepareState(state);
                    Process.Start("C:\\Program Files\\internet explorer\\iexplore.exe");
                    break;
            }
        }

        private void prepareState(CheckinState state)
        {
            switch (state)
            {
                case CheckinState.CheckedIn:
                    butCheck.Text = "Check Out";
                    labStatus.Text = "Currently Checked In";
                    this.TopMost = false;
                    break;

                case CheckinState.CheckedOut:
                    butCheck.Text = "Check In";
                    labStatus.Text = "Currently Checked Out";
                    this.TopMost = true;
                    break;
            }
        }
    }
}
