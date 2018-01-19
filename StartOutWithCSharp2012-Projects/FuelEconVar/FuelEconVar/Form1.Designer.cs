namespace FuelEconVar
{
    partial class frmFuelEconomy
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
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.lblCarMPG = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(33, 63);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(217, 17);
            this.lblMilesDriven.TabIndex = 0;
            this.lblMilesDriven.Text = "Enter the number of miles driven:";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(53, 102);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(197, 17);
            this.lblGallons.TabIndex = 1;
            this.lblGallons.Text = "Enter the gallons of gas used:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(276, 58);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(213, 22);
            this.txtMiles.TabIndex = 1;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(276, 97);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(213, 22);
            this.txtGallons.TabIndex = 2;
            // 
            // lblMPG
            // 
            this.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPG.Location = new System.Drawing.Point(276, 141);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(213, 23);
            this.lblMPG.TabIndex = 3;
            // 
            // lblCarMPG
            // 
            this.lblCarMPG.AutoSize = true;
            this.lblCarMPG.Location = new System.Drawing.Point(139, 147);
            this.lblCarMPG.Name = "lblCarMPG";
            this.lblCarMPG.Size = new System.Drawing.Size(111, 17);
            this.lblCarMPG.TabIndex = 4;
            this.lblCarMPG.Text = "Your car\'s MPG:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 182);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 59);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate MPG";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(414, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFuelEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(536, 291);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblCarMPG);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblMilesDriven);
            this.Name = "frmFuelEconomy";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Label lblCarMPG;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

