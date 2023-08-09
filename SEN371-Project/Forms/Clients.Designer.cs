namespace SEN371_Project
{
    partial class Clients
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(56, 41);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(99, 38);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Client Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(56, 100);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(99, 38);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "Call History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(74, 142);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 27);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 180);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clients";
            this.Text = "Clients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBack;
    }
}