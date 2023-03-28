using System;
using System.Windows.Forms;

namespace Research_Timer
{
    public partial class MainForm : Form
    {
        private readonly Timer researchTimer;
        private int remainingTime;

        public MainForm()
        {
            InitializeComponent();

            researchTimer = new Timer();
            researchTimer.Interval = 1000;
            researchTimer.Tick += ResearchTimer_Tick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(durationTextBox.Text, out int duration))
            {
                remainingTime = duration;
                researchTimer.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            researchTimer.Stop();
            remainingTime = 0;
            UpdateTimerLabels();
        }

        private void ResearchTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            UpdateTimerLabels();

            if (remainingTime == 0)
            {
                researchTimer.Stop();
            }
        }

        private void UpdateTimerLabels()
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingTime);
            remainingTimeLabel.Text = time.ToString(@"mm\:ss");
            elapsedTimeLabel.Text = time.ToString(@"mm\:ss");
        }
    }
}
