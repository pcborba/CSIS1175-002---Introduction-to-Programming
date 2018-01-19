namespace Demo9Week3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHrs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBCAA = new System.Windows.Forms.RadioButton();
            this.radGovt = new System.Windows.Forms.RadioButton();
            this.radNA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.chkGPS = new System.Windows.Forms.CheckBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentalRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(246, 12);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(93, 53);
            this.btnDateTime.TabIndex = 2;
            this.btnDateTime.Text = "DateTime Var";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(409, 29);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(69, 20);
            this.txtDays.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Days";
            // 
            // btnPayroll
            // 
            this.btnPayroll.Location = new System.Drawing.Point(12, 84);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(97, 44);
            this.btnPayroll.TabIndex = 5;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hourly Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(193, 97);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(69, 20);
            this.txtRate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hrs worked";
            // 
            // txtHrs
            // 
            this.txtHrs.Location = new System.Drawing.Point(360, 97);
            this.txtHrs.Name = "txtHrs";
            this.txtHrs.Size = new System.Drawing.Size(69, 20);
            this.txtHrs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Payment";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(588, 25);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(69, 20);
            this.txtPayment.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNA);
            this.groupBox1.Controls.Add(this.radGovt);
            this.groupBox1.Controls.Add(this.radBCAA);
            this.groupBox1.Location = new System.Drawing.Point(17, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // radBCAA
            // 
            this.radBCAA.AutoSize = true;
            this.radBCAA.Location = new System.Drawing.Point(16, 19);
            this.radBCAA.Name = "radBCAA";
            this.radBCAA.Size = new System.Drawing.Size(53, 17);
            this.radBCAA.TabIndex = 0;
            this.radBCAA.TabStop = true;
            this.radBCAA.Text = "BCAA";
            this.radBCAA.UseVisualStyleBackColor = true;
            // 
            // radGovt
            // 
            this.radGovt.AutoSize = true;
            this.radGovt.Location = new System.Drawing.Point(76, 19);
            this.radGovt.Name = "radGovt";
            this.radGovt.Size = new System.Drawing.Size(48, 17);
            this.radGovt.TabIndex = 1;
            this.radGovt.TabStop = true;
            this.radGovt.Text = "Govt";
            this.radGovt.UseVisualStyleBackColor = true;
            // 
            // radNA
            // 
            this.radNA.AutoSize = true;
            this.radNA.Location = new System.Drawing.Point(130, 19);
            this.radNA.Name = "radNA";
            this.radNA.Size = new System.Drawing.Size(40, 17);
            this.radNA.TabIndex = 2;
            this.radNA.TabStop = true;
            this.radNA.Text = "NA";
            this.radNA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGPS);
            this.groupBox2.Controls.Add(this.chkInsurance);
            this.groupBox2.Location = new System.Drawing.Point(21, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(27, 27);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(73, 17);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "Insurance";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point(105, 27);
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size(48, 17);
            this.chkGPS.TabIndex = 1;
            this.chkGPS.Text = "GPS";
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(470, 84);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(97, 44);
            this.btnCompute.TabIndex = 14;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Daily Rate";
            // 
            // txtRentalRate
            // 
            this.txtRentalRate.Location = new System.Drawing.Point(294, 160);
            this.txtRentalRate.Name = "txtRentalRate";
            this.txtRentalRate.Size = new System.Drawing.Size(69, 20);
            this.txtRentalRate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rental Days";
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(294, 197);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(69, 20);
            this.txtRentalDays.TabIndex = 17;
            // 
            // lstInvoice
            // 
            this.lstInvoice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 16;
            this.lstInvoice.Location = new System.Drawing.Point(389, 159);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(363, 116);
            this.lstInvoice.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 330);
            this.Controls.Add(this.lstInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRentalDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRentalRate);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNA;
        private System.Windows.Forms.RadioButton radGovt;
        private System.Windows.Forms.RadioButton radBCAA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRentalRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.ListBox lstInvoice;
    }
}

