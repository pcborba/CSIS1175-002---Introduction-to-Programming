namespace ArrayFileCreate
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.lstContentABC = new System.Windows.Forms.ListBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblE1 = new System.Windows.Forms.Label();
            this.lblE2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(64, 144);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(64, 47);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lstContent
            // 
            this.lstContent.FormattingEnabled = true;
            this.lstContent.ItemHeight = 16;
            this.lstContent.Location = new System.Drawing.Point(330, 48);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(186, 164);
            this.lstContent.TabIndex = 2;
            // 
            // lstContentABC
            // 
            this.lstContentABC.FormattingEnabled = true;
            this.lstContentABC.ItemHeight = 16;
            this.lstContentABC.Location = new System.Drawing.Point(565, 47);
            this.lstContentABC.Name = "lstContentABC";
            this.lstContentABC.Size = new System.Drawing.Size(128, 164);
            this.lstContentABC.Sorted = true;
            this.lstContentABC.TabIndex = 2;
            // 
            // lblMin
            // 
            this.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMin.Location = new System.Drawing.Point(145, 49);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(73, 23);
            this.lblMin.TabIndex = 3;
            // 
            // lblMax
            // 
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMax.Location = new System.Drawing.Point(145, 95);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(73, 23);
            this.lblMax.TabIndex = 4;
            // 
            // lblSum
            // 
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSum.Location = new System.Drawing.Point(145, 141);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(73, 23);
            this.lblSum.TabIndex = 5;
            // 
            // lblE1
            // 
            this.lblE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblE1.Location = new System.Drawing.Point(287, 49);
            this.lblE1.Name = "lblE1";
            this.lblE1.Size = new System.Drawing.Size(37, 23);
            this.lblE1.TabIndex = 6;
            // 
            // lblE2
            // 
            this.lblE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblE2.Location = new System.Drawing.Point(522, 47);
            this.lblE2.Name = "lblE2";
            this.lblE2.Size = new System.Drawing.Size(37, 23);
            this.lblE2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(750, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 164);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Array method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1006, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblE2);
            this.Controls.Add(this.lblE1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lstContentABC);
            this.Controls.Add(this.lstContent);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lstContent;
        private System.Windows.Forms.ListBox lstContentABC;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblE1;
        private System.Windows.Forms.Label lblE2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

