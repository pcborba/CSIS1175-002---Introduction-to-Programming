namespace Demo2Week10
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
            this.btnPet = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(13, 13);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 37);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss the Coin";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(13, 56);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(75, 95);
            this.lstResult.TabIndex = 1;
            // 
            // btnPet
            // 
            this.btnPet.Location = new System.Drawing.Point(94, 12);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(79, 38);
            this.btnPet.TabIndex = 2;
            this.btnPet.Text = "My Pet Example";
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(179, 12);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(79, 38);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Calc Best Avg 3 of 4";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnToss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.Button btnAvg;
    }
}

