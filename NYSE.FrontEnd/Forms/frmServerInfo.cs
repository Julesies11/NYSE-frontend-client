using ExternalAPI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NYSE.FrontEnd
{
    public partial class frmServerInfo : frmMain
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        public frmServerInfo()
        {
            // initialise controls
            try
            {

                InitializeComponent();

                // normal window state
                this.WindowState = FormWindowState.Normal;

                // hide heading labels
                this.lblHeading.Visible = false;
                this.lblHelp.Visible = false;
                this.lblFeedback.Visible = false;

                this.txtText.ScrollBars = ScrollBars.Vertical;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void InitialiseTimer()
        {
            // start the timer
            try
            {

                updateTimer.Enabled = true;
                updateTimer.Interval = 500;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitialiseCPUCounter()
        {
            // init CPU counter
            try
            {

                cpuCounter = new PerformanceCounter(
                "Processor",
                "% Processor Time",
                "_Total",
                true
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRAMCounter()
        {
            // init RAM counter
            try
            {
                ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            // on timer update the CPU and RAM usage
            try
            {

                this.txtCPU.Text = "CPU Usage: " + Convert.ToInt32(cpuCounter.NextValue()).ToString() +"%";

                this.txtRAM.Text = "RAM Usage: " + Convert.ToInt32(ramCounter.NextValue()).ToString() + " MB";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetTotalFreeSpace()
        {
            string result = string.Empty;
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (result == string.Empty)
                    result = "Drive: " + d.Name;
                else
                    result += Environment.NewLine + "Drive: " + d.Name;

                result += Environment.NewLine + "  - File type: " + d.DriveType;

                if (d.IsReady == true)
                {
                    result += Environment.NewLine + "  - Volume label: " + d.VolumeLabel;
                    result += Environment.NewLine + "  - File system: " + d.DriveFormat;
                    result += Environment.NewLine + "  - Available space: " + d.AvailableFreeSpace / 1000000 + " MB";
                    result += Environment.NewLine + "  - Total size of drive: " + d.TotalSize / 1000000 + " MB";
                }
            }

            return result;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // on click show Server Info
            try
            {
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;

                // blank out past text in control
                this.txtText.Text = null;

                // show wait message
                string msg = "Loading Server Info. Please wait...";
                SetValidationText(true, msg);

                // init counters
                InitialiseCPUCounter();
                InitializeRAMCounter();
                InitialiseTimer();

                // start timer to calc RAM and CPU
                updateTimer.Start();

                // get HDD info
                StringBuilder result = new StringBuilder();
                
                result.AppendLine(" -- HDD info --");
                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                result.AppendLine(GetTotalFreeSpace());
                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                this.txtText.Text = result.ToString();

                // show success message
                msg = "Success. Server Info listed";
                SetValidationText(true, msg);

                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;

                string msg = "Error";
                SetValidationText(false, msg);
                MessageBox.Show(ex.Message);
            }

        }


        private void SetValidationText(bool success, string text)
        {
            // show or hide the validation label

            try
            {

                Label lbl = this.lblFeedback;

                if (success)
                {
                    lbl.BackColor = Color.LightGreen;
                    lbl.ForeColor = Color.Black;
                }
                else
                {
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.White;
                }

                // display the message to user
                lbl.Text = text;
                lbl.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmServerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // show the main menu
            try
            {
                this.Owner.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
