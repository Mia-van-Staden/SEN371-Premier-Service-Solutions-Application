namespace SEN371_Project
{
    partial class Jobs
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
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(49, 29);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(222, 49);
            this.btnProgress.TabIndex = 0;
            this.btnProgress.Text = "Job Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(49, 99);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(222, 49);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(49, 170);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(222, 46);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(49, 236);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(222, 45);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Log New Job";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(96, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 383);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnProgress);
            this.Name = "Jobs";
            this.Text = "Jobs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnBack;
    }
}