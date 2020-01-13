namespace NYSE.FrontEnd
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblHelp = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AccessibleDescription = "Help Description";
            this.lblHelp.AccessibleName = "Help Description";
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHelp.Location = new System.Drawing.Point(60, 113);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(839, 286);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // menuStripMain
            // 
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1177, 24);
            this.menuStripMain.TabIndex = 7;
            // 
            // lblHeading
            // 
            this.lblHeading.AccessibleDescription = "Heading";
            this.lblHeading.AccessibleName = "Heading";
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHeading.Location = new System.Drawing.Point(36, 69);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(345, 24);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Welcome to the NYSE application";
            // 
            // frmMain
            // 
            this.AccessibleDescription = "Main Menu";
            this.AccessibleName = "Main Menu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 445);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.MenuStrip menuStripMain;
        protected System.Windows.Forms.Label lblHeading;
    }
}