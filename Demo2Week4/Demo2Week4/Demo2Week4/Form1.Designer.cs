namespace Demo2Week4
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstRental = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNA = new System.Windows.Forms.RadioButton();
            this.radGovt = new System.Windows.Forms.RadioButton();
            this.radBCAA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGPS = new System.Windows.Forms.CheckBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQ4 = new System.Windows.Forms.TextBox();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBavg = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.btnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
//            this.button2.Click += new System.EventHandler(this.btnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
//            this.button3.Click += new System.EventHandler(this.btnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Daily Rate:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(311, 237);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(311, 271);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 6;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(311, 194);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(61, 37);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstRental
            // 
            this.lstRental.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRental.FormattingEnabled = true;
            this.lstRental.ItemHeight = 16;
            this.lstRental.Location = new System.Drawing.Point(12, 362);
            this.lstRental.Name = "lstRental";
            this.lstRental.Size = new System.Drawing.Size(399, 180);
            this.lstRental.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNA);
            this.groupBox1.Controls.Add(this.radGovt);
            this.groupBox1.Controls.Add(this.radBCAA);
            this.groupBox1.Location = new System.Drawing.Point(17, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // radNA
            // 
            this.radNA.AutoSize = true;
            this.radNA.Location = new System.Drawing.Point(151, 13);
            this.radNA.Name = "radNA";
            this.radNA.Size = new System.Drawing.Size(40, 17);
            this.radNA.TabIndex = 2;
            this.radNA.TabStop = true;
            this.radNA.Text = "NA";
            this.radNA.UseVisualStyleBackColor = true;
            // 
            // radGovt
            // 
            this.radGovt.AutoSize = true;
            this.radGovt.Location = new System.Drawing.Point(88, 13);
            this.radGovt.Name = "radGovt";
            this.radGovt.Size = new System.Drawing.Size(48, 17);
            this.radGovt.TabIndex = 1;
            this.radGovt.TabStop = true;
            this.radGovt.Text = "Govt";
            this.radGovt.UseVisualStyleBackColor = true;
            // 
            // radBCAA
            // 
            this.radBCAA.AutoSize = true;
            this.radBCAA.Location = new System.Drawing.Point(20, 13);
            this.radBCAA.Name = "radBCAA";
            this.radBCAA.Size = new System.Drawing.Size(53, 17);
            this.radBCAA.TabIndex = 0;
            this.radBCAA.TabStop = true;
            this.radBCAA.Text = "BCAA";
            this.radBCAA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGPS);
            this.groupBox2.Controls.Add(this.chkInsurance);
            this.groupBox2.Location = new System.Drawing.Point(17, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point(105, 20);
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size(48, 17);
            this.chkGPS.TabIndex = 1;
            this.chkGPS.Text = "GPS";
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(7, 20);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(73, 17);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "Insurance";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(435, 21);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(61, 37);
            this.btnAvg.TabIndex = 15;
            this.btnAvg.Text = "find Avg";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // txtQ2
            // 
            this.txtQ2.Location = new System.Drawing.Point(647, 51);
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(100, 20);
            this.txtQ2.TabIndex = 14;
            // 
            // txtQ1
            // 
            this.txtQ1.Location = new System.Drawing.Point(647, 17);
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(100, 20);
            this.txtQ1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quiz 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quiz 1";
            // 
            // txtQ4
            // 
            this.txtQ4.Location = new System.Drawing.Point(647, 121);
            this.txtQ4.Name = "txtQ4";
            this.txtQ4.Size = new System.Drawing.Size(100, 20);
            this.txtQ4.TabIndex = 19;
            // 
            // txtQ3
            // 
            this.txtQ3.Location = new System.Drawing.Point(647, 87);
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(100, 20);
            this.txtQ3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quiz 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quiz 3";
            // 
            // txtBavg
            // 
            this.txtBavg.Location = new System.Drawing.Point(647, 181);
            this.txtBavg.Name = "txtBavg";
            this.txtBavg.Size = new System.Drawing.Size(100, 20);
            this.txtBavg.TabIndex = 23;
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(647, 147);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Average best 3 out 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quiz average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 580);
            this.Controls.Add(this.txtBavg);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQ4);
            this.Controls.Add(this.txtQ3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstRental);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Click += new System.EventHandler(this.btnClick);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstRental;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNA;
        private System.Windows.Forms.RadioButton radGovt;
        private System.Windows.Forms.RadioButton radBCAA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox txtQ2;
        private System.Windows.Forms.TextBox txtQ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQ4;
        private System.Windows.Forms.TextBox txtQ3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBavg;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

