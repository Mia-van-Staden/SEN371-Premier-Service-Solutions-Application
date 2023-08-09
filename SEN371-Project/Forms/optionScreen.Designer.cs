namespace SEN371_Project
{
    partial class optionScreen
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
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(121, 64);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(94, 46);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Emloyees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(121, 130);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(94, 46);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(121, 201);
            this.btnJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(94, 46);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // optionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "optionScreen";
            this.Text = "Option Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Label label1;
    }
}