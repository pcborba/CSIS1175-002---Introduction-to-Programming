namespace AccountSimul
{
    partial class frmAccSimul
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDep = new System.Windows.Forms.GroupBox();
            this.grpWith = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtWith = new System.Windows.Forms.TextBox();
            this.btnDep = new System.Windows.Forms.Button();
            this.btnWith = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDep.SuspendLayout();
            this.grpWith.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Location = new System.Drawing.Point(195, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 24);
            this.lblBalance.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // grpDep
            // 
            this.grpDep.Controls.Add(this.btnDep);
            this.grpDep.Controls.Add(this.txtDep);
            this.grpDep.Controls.Add(this.label3);
            this.grpDep.Location = new System.Drawing.Point(24, 54);
            this.grpDep.Name = "grpDep";
            this.grpDep.Size = new System.Drawing.Size(200, 100);
            this.grpDep.TabIndex = 4;
            this.grpDep.TabStop = false;
            this.grpDep.Text = "Make a Deposit";
            // 
            // grpWith
            // 
            this.grpWith.Controls.Add(this.btnWith);
            this.grpWith.Controls.Add(this.txtWith);
            this.grpWith.Controls.Add(this.label5);
            this.grpWith.Location = new System.Drawing.Point(284, 54);
            this.grpWith.Name = "grpWith";
            this.grpWith.Size = new System.Drawing.Size(200, 100);
            this.grpWith.TabIndex = 5;
            this.grpWith.TabStop = false;
            this.grpWith.Text = "Make a Withdrawal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(83, 36);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(100, 22);
            this.txtDep.TabIndex = 3;
            // 
            // txtWith
            // 
            this.txtWith.Location = new System.Drawing.Point(86, 36);
            this.txtWith.Name = "txtWith";
            this.txtWith.Size = new System.Drawing.Size(100, 22);
            this.txtWith.TabIndex = 4;
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(53, 66);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(75, 23);
            this.btnDep.TabIndex = 4;
            this.btnDep.Text = "Deposit";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnWith
            // 
            this.btnWith.Location = new System.Drawing.Point(66, 66);
            this.btnWith.Name = "btnWith";
            this.btnWith.Size = new System.Drawing.Size(75, 23);
            this.btnWith.TabIndex = 4;
            this.btnWith.Text = "Withdrawal";
            this.btnWith.UseVisualStyleBackColor = true;
            this.btnWith.Click += new System.EventHandler(this.btnWith_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmAccSimul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 244);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpWith);
            this.Controls.Add(this.grpDep);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Name = "frmAccSimul";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.frmAccSimul_Load);
            this.grpDep.ResumeLayout(false);
            this.grpDep.PerformLayout();
            this.grpWith.ResumeLayout(false);
            this.grpWith.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDep;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.GroupBox grpWith;
        private System.Windows.Forms.Button btnWith;
        private System.Windows.Forms.TextBox txtWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
    }
}

