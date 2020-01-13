using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NYSE.BusinessLayer;
using System.Linq;

namespace NYSE.FrontEnd
{
    public partial class frmLoadFromDatabase : frmMain
    {
        public frmLoadFromDatabase()
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

        private void frmLoadFromDatabase_FormClosed(object sender, FormClosedEventArgs e)
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

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            // on click load data from database via API
            try
            {
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;

                // blank out past text in control
                this.txtText.Text = null;

                // show wait message
                string msg = "Loading all records from database. Please wait...";
                SetValidationText(true, msg);

                // get list from the database via an API call
                IEnumerable<DailyPrice> priceList = await Api.GetDailyPrices(Convert.ToInt32(this.numTop.Value));
                var priceListOrdered = priceList.OrderByDescending(x => x.date);

                StringBuilder result = new StringBuilder();

                int count = priceListOrdered.Count();
                result.AppendLine("Daily Price Report. Number of records = " + count);
                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                foreach (var price in priceListOrdered)
                {
                    result.AppendLine(
                        "DATE: " + price.date.ToString("dd/MM/yyyy ")
                        + " SYMBOL: " + price.stock_symbol
                        + " HIGH: " + price.stock_price_high
                        + " LOW: " + price.stock_price_low.ToString()
                        + " OPEN: " + price.stock_price_open
                        + " CLOSE: " + price.stock_price_adj_close
                        + " ADJ. CLOSE: " + price.stock_price_adj_close
                        + " VOLUME: " + price.stock_volume
                        + " EXCHANGE: " + price.stock_exchange
                    );
                }

                if (count == 0)
                {
                    result.AppendLine("No results. Please 'Add' daily prices first");
                }

                result.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                this.txtText.Text = result.ToString();

                // show success message
                msg = "Success. Daily Price records successfully loaded from database.";
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


        //private void DisplayEntries(NYSE ny)
        //{
        //    // display all entries stored in Diary object

        //    try
        //    {

        //        string result = ny.GetAllPrices();
        //        string msg = "";
        //        string dte = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss");

        //        if (result.Length == 0)
        //        {
        //            this.txtText.Text = "No entries exist in the XML file. Create an XML file first";
        //            msg = "No entries exist in the XML file. Create an XML file first";
        //        }
        //        else
        //        {
        //            this.txtText.Text = result;
        //            msg = "Data loaded from XML into Diary object. Displayed is a list of all entries contained in the object";
        //        }

        //        // show user a message
        //        SetValidationText(true, msg);

        //    }
        //    catch (Exception ex)
        //    {
        //        SetValidationText(false, "Error");
        //        MessageBox.Show(ex.Message);
        //    }

        //}


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
