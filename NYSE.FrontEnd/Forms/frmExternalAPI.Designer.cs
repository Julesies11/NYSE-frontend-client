namespace NYSE.FrontEnd
{
    partial class frmExternalAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExternalAPI));
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.AccessibleDescription = "Sunrise/Sunset times";
            this.txtText.AccessibleName = "Show Sunrise/Sunset times";
            this.txtText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(13, 89);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(922, 372);
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
            // btnUser
            // 
            this.btnUser.AccessibleDescription = "Load dummy User data";
            this.btnUser.AccessibleName = "Load dummy User data";
            this.btnUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(13, 39);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(235, 44);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "&Load dummy User data";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnSunrise_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AccessibleDescription = "Feedback";
            this.lblFeedback.AccessibleName = "Feedback";
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(256, 67);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(46, 16);
            this.lblFeedback.TabIndex = 14;
            this.lblFeedback.Text = "Output";
            // 
            // frmExternalAPI
            // 
            this.AcceptButton = this.btnUser;
            this.AccessibleDescription = "Dummy User data from external API";
            this.AccessibleName = "Dummy User data from external API";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(948, 476);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.txtText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExternalAPI";
            this.Text = "Dummy User data from external API";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExternalAPI_FormClosed);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblHelp, 0);
            this.Controls.SetChildIndex(this.txtText, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            this.Controls.SetChildIndex(this.btnUser, 0);
            this.Controls.SetChildIndex(this.lblFeedback, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblFeedback;
    }
}
