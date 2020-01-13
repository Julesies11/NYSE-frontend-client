namespace NYSE.FrontEnd
{
    partial class frmServerInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerInfo));
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.AccessibleDescription = "Display Server Info";
            this.txtText.AccessibleName = "Display Server Info";
            this.txtText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(13, 147);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(922, 314);
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
            // btnInfo
            // 
            this.btnInfo.AccessibleDescription = "Show Server Info";
            this.btnInfo.AccessibleName = "Show Server Info";
            this.btnInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(13, 39);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(235, 44);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "Show Server &Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
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
            // updateTimer
            // 
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(13, 90);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(235, 22);
            this.txtCPU.TabIndex = 15;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(13, 118);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(235, 22);
            this.txtRAM.TabIndex = 16;
            // 
            // frmServerInfo
            // 
            this.AcceptButton = this.btnInfo;
            this.AccessibleDescription = "Server Info";
            this.AccessibleName = "Server Info";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(948, 476);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.txtText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmServerInfo";
            this.Text = "Server Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServerInfo_FormClosed);
            this.Controls.SetChildIndex(this.lblHeading, 0);
            this.Controls.SetChildIndex(this.lblHelp, 0);
            this.Controls.SetChildIndex(this.txtText, 0);
            this.Controls.SetChildIndex(this.lblFocus, 0);
            this.Controls.SetChildIndex(this.btnInfo, 0);
            this.Controls.SetChildIndex(this.lblFeedback, 0);
            this.Controls.SetChildIndex(this.txtCPU, 0);
            this.Controls.SetChildIndex(this.txtRAM, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtRAM;
    }
}
