namespace CruiseII
{
    partial class frmCruise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruise));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.dtpSailingDate = new System.Windows.Forms.DateTimePicker();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpCabin = new System.Windows.Forms.GroupBox();
            this.grpCruise = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.chkDining = new System.Windows.Forms.CheckBox();
            this.chkWiFi = new System.Windows.Forms.CheckBox();
            this.chkExcursion = new System.Windows.Forms.CheckBox();
            this.radInside = new System.Windows.Forms.RadioButton();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radOutside = new System.Windows.Forms.RadioButton();
            this.radSuite = new System.Windows.Forms.RadioButton();
            this.rad5days = new System.Windows.Forms.RadioButton();
            this.rad7days = new System.Windows.Forms.RadioButton();
            this.rad11days = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.grpCabin.SuspendLayout();
            this.grpCruise.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Douglas Cruise Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Designed by Paulo Borba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sailing Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "# of passengers";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(98, 150);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 22);
            this.txtLast.TabIndex = 8;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(306, 150);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(439, 150);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 10;
            // 
            // txtPassenger
            // 
            this.txtPassenger.Location = new System.Drawing.Point(133, 183);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(65, 22);
            this.txtPassenger.TabIndex = 11;
            // 
            // dtpSailingDate
            // 
            this.dtpSailingDate.Location = new System.Drawing.Point(721, 150);
            this.dtpSailingDate.Name = "dtpSailingDate";
            this.dtpSailingDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSailingDate.TabIndex = 12;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkExcursion);
            this.grpOptions.Controls.Add(this.chkWiFi);
            this.grpOptions.Controls.Add(this.chkDining);
            this.grpOptions.Location = new System.Drawing.Point(20, 229);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(331, 60);
            this.grpOptions.TabIndex = 13;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpCabin
            // 
            this.grpCabin.Controls.Add(this.radSuite);
            this.grpCabin.Controls.Add(this.radOutside);
            this.grpCabin.Controls.Add(this.radBalcony);
            this.grpCabin.Controls.Add(this.radInside);
            this.grpCabin.Location = new System.Drawing.Point(20, 303);
            this.grpCabin.Name = "grpCabin";
            this.grpCabin.Size = new System.Drawing.Size(261, 149);
            this.grpCabin.TabIndex = 14;
            this.grpCabin.TabStop = false;
            this.grpCabin.Text = "Cabin";
            // 
            // grpCruise
            // 
            this.grpCruise.Controls.Add(this.rad11days);
            this.grpCruise.Controls.Add(this.rad5days);
            this.grpCruise.Controls.Add(this.rad7days);
            this.grpCruise.Location = new System.Drawing.Point(296, 303);
            this.grpCruise.Name = "grpCruise";
            this.grpCruise.Size = new System.Drawing.Size(120, 149);
            this.grpCruise.TabIndex = 14;
            this.grpCruise.TabStop = false;
            this.grpCruise.Text = "Cruise Duration";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(435, 229);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 60);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(435, 303);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(90, 60);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Show Result";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 17;
            this.lstResult.Location = new System.Drawing.Point(546, 229);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(382, 225);
            this.lstResult.TabIndex = 17;
            // 
            // chkDining
            // 
            this.chkDining.AutoSize = true;
            this.chkDining.Location = new System.Drawing.Point(12, 23);
            this.chkDining.Name = "chkDining";
            this.chkDining.Size = new System.Drawing.Size(101, 21);
            this.chkDining.TabIndex = 0;
            this.chkDining.Text = "Fine Dining";
            this.chkDining.UseVisualStyleBackColor = true;
            // 
            // chkWiFi
            // 
            this.chkWiFi.AutoSize = true;
            this.chkWiFi.Location = new System.Drawing.Point(141, 23);
            this.chkWiFi.Name = "chkWiFi";
            this.chkWiFi.Size = new System.Drawing.Size(62, 21);
            this.chkWiFi.TabIndex = 1;
            this.chkWiFi.Text = "Wi-Fi";
            this.chkWiFi.UseVisualStyleBackColor = true;
            // 
            // chkExcursion
            // 
            this.chkExcursion.AutoSize = true;
            this.chkExcursion.Location = new System.Drawing.Point(231, 23);
            this.chkExcursion.Name = "chkExcursion";
            this.chkExcursion.Size = new System.Drawing.Size(98, 21);
            this.chkExcursion.TabIndex = 2;
            this.chkExcursion.Text = "Excursions";
            this.chkExcursion.UseVisualStyleBackColor = true;
            // 
            // radInside
            // 
            this.radInside.AutoSize = true;
            this.radInside.Location = new System.Drawing.Point(12, 22);
            this.radInside.Name = "radInside";
            this.radInside.Size = new System.Drawing.Size(66, 21);
            this.radInside.TabIndex = 0;
            this.radInside.TabStop = true;
            this.radInside.Text = "Inside";
            this.radInside.UseVisualStyleBackColor = true;
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(12, 96);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(79, 21);
            this.radBalcony.TabIndex = 1;
            this.radBalcony.TabStop = true;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radOutside
            // 
            this.radOutside.AutoSize = true;
            this.radOutside.Location = new System.Drawing.Point(141, 22);
            this.radOutside.Name = "radOutside";
            this.radOutside.Size = new System.Drawing.Size(78, 21);
            this.radOutside.TabIndex = 2;
            this.radOutside.TabStop = true;
            this.radOutside.Text = "Outside";
            this.radOutside.UseVisualStyleBackColor = true;
            // 
            // radSuite
            // 
            this.radSuite.AutoSize = true;
            this.radSuite.Location = new System.Drawing.Point(145, 96);
            this.radSuite.Name = "radSuite";
            this.radSuite.Size = new System.Drawing.Size(61, 21);
            this.radSuite.TabIndex = 3;
            this.radSuite.TabStop = true;
            this.radSuite.Text = "Suite";
            this.radSuite.UseVisualStyleBackColor = true;
            // 
            // rad5days
            // 
            this.rad5days.AutoSize = true;
            this.rad5days.Location = new System.Drawing.Point(10, 39);
            this.rad5days.Name = "rad5days";
            this.rad5days.Size = new System.Drawing.Size(73, 21);
            this.rad5days.TabIndex = 4;
            this.rad5days.TabStop = true;
            this.rad5days.Text = "5 Days";
            this.rad5days.UseVisualStyleBackColor = true;
            // 
            // rad7days
            // 
            this.rad7days.AutoSize = true;
            this.rad7days.Location = new System.Drawing.Point(10, 81);
            this.rad7days.Name = "rad7days";
            this.rad7days.Size = new System.Drawing.Size(73, 21);
            this.rad7days.TabIndex = 5;
            this.rad7days.TabStop = true;
            this.rad7days.Text = "7 Days";
            this.rad7days.UseVisualStyleBackColor = true;
            // 
            // rad11days
            // 
            this.rad11days.AutoSize = true;
            this.rad11days.Location = new System.Drawing.Point(10, 122);
            this.rad11days.Name = "rad11days";
            this.rad11days.Size = new System.Drawing.Size(81, 21);
            this.rad11days.TabIndex = 6;
            this.rad11days.TabStop = true;
            this.rad11days.Text = "11 Days";
            this.rad11days.UseVisualStyleBackColor = true;
            // 
            // frmCruise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 462);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpCabin);
            this.Controls.Add(this.grpCruise);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.dtpSailingDate);
            this.Controls.Add(this.txtPassenger);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCruise";
            this.Text = "Douglas Cruise Line";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpCabin.ResumeLayout(false);
            this.grpCabin.PerformLayout();
            this.grpCruise.ResumeLayout(false);
            this.grpCruise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.DateTimePicker dtpSailingDate;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkExcursion;
        private System.Windows.Forms.CheckBox chkWiFi;
        private System.Windows.Forms.CheckBox chkDining;
        private System.Windows.Forms.GroupBox grpCabin;
        private System.Windows.Forms.RadioButton radSuite;
        private System.Windows.Forms.RadioButton radOutside;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radInside;
        private System.Windows.Forms.GroupBox grpCruise;
        private System.Windows.Forms.RadioButton rad11days;
        private System.Windows.Forms.RadioButton rad5days;
        private System.Windows.Forms.RadioButton rad7days;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstResult;
    }
}

