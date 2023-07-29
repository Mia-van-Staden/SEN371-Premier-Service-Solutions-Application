namespace SEN371_Project
{
    partial class Employess
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
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.Location = new System.Drawing.Point(89, 63);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(129, 60);
            this.btnEmpDetails.TabIndex = 0;
            this.btnEmpDetails.Text = "Employee Details";
            this.btnEmpDetails.UseVisualStyleBackColor = true;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.Location = new System.Drawing.Point(89, 169);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(129, 61);
            this.btnPerformance.TabIndex = 1;
            this.btnPerformance.Text = "Performance Reports";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // Employess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 325);
            this.Controls.Add(this.btnPerformance);
            this.Controls.Add(this.btnEmpDetails);
            this.Name = "Employess";
            this.Text = "Employess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnPerformance;
    }
}