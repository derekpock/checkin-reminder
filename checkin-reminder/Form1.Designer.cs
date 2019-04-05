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
            this.labElapsed = new System.Windows.Forms.Label();
            this.labElapsedDesc = new System.Windows.Forms.Label();
            this.labRemainDesc = new System.Windows.Forms.Label();
            this.labRemain = new System.Windows.Forms.Label();
            this.labFinishDesc = new System.Windows.Forms.Label();
            this.labFinish = new System.Windows.Forms.Label();
            this.labTarget = new System.Windows.Forms.Label();
            this.inputTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(11, 114);
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
            this.labStatus.Location = new System.Drawing.Point(9, 13);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(174, 13);
            this.labStatus.TabIndex = 1;
            this.labStatus.Text = "Elapsed long text long text long text";
            // 
            // labElapsed
            // 
            this.labElapsed.AutoSize = true;
            this.labElapsed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labElapsed.Location = new System.Drawing.Point(100, 52);
            this.labElapsed.Name = "labElapsed";
            this.labElapsed.Size = new System.Drawing.Size(56, 15);
            this.labElapsed.TabIndex = 2;
            this.labElapsed.Text = "0:00:00";
            // 
            // labElapsedDesc
            // 
            this.labElapsedDesc.AutoSize = true;
            this.labElapsedDesc.Location = new System.Drawing.Point(9, 53);
            this.labElapsedDesc.Name = "labElapsedDesc";
            this.labElapsedDesc.Size = new System.Drawing.Size(74, 13);
            this.labElapsedDesc.TabIndex = 3;
            this.labElapsedDesc.Text = "Elapsed Time:";
            // 
            // labRemainDesc
            // 
            this.labRemainDesc.AutoSize = true;
            this.labRemainDesc.Location = new System.Drawing.Point(8, 73);
            this.labRemainDesc.Name = "labRemainDesc";
            this.labRemainDesc.Size = new System.Drawing.Size(86, 13);
            this.labRemainDesc.TabIndex = 4;
            this.labRemainDesc.Text = "Time Remaining:";
            // 
            // labRemain
            // 
            this.labRemain.AutoSize = true;
            this.labRemain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemain.Location = new System.Drawing.Point(100, 72);
            this.labRemain.Name = "labRemain";
            this.labRemain.Size = new System.Drawing.Size(56, 15);
            this.labRemain.TabIndex = 5;
            this.labRemain.Text = "0:00:00";
            // 
            // labFinishDesc
            // 
            this.labFinishDesc.AutoSize = true;
            this.labFinishDesc.Location = new System.Drawing.Point(8, 93);
            this.labFinishDesc.Name = "labFinishDesc";
            this.labFinishDesc.Size = new System.Drawing.Size(75, 13);
            this.labFinishDesc.TabIndex = 6;
            this.labFinishDesc.Text = "Time Finished:";
            // 
            // labFinish
            // 
            this.labFinish.AutoSize = true;
            this.labFinish.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinish.Location = new System.Drawing.Point(100, 92);
            this.labFinish.Name = "labFinish";
            this.labFinish.Size = new System.Drawing.Size(42, 15);
            this.labFinish.TabIndex = 7;
            this.labFinish.Text = "16:40";
            // 
            // labTarget
            // 
            this.labTarget.AutoSize = true;
            this.labTarget.Location = new System.Drawing.Point(9, 33);
            this.labTarget.Name = "labTarget";
            this.labTarget.Size = new System.Drawing.Size(81, 13);
            this.labTarget.TabIndex = 8;
            this.labTarget.Text = "Today\'s Target:";
            // 
            // inputTarget
            // 
            this.inputTarget.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTarget.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputTarget.Location = new System.Drawing.Point(100, 29);
            this.inputTarget.Name = "inputTarget";
            this.inputTarget.Size = new System.Drawing.Size(42, 23);
            this.inputTarget.TabIndex = 9;
            this.inputTarget.TextChanged += new System.EventHandler(this.inputTarget_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 164);
            this.ControlBox = false;
            this.Controls.Add(this.inputTarget);
            this.Controls.Add(this.labTarget);
            this.Controls.Add(this.labFinish);
            this.Controls.Add(this.labFinishDesc);
            this.Controls.Add(this.labRemain);
            this.Controls.Add(this.labRemainDesc);
            this.Controls.Add(this.labElapsedDesc);
            this.Controls.Add(this.labElapsed);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.butCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label labElapsed;
        private System.Windows.Forms.Label labElapsedDesc;
        private System.Windows.Forms.Label labRemainDesc;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.Label labFinishDesc;
        private System.Windows.Forms.Label labFinish;
        private System.Windows.Forms.Label labTarget;
        private System.Windows.Forms.TextBox inputTarget;
    }
}

