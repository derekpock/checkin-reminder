namespace checkin_reminder
{
    partial class Form1
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
            this.butCheck = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(12, 25);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(183, 41);
            this.butCheck.TabIndex = 0;
            this.butCheck.Text = "button1";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(12, 9);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(35, 13);
            this.labStatus.TabIndex = 1;
            this.labStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 78);
            this.ControlBox = false;
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.butCheck);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Checkin Reminder";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Label labStatus;
    }
}

