namespace TotalPayment
{
    partial class frmPayment
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
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtJan = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblJan = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.txtPayAmt = new System.Windows.Forms.TextBox();
            this.lblPayAmt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(153, 225);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(223, 66);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate the total Payment";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(296, 21);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(201, 22);
            this.txtDec.TabIndex = 1;
            // 
            // txtJan
            // 
            this.txtJan.Location = new System.Drawing.Point(296, 60);
            this.txtJan.Name = "txtJan";
            this.txtJan.Size = new System.Drawing.Size(201, 22);
            this.txtJan.TabIndex = 2;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(296, 98);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(201, 22);
            this.txtReg.TabIndex = 3;
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(27, 21);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(260, 17);
            this.lblDec.TabIndex = 0;
            this.lblDec.Text = "Hours worked on 25th December, 2017:";
            // 
            // lblJan
            // 
            this.lblJan.AutoSize = true;
            this.lblJan.Location = new System.Drawing.Point(27, 65);
            this.lblJan.Name = "lblJan";
            this.lblJan.Size = new System.Drawing.Size(245, 17);
            this.lblJan.TabIndex = 0;
            this.lblJan.Text = "Hours worked on 1st: January,  2018:";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(27, 103);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(212, 17);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Hours worked on a regular date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payrate per hour:";
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(296, 139);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(201, 22);
            this.txtPayrate.TabIndex = 4;
            // 
            // txtPayAmt
            // 
            this.txtPayAmt.Enabled = false;
            this.txtPayAmt.Location = new System.Drawing.Point(296, 177);
            this.txtPayAmt.Name = "txtPayAmt";
            this.txtPayAmt.ReadOnly = true;
            this.txtPayAmt.Size = new System.Drawing.Size(201, 22);
            this.txtPayAmt.TabIndex = 9;
            // 
            // lblPayAmt
            // 
            this.lblPayAmt.AutoSize = true;
            this.lblPayAmt.Location = new System.Drawing.Point(27, 177);
            this.lblPayAmt.Name = "lblPayAmt";
            this.lblPayAmt.Size = new System.Drawing.Size(87, 17);
            this.lblPayAmt.TabIndex = 0;
            this.lblPayAmt.Text = "Pay amount:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(228, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(522, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPayAmt);
            this.Controls.Add(this.txtPayAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblJan);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.txtJan);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtJan;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblJan;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayrate;
        private System.Windows.Forms.TextBox txtPayAmt;
        private System.Windows.Forms.Label lblPayAmt;
        private System.Windows.Forms.Button btnExit;
    }
}

