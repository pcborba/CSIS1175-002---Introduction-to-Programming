namespace FullName
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtMidle = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.btnFull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Midle name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last name";
            // 
            // lblFull
            // 
            this.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFull.Location = new System.Drawing.Point(142, 142);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(350, 29);
            this.lblFull.TabIndex = 4;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(142, 27);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(203, 22);
            this.txtFirst.TabIndex = 5;
            // 
            // txtMidle
            // 
            this.txtMidle.Location = new System.Drawing.Point(142, 59);
            this.txtMidle.Name = "txtMidle";
            this.txtMidle.Size = new System.Drawing.Size(203, 22);
            this.txtMidle.TabIndex = 6;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(142, 90);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(203, 22);
            this.txtLast.TabIndex = 7;
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(181, 195);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(164, 23);
            this.btnFull.TabIndex = 8;
            this.btnFull.Text = "Full Name";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 253);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMidle);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtMidle;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Button btnFull;
    }
}

