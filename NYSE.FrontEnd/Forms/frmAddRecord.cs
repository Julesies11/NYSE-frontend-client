using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NYSE.BusinessLayer;
using System.Net;

namespace NYSE.FrontEnd
{
    public partial class frmAddRecord : frmMain
    {
        bool recordSavedYN = false;

        public frmAddRecord()
        {
            // initialise controls
            try
            {

                InitializeComponent();

                // normal window state
                this.WindowState = FormWindowState.Normal;

                // initialise controls
                InitDateTimePicker();
                InitTypeCombo();
                this.lblFeedback.Visible = false;
                this.lblHeading.Visible = false;
                this.lblHelp.Visible = false;

                // set the focus
                this.txtSymbol.Focus();

                // Set the accept button of the form to btnSubmit.
                this.AcceptButton = this.btnSubmit;

                // Set the start position of the form to the center of the screen.
                this.StartPosition = FormStartPosition.CenterScreen;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitDateTimePicker()
        {
            // set and format the date time picker

            try
            {
                // format date picker
                DateTimePicker dateTimePicker1 = this.dateTimePicker;

                // Set the MinDate and MaxDate
                dateTimePicker1.MinDate = new DateTime(1995, 1, 1);
                dateTimePicker1.MaxDate = DateTime.Today;

                // Set the CustomFormat string
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitTypeCombo()
        {
            // format combo box

            try
            {
                // add the default value
                ComboBox cbo = cboExchange;
                cbo.Items.Add("NYSE");
                cbo.SelectedItem = "NYSE";

                // format the drop list. do not allow new items to be added
                this.cboExchange.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cboExchange.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cboExchange.DropDownStyle = ComboBoxStyle.DropDownList;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // submit the record to database via API

            try
            {
                string msg = "";
                DateTimePicker dteDate = this.dateTimePicker;
                ComboBox cboExchange = this.cboExchange;
                TextBox txtSymbol = this.txtSymbol;
                TextBox txtOpen = this.txtOpen;
                TextBox txtClose = this.txtClose;
                TextBox txtLow = this.txtLow;
                TextBox txtHigh = this.txtHigh;
                TextBox txtAdjClose = this.txtAdjClose;
                TextBox txtVolume = this.txtVolume;

                // validation
                // --------------------------------------------------------------------------------------------------------
                // validate if its been saved already
                if (recordSavedYN)
                {
                    msg = "Record has already been saved. Please click 'Add New Daily Price' to clear the form.";
                    dteDate.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate date
                if (dteDate == null || string.IsNullOrWhiteSpace(dteDate.Text))
                {
                    msg = "Validation Error. Please select the Date.";
                    dteDate.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate exchange
                if (cboExchange == null || string.IsNullOrWhiteSpace(cboExchange.Text))
                {
                    msg = "Validation Error. Please select the Exchange.";
                    cboExchange.Focus();
                    cboExchange.DroppedDown = true;
                    SetValidationText(false, msg);
                    return;
                }

                // validate stock symbol
                if (txtSymbol == null || string.IsNullOrWhiteSpace(txtSymbol.Text))
                {
                    msg = "Validation Error. Please enter a Stock Symbol.";
                    txtSymbol.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate open is not null
                if (txtOpen == null || string.IsNullOrWhiteSpace(txtOpen.Text))
                {
                    msg = "Validation Error. Please enter an Open Price.";
                    txtOpen.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // convert input to correct data type
                decimal deciOpen;
                decimal deciClose;
                decimal deciLow;
                decimal deciHigh;
                decimal deciAdjClose;
                int intVolume;

                // validate open is numeric
                if (!decimal.TryParse(txtOpen.Text, out deciOpen))
                {
                    msg = "Validation Error. Open Price must be numeric.";
                    txtOpen.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate close is not null
                if (txtClose == null || string.IsNullOrWhiteSpace(txtClose.Text))
                {
                    msg = "Validation Error. Please enter a Close Price.";
                    txtClose.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate close is numeric
                if (!decimal.TryParse(txtClose.Text, out deciClose))
                {
                    msg = "Validation Error. Close Price must be numeric.";
                    txtClose.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate low is not null
                if (txtLow == null || string.IsNullOrWhiteSpace(txtLow.Text))
                {
                    msg = "Validation Error. Please enter a Low Price.";
                    txtLow.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate low is numeric
                if (!decimal.TryParse(txtLow.Text, out deciLow))
                {
                    msg = "Validation Error. Low Price must be numeric.";
                    txtLow.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate high is not null
                if (txtHigh == null || string.IsNullOrWhiteSpace(txtHigh.Text))
                {
                    msg = "Validation Error. Please enter a High Price.";
                    txtHigh.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate high is numeric
                if (!decimal.TryParse(txtHigh.Text, out deciHigh))
                {
                    msg = "Validation Error. High Price must be numeric.";
                    txtHigh.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate adj close is not null
                if (txtAdjClose == null || string.IsNullOrWhiteSpace(txtAdjClose.Text))
                {
                    msg = "Validation Error. Please enter an Adjusted Close Price.";
                    txtAdjClose.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate adj close is numeric
                if (!decimal.TryParse(txtAdjClose.Text, out deciAdjClose))
                {
                    msg = "Validation Error. Adjusted Close must be numeric.";
                    txtAdjClose.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate volume is not null
                if (txtVolume == null || string.IsNullOrWhiteSpace(txtVolume.Text))
                {
                    msg = "Validation Error. Please enter Volume.";
                    txtVolume.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // validate volume is numeric
                if (!int.TryParse(txtVolume.Text, out intVolume))
                {
                    msg = "Validation Error. Volume must be a whole number only.";
                    txtVolume.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                // end validation
                // --------------------------------------------------------------------------------------------------------


                // no validation errors. create the object and pass object to API method to update database
                // --------------------------------------------------------------------------------------------------------
                // show wait message
                msg = "Please wait...";
                SetValidationText(true, msg);

                // create the object
                DailyPrice dailyPrice = new DailyPrice();
                dailyPrice.date = dteDate.Value;
                dailyPrice.stock_symbol = txtSymbol.Text;
                dailyPrice.stock_price_open = deciOpen;
                dailyPrice.stock_price_close = deciClose;
                dailyPrice.stock_price_low = deciLow;
                dailyPrice.stock_price_high = deciHigh;
                dailyPrice.stock_price_adj_close = deciAdjClose;
                dailyPrice.stock_volume = intVolume;
                dailyPrice.stock_exchange = cboExchange.Text;

                // save record to the database via an API call. pass in object. bject gets converted to JSON
                DailyPrice outputPrice = await Api.PostDailyPrice(dailyPrice);

                // show success message
                msg = "Success. Daily Price record successfully added to database.";
                SetValidationText(true, msg);

            }
            catch (Exception ex)
            {
                if (ex.Message == "InternalServerError")
                {
                    string msg = "API error.";
                    SetValidationText(false, msg);
                    MessageBox.Show("An error occurred. Please make sure the combination of 'Date', 'Exchange' & 'Stock Symbol' are unique.");
                }
                else if (ex.Message == "An error occurred while sending the request.")
                {
                    string msg = "API connection error.";
                    SetValidationText(false, msg);
                    MessageBox.Show("An error occurred with the following error message: '" + ex.Message + "'" + Environment.NewLine + Environment.NewLine + "The possible cause is not being able to connect to the API service. Make sure the service is running.");
                }
                else
                {
                    string msg = "API error.";
                    SetValidationText(false, msg);
                    MessageBox.Show(ex.Message);
                }

            }


        }

        // called from custom event
        public void priceAdded(object sender, EventArgs e)
        {

            // display message to user the price has been added successfully

            try
            {

                recordSavedYN = true; // flag it has been saved

                string msg = "Success. Daily Price created for: '" + txtSymbol.Text + "'";
                SetValidationText(true, msg);

            }
            catch (Exception ex)
            {
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

                // set the message to user and show label
                lbl.Text = text;
                lbl.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAddRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            // on close of form show the main menu
            this.Owner.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // clear the controls so user can add another record 
            try
            {

                // clear controls
                this.lblFeedback.Visible = false;
                this.txtSymbol.Text = String.Empty;
                this.txtOpen.Text = String.Empty;
                this.txtClose.Text = String.Empty;
                this.txtLow.Text = String.Empty;
                this.txtHigh.Text = String.Empty;
                this.txtAdjClose.Text = String.Empty;
                this.txtVolume.Text = String.Empty;

                // set the focus
                this.txtSymbol.Focus();

                // reset the flags used by custom events
                recordSavedYN = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}

