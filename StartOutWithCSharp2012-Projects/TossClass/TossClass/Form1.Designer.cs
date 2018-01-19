namespace TossClass
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
            this.btnToss = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnMethodFlip = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(37, 12);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(127, 62);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss the coin";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(37, 90);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(339, 228);
            this.lstResult.TabIndex = 1;
            // 
            // btnMethodFlip
            // 
            this.btnMethodFlip.Location = new System.Drawing.Point(196, 12);
            this.btnMethodFlip.Name = "btnMethodFlip";
            this.btnMethodFlip.Size = new System.Drawing.Size(113, 61);
            this.btnMethodFlip.TabIndex = 2;
            this.btnMethodFlip.Text = "Flip Method";
            this.btnMethodFlip.UseVisualStyleBackColor = true;
            this.btnMethodFlip.Click += new System.EventHandler(this.btnMethodFlip_Click);
            // 
            // btnPet
            // 
            this.btnPet.Location = new System.Drawing.Point(332, 13);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(113, 61);
            this.btnPet.TabIndex = 3;
            this.btnPet.Text = "Pet";
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 436);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.btnMethodFlip);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnToss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnMethodFlip;
        private System.Windows.Forms.Button btnPet;
    }
}

