namespace TaxiFare
{
    partial class frmTaxi
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
            this.numSuit = new System.Windows.Forms.NumericUpDown();
            this.numTip = new System.Windows.Forms.NumericUpDown();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.radBc = new System.Windows.Forms.RadioButton();
            this.radN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).BeginInit();
            this.SuspendLayout();
            // 
            // numSuit
            // 
            this.numSuit.Location = new System.Drawing.Point(171, 76);
            this.numSuit.Name = "numSuit";
            this.numSuit.Size = new System.Drawing.Size(58, 22);
            this.numSuit.TabIndex = 0;
            // 
            // numTip
            // 
            this.numTip.Location = new System.Drawing.Point(171, 219);
            this.numTip.Name = "numTip";
            this.numTip.Size = new System.Drawing.Size(58, 22);
            this.numTip.TabIndex = 1;
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(147, 12);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(82, 22);
            this.txtDist.TabIndex = 2;
            // 
            // radBc
            // 
            this.radBc.AutoSize = true;
            this.radBc.Location = new System.Drawing.Point(13, 174);
            this.radBc.Name = "radBc";
            this.radBc.Size = new System.Drawing.Size(65, 21);
            this.radBc.TabIndex = 3;
            this.radBc.TabStop = true;
            this.radBc.Text = "BCAA";
            this.radBc.UseVisualStyleBackColor = true;
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(142, 174);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(52, 21);
            this.radN.TabIndex = 4;
            this.radN.TabStop = true;
            this.radN.Text = "N/A";
            this.radN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Distance (km)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suitcases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Receipt";
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 17;
            this.lstResult.Location = new System.Drawing.Point(334, 12);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(454, 157);
            this.lstResult.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(13, 295);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmTaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 341);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radN);
            this.Controls.Add(this.radBc);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.numTip);
            this.Controls.Add(this.numSuit);
            this.Name = "frmTaxi";
            this.Text = "Taxi Fare";
            ((System.ComponentModel.ISupportInitialize)(this.numSuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSuit;
        private System.Windows.Forms.NumericUpDown numTip;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.RadioButton radBc;
        private System.Windows.Forms.RadioButton radN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnCalc;
    }
}

