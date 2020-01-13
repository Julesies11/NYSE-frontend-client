namespace NYSE.FrontEnd
{
    partial class frmLoadFromDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadFromDatabase));
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.lblNumTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.AccessibleDescription = "All daily prices saved in database";
            this.txtText.AccessibleName = "All daily prices in database";
            this.txtText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(13, 150);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(922, 311);
            this.txtText.TabIndex = 12;
            this.txtText.TabStop = false;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(163, 39);
            this.lblFocus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 16);
            this.lblFocus.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleDescription = "Load all Daily Prices from database";
            this.btnLoad.AccessibleName = "Load from database";
            this.btnLoad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(13, 98);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 44);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load from &Database";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AccessibleDescription = "Feedback";
            this.lblFeedback.AccessibleName = "Feedback";
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(189, 126);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(46, 16);
            this.lblFeedback.TabIndex = 14;
            this.lblFeedback.Text = "Output";
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(13, 69);
            this.numTop.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(168, 22);
            this.numTop.TabIndex = 15;
            this.numTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTop.ThousandsSeparator = true;
            this.numTop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblNumTop
            // 
            this.lblNumTop.AutoSize = true;
            this.lblNumTop.Location = new System.Drawing.Point(12, 50);
            this.lblNumTop.Name = "lblNumTop";
            this.lblNumTop.Size = new System.Drawing.Size(154, 16);
            this.lblNumTop.TabIndex = 16;
            this.lblNumTop.Text = "Return TOP (N) Records";
            // 
            // frmLoadFromDatabase
            // 
            this.AcceptButton = this.btnLoad;
            this.AccessibleDescription = "Load Daily Prices from database";
            this.AccessibleName = "Load Daily Prices from database";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(948, 476);
            this.Controls.Add(this.lblNumTop);
            this.Controls.Add(this.numTop);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.txtText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLoadFromDatabase";
            this.Text = "Load Daily Prices from database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoadFromDatabase_FormClosed);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblHelp, 0);
            this.Controls.SetChildIndex(this.txtText, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            this.Controls.SetChildIndex(this.btnLoad, 0);
            this.Controls.SetChildIndex(this.lblFeedback, 0);
            this.Controls.SetChildIndex(this.numTop, 0);
            this.Controls.SetChildIndex(this.lblNumTop, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.Label lblNumTop;
    }
}
