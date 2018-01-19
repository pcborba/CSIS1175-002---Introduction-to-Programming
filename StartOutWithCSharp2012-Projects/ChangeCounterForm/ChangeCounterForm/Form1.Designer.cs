namespace ChangeCounterForm
{
    partial class frmChgCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChgCounter));
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.pic25 = new System.Windows.Forms.PictureBox();
            this.pic50 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutputTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50)).BeginInit();
            this.SuspendLayout();
            // 
            // pic5
            // 
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(68, 52);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(120, 125);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 0;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.pic5_Click);
            // 
            // pic10
            // 
            this.pic10.Image = ((System.Drawing.Image)(resources.GetObject("pic10.Image")));
            this.pic10.Location = new System.Drawing.Point(234, 52);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(120, 125);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic10.TabIndex = 0;
            this.pic10.TabStop = false;
            this.pic10.Click += new System.EventHandler(this.pic10_Click);
            // 
            // pic25
            // 
            this.pic25.Image = ((System.Drawing.Image)(resources.GetObject("pic25.Image")));
            this.pic25.Location = new System.Drawing.Point(68, 207);
            this.pic25.Name = "pic25";
            this.pic25.Size = new System.Drawing.Size(120, 125);
            this.pic25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic25.TabIndex = 0;
            this.pic25.TabStop = false;
            this.pic25.Click += new System.EventHandler(this.pic25_Click);
            // 
            // pic50
            // 
            this.pic50.Image = ((System.Drawing.Image)(resources.GetObject("pic50.Image")));
            this.pic50.Location = new System.Drawing.Point(234, 207);
            this.pic50.Name = "pic50";
            this.pic50.Size = new System.Drawing.Size(120, 125);
            this.pic50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic50.TabIndex = 0;
            this.pic50.TabStop = false;
            this.pic50.Click += new System.EventHandler(this.pic50_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(421, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblOutputTotal
            // 
            this.lblOutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputTotal.Location = new System.Drawing.Point(424, 180);
            this.lblOutputTotal.Name = "lblOutputTotal";
            this.lblOutputTotal.Size = new System.Drawing.Size(100, 23);
            this.lblOutputTotal.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChgCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(667, 502);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutputTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pic50);
            this.Controls.Add(this.pic25);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.pic5);
            this.Name = "frmChgCounter";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.PictureBox pic25;
        private System.Windows.Forms.PictureBox pic50;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutputTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

