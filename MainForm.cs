using System;
using System.IO;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class MainForm : Form
    {
        private ClockDisplay _clockDisplay;
        private ClockDisplay _researchClock;
        private ClockDisplay _teachingClock;
        private ClockDisplay _lunchClock;
        private int _researchTime;
        private int _teachingTime;
        private int _lunchTime;
        private Button researchButton;
        private Button teachingButton;
        private Button lunchButton;
        private System.Windows.Forms.Label researchLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label teachingLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label lunchLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label diodeLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label clockLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Timer researchTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer teachingTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer lunchTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer diodeTimer = new System.Windows.Forms.Timer();


        public MainForm()
        {
            InitializeComponent();

            // Initialize clocks
            DateTime now = DateTime.Now;
            _clockDisplay = new ClockDisplay(now.Hour, now.Minute, true);
            _researchClock = new ClockDisplay(now.Hour, now.Minute, true);
            _teachingClock = new ClockDisplay(now.Hour, now.Minute, true);
            _lunchClock = new ClockDisplay(now.Hour, now.Minute, true);

            // Update clock labels
            UpdateClockLabels();
        }

        private void researchButton_Click(object sender, EventArgs e)
        {
            // Start or stop research clock
            if (researchButton.Text == "Start")
            {
                researchButton.Text = "Stop";
                researchTimer.Enabled = true;
            }
            else
            {
                researchButton.Text = "Start";
                researchTimer.Enabled = false;
            }
        }

        private void teachingButton_Click(object sender, EventArgs e)
        {
            // Start or stop teaching clock
            if (teachingButton.Text == "Start")
            {
                teachingButton.Text = "Stop";
                teachingTimer.Enabled = true;
            }
            else
            {
                teachingButton.Text = "Start";
                teachingTimer.Enabled = false;
            }
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            // Start or stop lunch clock
            if (lunchButton.Text == "Start")
            {
                lunchButton.Text = "Stop";
                lunchTimer.Enabled = true;
            }
            else
            {
                lunchButton.Text = "Start";
                lunchTimer.Enabled = false;
            }
        }

        private void researchTimer_Tick(object sender, EventArgs e)
        {
            // Increment research time and update display
            _researchTime++;
            _researchClock.TimeTick();
            researchLabel.Text = _researchClock.GetTime();

            // Check if total time for research and teaching is 8 hours
            if (_researchTime + _teachingTime >= 8 * 60 * 60)
            {
                // Start flashing diode
                diodeTimer.Enabled = true;
            }
        }

        private void teachingTimer_Tick(object sender, EventArgs e)
        {
            // Increment teaching time and update display
            _teachingTime++;
            _teachingClock.TimeTick();
            teachingLabel.Text = _teachingClock.GetTime();

            // Check if total time for research and teaching is 8 hours
            if (_researchTime + _teachingTime >= 8 * 60 * 60)
            {
                // Start flashing diode
                diodeTimer.Enabled = true;
            }
        }

        private void lunchTimer_Tick(object sender, EventArgs e)
        {
            // Increment lunch time and update display
            _lunchTime++;
            _lunchClock.TimeTick();
            lunchLabel.Text = _lunchClock.GetTime();
        }

        // Handle diode timer tick event
        private void diodeTimer_Tick(object sender, EventArgs e)
        {
            // Toggle diode color and text
            if (diodeLabel.BackColor == Color.Black)
            {
                diodeLabel.BackColor = Color.Red;
                diodeLabel.Text = "Go HOME!!!";
            }
            else
            {
                diodeLabel.BackColor = Color.Black;
                diodeLabel.Text = "";
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save time spent on each task to text file
            string fileName = $"{DateTime.Now:yyyyMMdd}_TimeTracker.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd}");
                writer.WriteLine($"Research: {_researchClock.GetTime()}");
                writer.WriteLine($"Teaching: {_teachingClock.GetTime()}");
                writer.WriteLine($"Lunch: {_lunchClock.GetTime()}");
            }

            // Close the program
            this.Close();
        }

        private void UpdateClockLabels()
        {
            // Update clock labels with current time
            clockLabel.Text = _clockDisplay.GetTime();
            researchLabel.Text = _researchClock.GetTime();
            teachingLabel.Text = _teachingClock.GetTime();
            lunchLabel.Text = _lunchClock.GetTime();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // Update clock display every second
            _clockDisplay.TimeTick();
            UpdateClockLabels();
        }
    }
}