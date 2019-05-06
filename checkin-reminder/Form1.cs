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
using System.Threading;

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
        DateTime today;
        TimeSpan workedTime;
        TimeSpan customTarget;
        bool useCustomTarget;
        Dictionary<DayOfWeek, TimeSpan> schedule;
        Thread timeThread;

        delegate void SetTextCallback();

        private void SetLabelsText()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (labElapsed.InvokeRequired)
            {
                this.Invoke(new SetTextCallback(SetLabelsText));
            }
            else
            {
                labElapsed.Text = workedTime.ToString("h\\:mm\\:ss");
                TimeSpan currentSchedule;
                if(useCustomTarget)
                {
                    currentSchedule = customTarget;
                }
                else
                {
                    currentSchedule = schedule[today.DayOfWeek];
                }

                labRemain.Text = currentSchedule.Subtract(workedTime).ToString("h\\:mm\\:ss");
                labFinish.Text = today.Add(currentSchedule).ToShortTimeString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            schedule = new Dictionary<DayOfWeek, TimeSpan>();
            schedule.Add(DayOfWeek.Sunday,    new TimeSpan(0, 00, 0));
            schedule.Add(DayOfWeek.Monday,    new TimeSpan(5, 30, 0));
            schedule.Add(DayOfWeek.Tuesday,   new TimeSpan(0, 00, 0));
            schedule.Add(DayOfWeek.Wednesday, new TimeSpan(4, 00, 0));
            schedule.Add(DayOfWeek.Thursday,  new TimeSpan(0, 00, 0));
            schedule.Add(DayOfWeek.Friday,    new TimeSpan(5, 30, 0));
            schedule.Add(DayOfWeek.Saturday,  new TimeSpan(0, 00, 0));

            state = CheckinState.CheckedOut;
            today = DateTime.Now;
            workedTime = TimeSpan.Zero;
            customTarget = TimeSpan.Zero;
            useCustomTarget = false;
            prepareState(state);

            timeThread = new Thread(new ThreadStart(this.TimeThread));
            timeThread.IsBackground = true;
            timeThread.Start();
        }

        private void TimeThread()
        {
            while(true)
            {
                if (DateTime.Now.DayOfWeek != today.DayOfWeek)
                {
                    workedTime = TimeSpan.Zero;
                    customTarget = TimeSpan.Zero;
                    inputTarget.Text = "";
                    useCustomTarget = false;
                }

                switch (state)
                {
                    case CheckinState.CheckedIn:
                        workedTime = DateTime.Now.Subtract(today);
                        break;

                    case CheckinState.CheckedOut:
                        today = DateTime.Now.Subtract(workedTime);
                        break;
                }
                SetLabelsText();
                try
                {
                    Thread.Sleep(1000);
                }
                catch(ThreadInterruptedException ex)
                {
                }
            }
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

        private void inputTarget_TextChanged(object sender, EventArgs e)
        {
            try
            {
                customTarget = TimeSpan.Parse(inputTarget.Text);
                useCustomTarget = customTarget.TotalMilliseconds != 0;
                timeThread.Interrupt();
                inputTarget.ForeColor = SystemColors.WindowText;
            }
            catch (FormatException ex)
            {
                inputTarget.ForeColor = Color.Red;
            }
        }
    }
}
