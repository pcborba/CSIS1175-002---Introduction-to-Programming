namespace Demo2Week3
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblHoursDec = new System.Windows.Forms.Label();
            this.txtDecHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoursJan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Regular hrs worked:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(554, 85);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(132, 22);
            this.txtHours.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pay Rate";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(554, 227);
            this.txtPayRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(132, 22);
            this.txtPayRate.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(356, 268);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 28);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblHoursDec
            // 
            this.lblHoursDec.AutoSize = true;
            this.lblHoursDec.Location = new System.Drawing.Point(352, 120);
            this.lblHoursDec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoursDec.Name = "lblHoursDec";
            this.lblHoursDec.Size = new System.Drawing.Size(146, 17);
            this.lblHoursDec.TabIndex = 7;
            this.lblHoursDec.Text = "Hrs worked dec 25th :";
            // 
            // txtDecHours
            // 
            this.txtDecHours.Location = new System.Drawing.Point(554, 115);
            this.txtDecHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecHours.Name = "txtDecHours";
            this.txtDecHours.Size = new System.Drawing.Size(132, 22);
            this.txtDecHours.TabIndex = 8;
            //this.txtDecHours.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hrs worked jan 1st:";
            // 
            // txtHoursJan
            // 
            this.txtHoursJan.Location = new System.Drawing.Point(554, 145);
            this.txtHoursJan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoursJan.Name = "txtHoursJan";
            this.txtHoursJan.Size = new System.Drawing.Size(132, 22);
            this.txtHoursJan.TabIndex = 8;
            //this.txtHoursJan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 411);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtHoursJan);
            this.Controls.Add(this.txtDecHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHoursDec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblHoursDec;
        private System.Windows.Forms.TextBox txtDecHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoursJan;
    }
}

