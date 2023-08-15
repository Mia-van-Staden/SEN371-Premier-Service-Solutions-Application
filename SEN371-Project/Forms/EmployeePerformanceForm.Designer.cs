namespace SEN371_Project.Forms
{
    partial class EmployeePerformanceForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(356, 319);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // solidGauge1
            // 
            this.solidGauge1.Location = new System.Drawing.Point(297, 140);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(200, 100);
            this.solidGauge1.TabIndex = 5;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.Location = new System.Drawing.Point(299, 243);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(0, 25);
            this.lblNameSurname.TabIndex = 7;
            this.lblNameSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Red;
            this.lblJob.Location = new System.Drawing.Point(340, 268);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(0, 25);
            this.lblJob.TabIndex = 8;
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeePerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.btnBack);
            this.Name = "EmployeePerformanceForm";
            this.Text = "EmployeePerformanceForm";
            this.Load += new System.EventHandler(this.EmployeePerformanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblJob;
    }
}