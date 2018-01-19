namespace MobilePlan
{
    partial class frmMobilePlan
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.radNd = new System.Windows.Forms.RadioButton();
            this.rad4gb = new System.Windows.Forms.RadioButton();
            this.rad2gb = new System.Windows.Forms.RadioButton();
            this.rad1gb = new System.Windows.Forms.RadioButton();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(22, 13);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 48);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes";
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.radNd);
            this.grpData.Controls.Add(this.rad4gb);
            this.grpData.Controls.Add(this.rad2gb);
            this.grpData.Controls.Add(this.rad1gb);
            this.grpData.Location = new System.Drawing.Point(22, 104);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(138, 212);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // radNd
            // 
            this.radNd.AutoSize = true;
            this.radNd.Location = new System.Drawing.Point(17, 156);
            this.radNd.Name = "radNd";
            this.radNd.Size = new System.Drawing.Size(81, 21);
            this.radNd.TabIndex = 0;
            this.radNd.TabStop = true;
            this.radNd.Text = "No Data";
            this.radNd.UseVisualStyleBackColor = true;
            // 
            // rad4gb
            // 
            this.rad4gb.AutoSize = true;
            this.rad4gb.Location = new System.Drawing.Point(17, 116);
            this.rad4gb.Name = "rad4gb";
            this.rad4gb.Size = new System.Drawing.Size(61, 21);
            this.rad4gb.TabIndex = 0;
            this.rad4gb.TabStop = true;
            this.rad4gb.Text = "4 GB";
            this.rad4gb.UseVisualStyleBackColor = true;
            // 
            // rad2gb
            // 
            this.rad2gb.AutoSize = true;
            this.rad2gb.Location = new System.Drawing.Point(17, 79);
            this.rad2gb.Name = "rad2gb";
            this.rad2gb.Size = new System.Drawing.Size(61, 21);
            this.rad2gb.TabIndex = 0;
            this.rad2gb.TabStop = true;
            this.rad2gb.Text = "2 GB";
            this.rad2gb.UseVisualStyleBackColor = true;
            // 
            // rad1gb
            // 
            this.rad1gb.AutoSize = true;
            this.rad1gb.Location = new System.Drawing.Point(17, 43);
            this.rad1gb.Name = "rad1gb";
            this.rad1gb.Size = new System.Drawing.Size(61, 21);
            this.rad1gb.TabIndex = 0;
            this.rad1gb.TabStop = true;
            this.rad1gb.Text = "1 GB";
            this.rad1gb.UseVisualStyleBackColor = true;
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 17;
            this.lstResult.Location = new System.Drawing.Point(193, 104);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(425, 174);
            this.lstResult.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(149, 34);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 22);
            this.txtMin.TabIndex = 4;
            // 
            // frmMobilePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 367);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmMobilePlan";
            this.Text = "Mobile Plan";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.RadioButton radNd;
        private System.Windows.Forms.RadioButton rad4gb;
        private System.Windows.Forms.RadioButton rad2gb;
        private System.Windows.Forms.RadioButton rad1gb;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.TextBox txtMin;
    }
}

