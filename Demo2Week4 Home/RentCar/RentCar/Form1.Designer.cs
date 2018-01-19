namespace RentCar
{
    partial class frmRentCar
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblRentalDuration = new System.Windows.Forms.Label();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtRentalDuration = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lstRental = new System.Windows.Forms.ListBox();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.rdaNA = new System.Windows.Forms.RadioButton();
            this.rdaGovt = new System.Windows.Forms.RadioButton();
            this.rdaBCAA = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkGPS = new System.Windows.Forms.CheckBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.grpDiscount.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(41, 33);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(182, 64);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblRentalDuration
            // 
            this.lblRentalDuration.AutoSize = true;
            this.lblRentalDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDuration.Location = new System.Drawing.Point(266, 42);
            this.lblRentalDuration.Name = "lblRentalDuration";
            this.lblRentalDuration.Size = new System.Drawing.Size(122, 20);
            this.lblRentalDuration.TabIndex = 1;
            this.lblRentalDuration.Text = "Rental duration";
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyRate.Location = new System.Drawing.Point(537, 42);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(81, 20);
            this.lblDailyRate.TabIndex = 2;
            this.lblDailyRate.Text = "Daily rate";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(730, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 20);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start date";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(36, 422);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(926, 64);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "BCAA 10%, Govt 5% discount on rental only, no discount on options, NA 0% discount" +
    " Insurance costs extra 15% on rental, GPS $5 a day extra";
            // 
            // txtRentalDuration
            // 
            this.txtRentalDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalDuration.Location = new System.Drawing.Point(431, 39);
            this.txtRentalDuration.Name = "txtRentalDuration";
            this.txtRentalDuration.Size = new System.Drawing.Size(100, 26);
            this.txtRentalDuration.TabIndex = 5;
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyRate.Location = new System.Drawing.Point(624, 39);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(100, 26);
            this.txtDailyRate.TabIndex = 6;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(828, 39);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(194, 26);
            this.txtStartDate.TabIndex = 7;
            // 
            // lstRental
            // 
            this.lstRental.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRental.FormattingEnabled = true;
            this.lstRental.ItemHeight = 20;
            this.lstRental.Location = new System.Drawing.Point(585, 190);
            this.lstRental.Name = "lstRental";
            this.lstRental.Size = new System.Drawing.Size(437, 204);
            this.lstRental.TabIndex = 8;
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.rdaNA);
            this.grpDiscount.Controls.Add(this.rdaGovt);
            this.grpDiscount.Controls.Add(this.rdaBCAA);
            this.grpDiscount.Location = new System.Drawing.Point(41, 190);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(404, 89);
            this.grpDiscount.TabIndex = 9;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Discount";
            // 
            // rdaNA
            // 
            this.rdaNA.AutoSize = true;
            this.rdaNA.Location = new System.Drawing.Point(327, 36);
            this.rdaNA.Name = "rdaNA";
            this.rdaNA.Size = new System.Drawing.Size(48, 21);
            this.rdaNA.TabIndex = 2;
            this.rdaNA.TabStop = true;
            this.rdaNA.Text = "NA";
            this.rdaNA.UseVisualStyleBackColor = true;
            // 
            // rdaGovt
            // 
            this.rdaGovt.AutoSize = true;
            this.rdaGovt.Location = new System.Drawing.Point(173, 36);
            this.rdaGovt.Name = "rdaGovt";
            this.rdaGovt.Size = new System.Drawing.Size(59, 21);
            this.rdaGovt.TabIndex = 1;
            this.rdaGovt.TabStop = true;
            this.rdaGovt.Text = "Govt";
            this.rdaGovt.UseVisualStyleBackColor = true;
            // 
            // rdaBCAA
            // 
            this.rdaBCAA.AutoSize = true;
            this.rdaBCAA.Location = new System.Drawing.Point(21, 36);
            this.rdaBCAA.Name = "rdaBCAA";
            this.rdaBCAA.Size = new System.Drawing.Size(65, 21);
            this.rdaBCAA.TabIndex = 0;
            this.rdaBCAA.TabStop = true;
            this.rdaBCAA.Text = "BCAA";
            this.rdaBCAA.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkGPS);
            this.grpOptions.Controls.Add(this.chkInsurance);
            this.grpOptions.Location = new System.Drawing.Point(41, 305);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(404, 89);
            this.grpOptions.TabIndex = 10;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkGPS
            // 
            this.chkGPS.AutoSize = true;
            this.chkGPS.Location = new System.Drawing.Point(229, 40);
            this.chkGPS.Name = "chkGPS";
            this.chkGPS.Size = new System.Drawing.Size(59, 21);
            this.chkGPS.TabIndex = 1;
            this.chkGPS.Text = "GPS";
            this.chkGPS.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(90, 40);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(92, 21);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "Insurance";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // frmRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 495);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.lstRental);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(this.txtRentalDuration);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDailyRate);
            this.Controls.Add(this.lblRentalDuration);
            this.Controls.Add(this.btnCompute);
            this.Name = "frmRentCar";
            this.Text = "Rent a car";
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblRentalDuration;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtRentalDuration;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ListBox lstRental;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.RadioButton rdaNA;
        private System.Windows.Forms.RadioButton rdaGovt;
        private System.Windows.Forms.RadioButton rdaBCAA;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkGPS;
        private System.Windows.Forms.CheckBox chkInsurance;
    }
}

