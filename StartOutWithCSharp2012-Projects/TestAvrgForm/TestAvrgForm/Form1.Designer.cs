namespace TestAvrgForm
{
    partial class frmTestAverage
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
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblAvrgTestScore = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtBoxTest1 = new System.Windows.Forms.TextBox();
            this.txtBoxTest2 = new System.Windows.Forms.TextBox();
            this.txtBoxTest3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(71, 50);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(48, 17);
            this.lblT1.TabIndex = 0;
            this.lblT1.Text = "Test 1";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(71, 78);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(48, 17);
            this.lblT2.TabIndex = 0;
            this.lblT2.Text = "Test 2";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Location = new System.Drawing.Point(71, 106);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(48, 17);
            this.lblT3.TabIndex = 0;
            this.lblT3.Text = "Test 3";
            // 
            // lblAvrgTestScore
            // 
            this.lblAvrgTestScore.AutoSize = true;
            this.lblAvrgTestScore.Location = new System.Drawing.Point(71, 155);
            this.lblAvrgTestScore.Name = "lblAvrgTestScore";
            this.lblAvrgTestScore.Size = new System.Drawing.Size(127, 17);
            this.lblAvrgTestScore.TabIndex = 0;
            this.lblAvrgTestScore.Text = "Average test score";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(253, 144);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(202, 28);
            this.lblAverage.TabIndex = 0;
            // 
            // txtBoxTest1
            // 
            this.txtBoxTest1.Location = new System.Drawing.Point(253, 45);
            this.txtBoxTest1.Name = "txtBoxTest1";
            this.txtBoxTest1.Size = new System.Drawing.Size(202, 22);
            this.txtBoxTest1.TabIndex = 1;
            // 
            // txtBoxTest2
            // 
            this.txtBoxTest2.Location = new System.Drawing.Point(253, 73);
            this.txtBoxTest2.Name = "txtBoxTest2";
            this.txtBoxTest2.Size = new System.Drawing.Size(202, 22);
            this.txtBoxTest2.TabIndex = 1;
            // 
            // txtBoxTest3
            // 
            this.txtBoxTest3.Location = new System.Drawing.Point(253, 101);
            this.txtBoxTest3.Name = "txtBoxTest3";
            this.txtBoxTest3.Size = new System.Drawing.Size(202, 22);
            this.txtBoxTest3.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(74, 228);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 61);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate Average";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 61);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(355, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 343);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxTest3);
            this.Controls.Add(this.txtBoxTest2);
            this.Controls.Add(this.txtBoxTest1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblAvrgTestScore);
            this.Controls.Add(this.lblT3);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblT1);
            this.Name = "frmTestAverage";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblAvrgTestScore;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtBoxTest1;
        private System.Windows.Forms.TextBox txtBoxTest2;
        private System.Windows.Forms.TextBox txtBoxTest3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

