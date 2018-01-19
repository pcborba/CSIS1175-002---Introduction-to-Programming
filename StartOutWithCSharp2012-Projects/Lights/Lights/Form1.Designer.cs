namespace Lights
{
    partial class frmLights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLights));
            this.picOn = new System.Windows.Forms.PictureBox();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            this.SuspendLayout();
            // 
            // picOn
            // 
            this.picOn.Image = ((System.Drawing.Image)(resources.GetObject("picOn.Image")));
            this.picOn.Location = new System.Drawing.Point(139, 12);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(238, 296);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 0;
            this.picOn.TabStop = false;
            // 
            // picOff
            // 
            this.picOff.Image = ((System.Drawing.Image)(resources.GetObject("picOff.Image")));
            this.picOff.Location = new System.Drawing.Point(139, 12);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(240, 296);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 1;
            this.picOff.TabStop = false;
            this.picOff.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(376, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 330);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(135, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Switch Light";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(243, 330);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 25);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "ON";
            // 
            // frmLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(519, 376);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.picOff);
            this.Name = "frmLights";
            this.Text = "Lights";
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.PictureBox picOff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblState;
    }
}

