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
    public partial class frmEditRecord : frmMain
    {
        bool recordSavedYN = false;

        public frmEditRecord()
        {
            // initialise controls
            try
            {

                InitializeComponent();

                // normal window state
                this.WindowState = FormWindowState.Normal;

                // initialise controls
                InitPriceListCombo(false); // load top 1000 records into select list
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
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void InitPriceListCombo(bool savePositionYN)
        {
            // load list of Daily Prices from database via API
            // if savePositionYN==true it will do back to previous value
            try
            {

                // turn off the event handler that goes to selected record
                this.cboPrice.SelectedIndexChanged -= new EventHandler(cboPrice_SelectedIndexChanged);

                // get list from the database via an API call. show top 1000 only
                IEnumerable<DailyPrice> priceList = await Api.GetDailyPrices(Convert.ToInt32(1000));
                
                List<comboSource> _items = new List<comboSource>();
                string display;

                // first add a null value to list
                display = "Select Daily Price...";
                _items.Add(new comboSource { Id = -1, Display = display });

                // add all prices from database
                foreach (var item in priceList)
                {
                    display = item.stock_symbol + " " + item.date.ToString("dd/MM/yyyy") + " " + item.stock_price_close.ToString();
                    _items.Add(new comboSource { Id = item.Id, Display = display });
                }

                // 

                // set the datasource
                ComboBox cbo = this.cboPrice;
                int currentIndex = cboPrice.SelectedIndex;
                cbo.DataSource = _items;
                cbo.ValueMember = "Id";
                cbo.DisplayMember = "Display";

                // turn on the event handler that goes to selected record
                this.cboPrice.SelectedIndexChanged += new EventHandler(cboPrice_SelectedIndexChanged);

                // go tback to current record
                if (savePositionYN)
                {
                    cbo.SelectedIndex = currentIndex;
                }


            }
            catch (Exception ex)
            {
                this.cboPrice.SelectedIndexChanged += new EventHandler(cboPrice_SelectedIndexChanged);

                if (ex.Message == "InternalServerError")
                {
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    string msg = "API error.";
                    SetValidationText(false, msg);
                    MessageBox.Show("An internal server error has occurred");
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

        private void ClearControls()
        {
            // clear all values from form controls

            try
            {
                // clear controls
                //this.dateTimePicker.CustomFormat = "";
                this.txtSymbol.Text = String.Empty;
                this.txtOpen.Text = String.Empty;
                this.txtClose.Text = String.Empty;
                this.txtLow.Text = String.Empty;
                this.txtHigh.Text = String.Empty;
                this.txtAdjClose.Text = String.Empty;
                this.txtVolume.Text = String.Empty;

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

                // check that an item has been selected
                if (this.cboPrice.SelectedIndex == -1 || this.cboPrice.SelectedIndex == 0)
                {
                    msg = "Validation Error. Please select a Daily Price from the drop list.";
                    cboPrice.Focus();
                    SetValidationText(false, msg);
                    return;
                }

                int id;
                if (!int.TryParse(this.cboPrice.SelectedValue.ToString(), out id))
                {
                    msg = "Validation Error. Please select a Daily Price from the drop list.";
                    cboPrice.Focus();
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
                dailyPrice.Id = id;
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
                DailyPrice outputPrice = await Api.UpdateDailyPrice(dailyPrice);

                // refresh the combobox and go back to current record
                InitPriceListCombo(true);

                // show success message
                msg = "Success. Daily Price record successfully saved to database.";
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
        private void priceAdded1(object sender, EventArgs e)
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

        private void GoToRecord(DailyPrice price)
        {

            // set the control values for a daily price record

            try
            {
                // show record
                this.dateTimePicker.Value = Convert.ToDateTime(price.date);
                this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
                this.txtSymbol.Text = price.stock_symbol;
                this.txtOpen.Text = price.stock_price_open.ToString();
                this.txtClose.Text = price.stock_price_close.ToString();
                this.txtLow.Text = price.stock_price_low.ToString();
                this.txtHigh.Text = price.stock_price_high.ToString();
                this.txtAdjClose.Text = price.stock_price_adj_close.ToString();
                this.txtVolume.Text = price.stock_volume.ToString();

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

        private void frmEditRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            // on close of form show the main menu
            this.Owner.Show();
        }


        private async void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fill out form with selected price data
            try
            {
                // check that an item has been selected
                var id = 0;
                if (this.cboPrice.SelectedIndex == -1 || this.cboPrice.SelectedValue.ToString() == "-1")
                {
                    // nothing selected, return
                    ClearControls(); // clear all control values
                    return;
                }

                // check that selected value is integer
                if (!int.TryParse(this.cboPrice.SelectedValue.ToString(), out id))
                {
                    // if not return
                    // clear controls
                    ClearControls(); // clear all control values
                    return;
                }

                // get the record from database via API
                DailyPrice outputPrice = await Api.GetDailyPrice(id);

                // clear controls
                ClearControls();

                // show record
                GoToRecord(outputPrice);

                // set the focus
                this.txtSymbol.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            // fill out form with selected price data
            try
            {
                string msg = "";

                // check that an item has been selected
                if (this.cboPrice.SelectedIndex == -1 || this.cboPrice.SelectedIndex == 0)
                {
                    // if not return
                    // clear controls
                    ClearControls();
                    msg = "Error. Nothing to cancel";
                    SetValidationText(false, msg);
                    this.cboPrice.Focus();
                    return;
                }

                // check that an item has been selected
                int id;
                if (!int.TryParse(this.cboPrice.SelectedValue.ToString(), out id))
                {
                    // if not return
                    // clear controls
                    ClearControls();
                    msg = "Error. Nothing to cancel";
                    SetValidationText(false, msg);
                    this.cboPrice.Focus();
                    return;
                }

                // get the orignial record from database via API
                DailyPrice outputPrice = await Api.GetDailyPrice(id);

                // show record
                GoToRecord(outputPrice);

                // set the focus
                this.txtSymbol.Focus();

                // show success message
                msg = "The form has been reset to original values";
                SetValidationText(true, msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // fill out form with selected price data
            try
            {
                string msg = "";

                // check that an item has been selected
                if (this.cboPrice.SelectedIndex == -1 || this.cboPrice.SelectedIndex == 0)
                {
                    // if not return
                    // clear controls
                    ClearControls();
                    msg = "Error. Select a Daily Price from the list first";
                    SetValidationText(false, msg);
                    this.cboPrice.Focus();
                    return;
                }

                // check that item selected is a real value
                int id;
                if (!int.TryParse(this.cboPrice.SelectedValue.ToString(), out id))
                {
                    // if not return
                    // clear controls
                    ClearControls();
                    msg = "Error. Select a Daily Price from the list first";
                    SetValidationText(false, msg);
                    this.cboPrice.Focus();
                    return;
                }

                // delete the record from database via API
                DailyPrice outputPrice = await Api.DeleteDailyPrice(id);

                // show blank record on screen
                ClearControls();

                // refresh the drop list
                InitPriceListCombo(false);

                // clear the select price drop list
                this.cboPrice.ResetText();
                this.cboPrice.SelectedIndex = -1;

                this.dateTimePicker.CustomFormat = " ";

                // set the focus
                this.txtSymbol.Focus();

                // show success message
                msg = "Success. The Daily Price record has been deleted from database ";
                SetValidationText(true, msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class comboSource
    {
        // class to act as source of main select price drop list

        public int Id { get; set; }
        public string Display { get; set; }
    }


}

