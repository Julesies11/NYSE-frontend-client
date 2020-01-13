namespace NYSE.FrontEnd
{
    partial class frmEditRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditRecord));
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboExchange = new System.Windows.Forms.ComboBox();
            this.lblExchange = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblOpen = new System.Windows.Forms.Label();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.TextBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.lblAdjClose = new System.Windows.Forms.Label();
            this.txtAdjClose = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AccessibleDescription = "Feedback";
            this.lblFeedback.AccessibleName = "Feedback";
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(161, 52);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(87, 20);
            this.lblFeedback.TabIndex = 19;
            this.lblFeedback.Text = "Feedback text";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleDescription = "Save the Daily Price to the database";
            this.btnSubmit.AccessibleName = "Save button";
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Location = new System.Drawing.Point(165, 413);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 37);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "&Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboExchange
            // 
            this.cboExchange.AccessibleDescription = "Exchange selection list";
            this.cboExchange.AccessibleName = "Exchange selection list";
            this.cboExchange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboExchange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboExchange.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExchange.FormattingEnabled = true;
            this.cboExchange.Location = new System.Drawing.Point(165, 112);
            this.cboExchange.Margin = new System.Windows.Forms.Padding(4);
            this.cboExchange.Name = "cboExchange";
            this.cboExchange.Size = new System.Drawing.Size(304, 28);
            this.cboExchange.TabIndex = 10;
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchange.Location = new System.Drawing.Point(92, 115);
            this.lblExchange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(65, 20);
            this.lblExchange.TabIndex = 17;
            this.lblExchange.Text = "E&xchange";
            this.lblExchange.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(122, 148);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 20);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "&Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.AccessibleDescription = "Diary entry date";
            this.dateTimePicker.AccessibleName = "Date field";
            this.dateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(165, 148);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(304, 25);
            this.dateTimePicker.TabIndex = 11;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(73, 181);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(84, 20);
            this.lblSymbol.TabIndex = 19;
            this.lblSymbol.Text = "&Stock Symbol";
            // 
            // txtSymbol
            // 
            this.txtSymbol.AccessibleDescription = "Stock Symbol";
            this.txtSymbol.AccessibleName = "Stock Symbol text box";
            this.txtSymbol.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol.Location = new System.Drawing.Point(165, 181);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymbol.Multiline = true;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(304, 25);
            this.txtSymbol.TabIndex = 12;
            this.txtSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(117, 214);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(40, 20);
            this.lblOpen.TabIndex = 23;
            this.lblOpen.Text = "&Open";
            // 
            // txtOpen
            // 
            this.txtOpen.AccessibleDescription = "Stock Symbol";
            this.txtOpen.AccessibleName = "Stock Symbol text box";
            this.txtOpen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpen.Location = new System.Drawing.Point(165, 214);
            this.txtOpen.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpen.Multiline = true;
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(304, 25);
            this.txtOpen.TabIndex = 13;
            this.txtOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(116, 247);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(41, 20);
            this.lblClose.TabIndex = 25;
            this.lblClose.Text = "&Close";
            // 
            // txtClose
            // 
            this.txtClose.AccessibleDescription = "Stock Symbol";
            this.txtClose.AccessibleName = "Stock Symbol text box";
            this.txtClose.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose.Location = new System.Drawing.Point(165, 247);
            this.txtClose.Margin = new System.Windows.Forms.Padding(4);
            this.txtClose.Multiline = true;
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(304, 25);
            this.txtClose.TabIndex = 14;
            this.txtClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(125, 280);
            this.lblLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(32, 20);
            this.lblLow.TabIndex = 27;
            this.lblLow.Text = "&Low";
            // 
            // txtLow
            // 
            this.txtLow.AccessibleDescription = "Stock Symbol";
            this.txtLow.AccessibleName = "Stock Symbol text box";
            this.txtLow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLow.Location = new System.Drawing.Point(165, 280);
            this.txtLow.Margin = new System.Windows.Forms.Padding(4);
            this.txtLow.Multiline = true;
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(304, 25);
            this.txtLow.TabIndex = 15;
            this.txtLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(122, 314);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(35, 20);
            this.lblHigh.TabIndex = 29;
            this.lblHigh.Text = "&High";
            // 
            // txtHigh
            // 
            this.txtHigh.AccessibleDescription = "Stock Symbol";
            this.txtHigh.AccessibleName = "Stock Symbol text box";
            this.txtHigh.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(165, 314);
            this.txtHigh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHigh.Multiline = true;
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(304, 25);
            this.txtHigh.TabIndex = 16;
            this.txtHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdjClose
            // 
            this.lblAdjClose.AutoSize = true;
            this.lblAdjClose.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjClose.Location = new System.Drawing.Point(66, 347);
            this.lblAdjClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdjClose.Name = "lblAdjClose";
            this.lblAdjClose.Size = new System.Drawing.Size(91, 20);
            this.lblAdjClose.TabIndex = 31;
            this.lblAdjClose.Text = "&Adjusted Close";
            // 
            // txtAdjClose
            // 
            this.txtAdjClose.AccessibleDescription = "Stock Symbol";
            this.txtAdjClose.AccessibleName = "Stock Symbol text box";
            this.txtAdjClose.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjClose.Location = new System.Drawing.Point(165, 347);
            this.txtAdjClose.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdjClose.Multiline = true;
            this.txtAdjClose.Name = "txtAdjClose";
            this.txtAdjClose.Size = new System.Drawing.Size(304, 25);
            this.txtAdjClose.TabIndex = 17;
            this.txtAdjClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(106, 383);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 20);
            this.lblVolume.TabIndex = 33;
            this.lblVolume.Text = "&Volume";
            // 
            // txtVolume
            // 
            this.txtVolume.AccessibleDescription = "Stock Symbol";
            this.txtVolume.AccessibleName = "Stock Symbol text box";
            this.txtVolume.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(165, 380);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(304, 25);
            this.txtVolume.TabIndex = 18;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboPrice
            // 
            this.cboPrice.AccessibleDescription = "Daily Price selection list";
            this.cboPrice.AccessibleName = "Daily Price selection list";
            this.cboPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPrice.BackColor = System.Drawing.Color.PowderBlue;
            this.cboPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboPrice.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(165, 76);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(4);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(304, 26);
            this.cboPrice.TabIndex = 34;
            this.cboPrice.SelectedIndexChanged += new System.EventHandler(this.cboPrice_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(43, 77);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(114, 20);
            this.lblSelect.TabIndex = 35;
            this.lblSelect.Text = "&Select Daily Price";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "Delete the Daily Price";
            this.btnDelete.AccessibleName = "Delete button";
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(269, 413);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "Cancel entry";
            this.btnCancel.AccessibleName = "Cancel button";
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(373, 413);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditRecord
            // 
            this.AccessibleDescription = "Edit Existing Daily Price";
            this.AccessibleName = "Edit Existing Daily Price";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(948, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cboPrice);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblAdjClose);
            this.Controls.Add(this.txtAdjClose);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.cboExchange);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSymbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEditRecord";
            this.Text = "Edit Existing Daily Price";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditRecord_FormClosed);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblHelp, 0);
            this.Controls.SetChildIndex(this.txtSymbol, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.lblSymbol, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblExchange, 0);
            this.Controls.SetChildIndex(this.cboExchange, 0);
            this.Controls.SetChildIndex(this.lblFeedback, 0);
            this.Controls.SetChildIndex(this.txtOpen, 0);
            this.Controls.SetChildIndex(this.lblOpen, 0);
            this.Controls.SetChildIndex(this.txtClose, 0);
            this.Controls.SetChildIndex(this.lblClose, 0);
            this.Controls.SetChildIndex(this.txtLow, 0);
            this.Controls.SetChildIndex(this.lblLow, 0);
            this.Controls.SetChildIndex(this.txtHigh, 0);
            this.Controls.SetChildIndex(this.lblHigh, 0);
            this.Controls.SetChildIndex(this.txtAdjClose, 0);
            this.Controls.SetChildIndex(this.lblAdjClose, 0);
            this.Controls.SetChildIndex(this.txtVolume, 0);
            this.Controls.SetChildIndex(this.lblVolume, 0);
            this.Controls.SetChildIndex(this.cboPrice, 0);
            this.Controls.SetChildIndex(this.lblSelect, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblFeedback;
        protected System.Windows.Forms.Button btnSubmit;
        protected System.Windows.Forms.ComboBox cboExchange;
        protected System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.Label lblExchange;
        protected System.Windows.Forms.DateTimePicker dateTimePicker;
        protected System.Windows.Forms.Label lblSymbol;
        protected System.Windows.Forms.TextBox txtSymbol;
        protected System.Windows.Forms.Label lblOpen;
        protected System.Windows.Forms.TextBox txtOpen;
        protected System.Windows.Forms.Label lblClose;
        protected System.Windows.Forms.TextBox txtClose;
        protected System.Windows.Forms.Label lblLow;
        protected System.Windows.Forms.TextBox txtLow;
        protected System.Windows.Forms.Label lblHigh;
        protected System.Windows.Forms.TextBox txtHigh;
        protected System.Windows.Forms.Label lblAdjClose;
        protected System.Windows.Forms.TextBox txtAdjClose;
        protected System.Windows.Forms.Label lblVolume;
        protected System.Windows.Forms.TextBox txtVolume;
        protected System.Windows.Forms.ComboBox cboPrice;
        protected System.Windows.Forms.Label lblSelect;
        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.Button btnCancel;
    }
}
