using ExternalAPI;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NYSE.FrontEnd
{
    public partial class frmExternalAPI : frmMain
    {
        public frmExternalAPI()
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

        private void frmExternalAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            // show the main menu
            try { 

                this.Owner.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSunrise_Click(object sender, EventArgs e)
        {
            // on click load data from external API
            try
            {
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;

                // blank out past text in control
                this.txtText.Text = null;

                // show wait message
                string msg = "Loading data from external API. Please wait...";
                SetValidationText(true, msg);

                // get data via an API call
                User u = await Api.GetUser();

                StringBuilder result = new StringBuilder();

                result.AppendLine("Dummy User data");
                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                result.AppendLine("id: " + u.id);
                result.AppendLine("userId: " + u.userId);
                result.AppendLine("title: " + u.title);
                result.AppendLine("completed: " + u.completed);

                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                this.txtText.Text = result.ToString();

                // show success message
                msg = "Success. User data from external API.";
                SetValidationText(true, msg);

                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                if (ex.Message == "InternalServerError")
                {
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    string msg = "API error.";
                    SetValidationText(false, msg);
                    MessageBox.Show("An internal server error has occurred.");
                }
                else if (ex.Message == "An error occurred while sending the request.")
                {
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    string msg = "API connection error.";
                    SetValidationText(false, msg);
                    MessageBox.Show("An error occurred with the following error message: '" + ex.Message + "'" + Environment.NewLine + Environment.NewLine + "The possible cause is not being able to connect to the API service. Make sure the service is running.");
                }
                else
                {
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    string msg = "API error.";
                    SetValidationText(false, msg);
                    MessageBox.Show(ex.Message);
                }

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
    }
}
