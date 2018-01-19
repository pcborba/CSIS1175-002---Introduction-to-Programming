namespace SumAge
{
    partial class frmSumAge
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMyage = new System.Windows.Forms.TextBox();
            this.txtBestAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCombined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 167);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Combined Age";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtMyage
            // 
            this.txtMyage.Location = new System.Drawing.Point(248, 26);
            this.txtMyage.Name = "txtMyage";
            this.txtMyage.Size = new System.Drawing.Size(100, 22);
            this.txtMyage.TabIndex = 2;
            // 
            // txtBestAge
            // 
            this.txtBestAge.Location = new System.Drawing.Point(248, 78);
            this.txtBestAge.Name = "txtBestAge";
            this.txtBestAge.Size = new System.Drawing.Size(100, 22);
            this.txtBestAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your best friend´s age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "This is your combined ages:";
            // 
            // lblCombined
            // 
            this.lblCombined.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombined.Location = new System.Drawing.Point(248, 115);
            this.lblCombined.Name = "lblCombined";
            this.lblCombined.Size = new System.Drawing.Size(100, 20);
            this.lblCombined.TabIndex = 7;
            // 
            // frmSumAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 224);
            this.Controls.Add(this.lblCombined);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBestAge);
            this.Controls.Add(this.txtMyage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmSumAge";
            this.Text = "Sum Age";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMyage;
        private System.Windows.Forms.TextBox txtBestAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCombined;
    }
}

