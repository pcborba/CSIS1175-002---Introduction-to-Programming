namespace Registration
{
    partial class frmReg
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
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.radDom = new System.Windows.Forms.RadioButton();
            this.radInt = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Level (1000 / 2000)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upper Level (3000 / 4000)";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(235, 26);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(100, 22);
            this.txtLower.TabIndex = 2;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(235, 68);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(100, 22);
            this.txtUpper.TabIndex = 2;
            // 
            // radDom
            // 
            this.radDom.AutoSize = true;
            this.radDom.Location = new System.Drawing.Point(15, 133);
            this.radDom.Name = "radDom";
            this.radDom.Size = new System.Drawing.Size(87, 21);
            this.radDom.TabIndex = 3;
            this.radDom.TabStop = true;
            this.radDom.Text = "Domestic";
            this.radDom.UseVisualStyleBackColor = true;
            // 
            // radInt
            // 
            this.radInt.AutoSize = true;
            this.radInt.Location = new System.Drawing.Point(144, 133);
            this.radInt.Name = "radInt";
            this.radInt.Size = new System.Drawing.Size(107, 21);
            this.radInt.TabIndex = 4;
            this.radInt.TabStop = true;
            this.radInt.Text = "International";
            this.radInt.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 189);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 240);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.radInt);
            this.Controls.Add(this.radDom);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReg";
            this.Text = "College Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.RadioButton radDom;
        private System.Windows.Forms.RadioButton radInt;
        private System.Windows.Forms.Button btnCalc;
    }
}

