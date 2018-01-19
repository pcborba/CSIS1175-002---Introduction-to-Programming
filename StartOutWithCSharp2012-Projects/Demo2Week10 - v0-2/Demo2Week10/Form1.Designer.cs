namespace Demo2Week10
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
            this.btnAvg = new System.Windows.Forms.Button();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.txtQ4 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(73, 96);
            this.btnAvg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(98, 60);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Calc Best Avg 3 of 4 from text box";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // txtQ1
            // 
            this.txtQ1.Location = new System.Drawing.Point(73, 55);
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(52, 22);
            this.txtQ1.TabIndex = 4;
            // 
            // txtQ2
            // 
            this.txtQ2.Location = new System.Drawing.Point(131, 55);
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(52, 22);
            this.txtQ2.TabIndex = 5;
            // 
            // txtQ3
            // 
            this.txtQ3.Location = new System.Drawing.Point(189, 55);
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(52, 22);
            this.txtQ3.TabIndex = 6;
            // 
            // txtQ4
            // 
            this.txtQ4.Location = new System.Drawing.Point(247, 55);
            this.txtQ4.Name = "txtQ4";
            this.txtQ4.Size = new System.Drawing.Size(52, 22);
            this.txtQ4.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Teal;
            this.lblResult.Location = new System.Drawing.Point(68, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 25);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calc Best Avg 3 of 4 from a file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtQ4);
            this.Controls.Add(this.txtQ3);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.btnAvg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox txtQ1;
        private System.Windows.Forms.TextBox txtQ2;
        private System.Windows.Forms.TextBox txtQ3;
        private System.Windows.Forms.TextBox txtQ4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}

