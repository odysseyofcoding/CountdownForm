using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerUebungApp
{
    public partial class FrmTimer : Form
    {
        int h, m, s;
        long totalSeconds;
        long timeLeft;

        public FrmTimer()
        {
            InitializeComponent();
        }

        private void FrmTimer_load(object sender, EventArgs e)
        {
            lblTimerAnzeige.Location = new Point((ClientSize.Width - lblTimerAnzeige.Width) / 2, pnlControls.Location.Y - 5 - pnlControls.Height);

            pnlControls.Width = lblTimerAnzeige.Width;
            pnlControls.Location = new Point((ClientSize.Width - pnlControls.Width) / 2, (ClientSize.Height - pnlControls.Height) / 2);
            
            lblHours.Location = new Point((pnlControls.Width - lblHours.Width) /3);
            numHour.Location = new Point((pnlControls.Width - numHour.Width) / 3, lblHours.Location.Y + numHour.Height + 5 );

            lblMinutues.Location = new Point((pnlControls.Width - lblMinutues.Width)/3 + lblMinutues.Width + 5 );
            numMinutues.Location = new Point((pnlControls.Width - numMinutues.Width)/3 + lblMinutues.Width + 5, lblHours.Location.Y + numMinutues.Height + 5);

            lblSeconds.Location = new Point((pnlControls.Width - lblSeconds.Width) / 3 + lblSeconds.Width*2 + 10);
            numSeconds.Location = new Point((pnlControls.Width - numSeconds.Width) / 3 + lblSeconds.Width * 2 + 10, lblHours.Location.Y + numSeconds.Height + 5);

            btnTimerStartStopContinue.Location = new Point((pnlControls.Width - btnTimerStartStopContinue.Width) / 3, numSeconds.Location.Y + btnTimerStartStopContinue.Height + 5);
            btnReset.Location = new Point(btnTimerStartStopContinue.Location.X + 5 + btnReset.Width, btnTimerStartStopContinue.Location.Y);
            btnReset.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            cmpTimer.Stop();
            ResetLabel();
            numHour.Value = 0;
            numSeconds.Value = 0;
            numMinutues.Value = 0;
            btnTimerStartStopContinue.Text = "Start";
            
        }

        private void btnTimerStartStop_Click(object sender, EventArgs e)
        {
           
            if (btnTimerStartStopContinue.Text == "Stop")
            {
                btnReset.Enabled = true;
                btnTimerStartStopContinue.Text = "Continue";
                cmpTimer.Stop();
            }
            else if(btnTimerStartStopContinue.Text == "Continue")
            {
                btnTimerStartStopContinue.Text = "Stop";
                btnReset.Enabled = false;
                totalSeconds = timeLeft;
                cmpTimer.Start();

            }
            else
            {
                if (numHour.Value == 0 && numMinutues.Value == 0 && numSeconds.Value == 0)
                {
                    MessageBox.Show("Please insert Value to count");
                }
                else
                {
                    btnTimerStartStopContinue.Text = "Stop";


                    h = Convert.ToInt32(numHour.Value);
                    m = Convert.ToInt32(numMinutues.Value);
                    s = Convert.ToInt32(numSeconds.Value);
                    totalSeconds = ((h * 60 * 60) + (m * 60) + s);
                    cmpTimer.Start();
                }

            }

        }
        private void CmpTimer_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            lblTimerAnzeige.Text = time.ToString(@"dd\d\:hh\h\:mm\m\:ss\s");
            if (totalSeconds == 0)
            {
                cmpTimer.Stop();
                MessageBox.Show("Time Up");
                ResetLabel();
                btnTimerStartStopContinue.Text = "Start";
            }
            timeLeft = totalSeconds;
        }
        private void ResetLabel()
        {
            lblTimerAnzeige.Text = "00d:00h:00m:00s";
        }
    }
}
