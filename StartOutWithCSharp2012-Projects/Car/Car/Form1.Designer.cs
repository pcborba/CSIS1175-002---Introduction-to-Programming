namespace Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picSpeed = new System.Windows.Forms.PictureBox();
            this.lblSpeedometer = new System.Windows.Forms.Label();
            this.picAccel = new System.Windows.Forms.PictureBox();
            this.picBreak = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpeed
            // 
            this.picSpeed.Image = ((System.Drawing.Image)(resources.GetObject("picSpeed.Image")));
            this.picSpeed.Location = new System.Drawing.Point(246, 88);
            this.picSpeed.Name = "picSpeed";
            this.picSpeed.Size = new System.Drawing.Size(304, 288);
            this.picSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpeed.TabIndex = 0;
            this.picSpeed.TabStop = false;
            // 
            // lblSpeedometer
            // 
            this.lblSpeedometer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpeedometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedometer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpeedometer.Location = new System.Drawing.Point(351, 210);
            this.lblSpeedometer.Name = "lblSpeedometer";
            this.lblSpeedometer.Size = new System.Drawing.Size(99, 39);
            this.lblSpeedometer.TabIndex = 1;
            this.lblSpeedometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAccel
            // 
            this.picAccel.Image = ((System.Drawing.Image)(resources.GetObject("picAccel.Image")));
            this.picAccel.Location = new System.Drawing.Point(460, 382);
            this.picAccel.Name = "picAccel";
            this.picAccel.Size = new System.Drawing.Size(90, 150);
            this.picAccel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccel.TabIndex = 2;
            this.picAccel.TabStop = false;
            this.picAccel.Click += new System.EventHandler(this.picAccel_Click);
            // 
            // picBreak
            // 
            this.picBreak.Image = ((System.Drawing.Image)(resources.GetObject("picBreak.Image")));
            this.picBreak.Location = new System.Drawing.Point(246, 382);
            this.picBreak.Name = "picBreak";
            this.picBreak.Size = new System.Drawing.Size(150, 150);
            this.picBreak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBreak.TabIndex = 3;
            this.picBreak.TabStop = false;
            this.picBreak.Click += new System.EventHandler(this.picBreak_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(351, 43);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(70, 25);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "label2";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(289, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(213, 24);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Descripition of the car";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 585);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.picBreak);
            this.Controls.Add(this.picAccel);
            this.Controls.Add(this.lblSpeedometer);
            this.Controls.Add(this.picSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpeed;
        private System.Windows.Forms.Label lblSpeedometer;
        private System.Windows.Forms.PictureBox picAccel;
        private System.Windows.Forms.PictureBox picBreak;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblDescription;
    }
}

