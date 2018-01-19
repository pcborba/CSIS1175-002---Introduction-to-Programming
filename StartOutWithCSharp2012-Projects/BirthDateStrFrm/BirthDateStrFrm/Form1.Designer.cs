namespace BirthDateStrFrm
{
    partial class frmBirth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayofWeek = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDayOfMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblDateOutput = new System.Windows.Forms.Label();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day of the week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the name of the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter the year";
            // 
            // txtDayofWeek
            // 
            this.txtDayofWeek.Location = new System.Drawing.Point(292, 32);
            this.txtDayofWeek.Name = "txtDayofWeek";
            this.txtDayofWeek.Size = new System.Drawing.Size(198, 22);
            this.txtDayofWeek.TabIndex = 1;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(292, 63);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(198, 22);
            this.txtMonth.TabIndex = 2;
            // 
            // txtDayOfMonth
            // 
            this.txtDayOfMonth.Location = new System.Drawing.Point(292, 94);
            this.txtDayOfMonth.Name = "txtDayOfMonth";
            this.txtDayOfMonth.Size = new System.Drawing.Size(198, 22);
            this.txtDayOfMonth.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(292, 125);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(198, 22);
            this.txtYear.TabIndex = 4;
            // 
            // lblDateOutput
            // 
            this.lblDateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateOutput.Location = new System.Drawing.Point(43, 181);
            this.lblDateOutput.Name = "lblDateOutput";
            this.lblDateOutput.Size = new System.Drawing.Size(447, 23);
            this.lblDateOutput.TabIndex = 6;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(43, 246);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(124, 23);
            this.btnShowDate.TabIndex = 5;
            this.btnShowDate.Text = "Show Date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBirth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.lblDateOutput);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDayOfMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDayofWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBirth";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayofWeek;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDayOfMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblDateOutput;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

