namespace PauloBorba
{
    partial class frmCruiseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSailingDate = new System.Windows.Forms.Label();
            this.lblNofPassengers = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNofPassengers = new System.Windows.Forms.TextBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkExcursions = new System.Windows.Forms.CheckBox();
            this.chkWiFi = new System.Windows.Forms.CheckBox();
            this.chkDining = new System.Windows.Forms.CheckBox();
            this.grpCabin = new System.Windows.Forms.GroupBox();
            this.radSuite = new System.Windows.Forms.RadioButton();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radOutside = new System.Windows.Forms.RadioButton();
            this.radInside = new System.Windows.Forms.RadioButton();
            this.grpCruiseDuration = new System.Windows.Forms.GroupBox();
            this.rad11D = new System.Windows.Forms.RadioButton();
            this.rad7d = new System.Windows.Forms.RadioButton();
            this.rad5d = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.dtpSailingDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.grpCabin.SuspendLayout();
            this.grpCruiseDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(385, 74);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(250, 41);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Douglas Cruise Line";
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigner.Location = new System.Drawing.Point(763, 88);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(239, 20);
            this.lblDesigner.TabIndex = 2;
            this.lblDesigner.Text = "Designed by Paulo Borba";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 176);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(234, 176);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(443, 176);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lblSailingDate
            // 
            this.lblSailingDate.AutoSize = true;
            this.lblSailingDate.Location = new System.Drawing.Point(670, 176);
            this.lblSailingDate.Name = "lblSailingDate";
            this.lblSailingDate.Size = new System.Drawing.Size(84, 17);
            this.lblSailingDate.TabIndex = 6;
            this.lblSailingDate.Text = "Sailing Date";
            // 
            // lblNofPassengers
            // 
            this.lblNofPassengers.AutoSize = true;
            this.lblNofPassengers.Location = new System.Drawing.Point(31, 218);
            this.lblNofPassengers.Name = "lblNofPassengers";
            this.lblNofPassengers.Size = new System.Drawing.Size(110, 17);
            this.lblNofPassengers.TabIndex = 7;
            this.lblNofPassengers.Text = "# of passengers";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(114, 173);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(316, 173);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(469, 173);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtNofPassengers
            // 
            this.txtNofPassengers.Location = new System.Drawing.Point(147, 213);
            this.txtNofPassengers.Name = "txtNofPassengers";
            this.txtNofPassengers.Size = new System.Drawing.Size(67, 22);
            this.txtNofPassengers.TabIndex = 5;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkExcursions);
            this.grpOptions.Controls.Add(this.chkWiFi);
            this.grpOptions.Controls.Add(this.chkDining);
            this.grpOptions.Location = new System.Drawing.Point(34, 255);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(330, 56);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkExcursions
            // 
            this.chkExcursions.AutoSize = true;
            this.chkExcursions.Location = new System.Drawing.Point(217, 21);
            this.chkExcursions.Name = "chkExcursions";
            this.chkExcursions.Size = new System.Drawing.Size(98, 21);
            this.chkExcursions.TabIndex = 8;
            this.chkExcursions.Text = "Excursions";
            this.chkExcursions.UseVisualStyleBackColor = true;
            // 
            // chkWiFi
            // 
            this.chkWiFi.AutoSize = true;
            this.chkWiFi.Location = new System.Drawing.Point(138, 21);
            this.chkWiFi.Name = "chkWiFi";
            this.chkWiFi.Size = new System.Drawing.Size(57, 21);
            this.chkWiFi.TabIndex = 7;
            this.chkWiFi.Text = "WiFi";
            this.chkWiFi.UseVisualStyleBackColor = true;
            // 
            // chkDining
            // 
            this.chkDining.AutoSize = true;
            this.chkDining.Location = new System.Drawing.Point(21, 21);
            this.chkDining.Name = "chkDining";
            this.chkDining.Size = new System.Drawing.Size(101, 21);
            this.chkDining.TabIndex = 6;
            this.chkDining.Text = "Fine Dining";
            this.chkDining.UseVisualStyleBackColor = true;
            // 
            // grpCabin
            // 
            this.grpCabin.Controls.Add(this.radSuite);
            this.grpCabin.Controls.Add(this.radBalcony);
            this.grpCabin.Controls.Add(this.radOutside);
            this.grpCabin.Controls.Add(this.radInside);
            this.grpCabin.Location = new System.Drawing.Point(34, 335);
            this.grpCabin.Name = "grpCabin";
            this.grpCabin.Size = new System.Drawing.Size(195, 163);
            this.grpCabin.TabIndex = 0;
            this.grpCabin.TabStop = false;
            this.grpCabin.Text = "Cabin";
            // 
            // radSuite
            // 
            this.radSuite.AutoSize = true;
            this.radSuite.Location = new System.Drawing.Point(100, 107);
            this.radSuite.Name = "radSuite";
            this.radSuite.Size = new System.Drawing.Size(61, 21);
            this.radSuite.TabIndex = 12;
            this.radSuite.TabStop = true;
            this.radSuite.Text = "Suite";
            this.radSuite.UseVisualStyleBackColor = true;
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(12, 107);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(79, 21);
            this.radBalcony.TabIndex = 11;
            this.radBalcony.TabStop = true;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radOutside
            // 
            this.radOutside.AutoSize = true;
            this.radOutside.Location = new System.Drawing.Point(100, 46);
            this.radOutside.Name = "radOutside";
            this.radOutside.Size = new System.Drawing.Size(78, 21);
            this.radOutside.TabIndex = 10;
            this.radOutside.TabStop = true;
            this.radOutside.Text = "Outside";
            this.radOutside.UseVisualStyleBackColor = true;
            // 
            // radInside
            // 
            this.radInside.AutoSize = true;
            this.radInside.Location = new System.Drawing.Point(12, 46);
            this.radInside.Name = "radInside";
            this.radInside.Size = new System.Drawing.Size(66, 21);
            this.radInside.TabIndex = 9;
            this.radInside.TabStop = true;
            this.radInside.Text = "Inside";
            this.radInside.UseVisualStyleBackColor = true;
            // 
            // grpCruiseDuration
            // 
            this.grpCruiseDuration.Controls.Add(this.rad11D);
            this.grpCruiseDuration.Controls.Add(this.rad7d);
            this.grpCruiseDuration.Controls.Add(this.rad5d);
            this.grpCruiseDuration.Location = new System.Drawing.Point(250, 335);
            this.grpCruiseDuration.Name = "grpCruiseDuration";
            this.grpCruiseDuration.Size = new System.Drawing.Size(134, 163);
            this.grpCruiseDuration.TabIndex = 0;
            this.grpCruiseDuration.TabStop = false;
            this.grpCruiseDuration.Text = "Cruise Duration";
            // 
            // rad11D
            // 
            this.rad11D.AutoSize = true;
            this.rad11D.Location = new System.Drawing.Point(21, 124);
            this.rad11D.Name = "rad11D";
            this.rad11D.Size = new System.Drawing.Size(81, 21);
            this.rad11D.TabIndex = 15;
            this.rad11D.TabStop = true;
            this.rad11D.Text = "11 Days";
            this.rad11D.UseVisualStyleBackColor = true;
            // 
            // rad7d
            // 
            this.rad7d.AutoSize = true;
            this.rad7d.Location = new System.Drawing.Point(21, 79);
            this.rad7d.Name = "rad7d";
            this.rad7d.Size = new System.Drawing.Size(73, 21);
            this.rad7d.TabIndex = 14;
            this.rad7d.TabStop = true;
            this.rad7d.Text = "7 Days";
            this.rad7d.UseVisualStyleBackColor = true;
            // 
            // rad5d
            // 
            this.rad5d.AutoSize = true;
            this.rad5d.Location = new System.Drawing.Point(21, 32);
            this.rad5d.Name = "rad5d";
            this.rad5d.Size = new System.Drawing.Size(73, 21);
            this.rad5d.TabIndex = 13;
            this.rad5d.TabStop = true;
            this.rad5d.Text = "5 Days";
            this.rad5d.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(427, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 72);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(427, 374);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(111, 72);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show Results";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstInvoice
            // 
            this.lstInvoice.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 20;
            this.lstInvoice.Location = new System.Drawing.Point(569, 269);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(433, 224);
            this.lstInvoice.TabIndex = 0;
            // 
            // dtpSailingDate
            // 
            this.dtpSailingDate.Location = new System.Drawing.Point(760, 173);
            this.dtpSailingDate.Name = "dtpSailingDate";
            this.dtpSailingDate.Size = new System.Drawing.Size(242, 22);
            this.dtpSailingDate.TabIndex = 18;
            this.dtpSailingDate.Value = new System.DateTime(2017, 1, 26, 0, 0, 0, 0);
            // 
            // frmCruiseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 510);
            this.Controls.Add(this.dtpSailingDate);
            this.Controls.Add(this.lstInvoice);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpCruiseDuration);
            this.Controls.Add(this.grpCabin);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.txtNofPassengers);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblNofPassengers);
            this.Controls.Add(this.lblSailingDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDesigner);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCruiseManager";
            this.Text = "Cruise Manager - Douglas Cruise Line";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpCabin.ResumeLayout(false);
            this.grpCabin.PerformLayout();
            this.grpCruiseDuration.ResumeLayout(false);
            this.grpCruiseDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDesigner;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSailingDate;
        private System.Windows.Forms.Label lblNofPassengers;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNofPassengers;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkExcursions;
        private System.Windows.Forms.CheckBox chkWiFi;
        private System.Windows.Forms.CheckBox chkDining;
        private System.Windows.Forms.GroupBox grpCabin;
        private System.Windows.Forms.RadioButton radSuite;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radOutside;
        private System.Windows.Forms.RadioButton radInside;
        private System.Windows.Forms.GroupBox grpCruiseDuration;
        private System.Windows.Forms.RadioButton rad11D;
        private System.Windows.Forms.RadioButton rad7d;
        private System.Windows.Forms.RadioButton rad5d;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.DateTimePicker dtpSailingDate;
    }
}

