namespace assignment3solution
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
            this.BTNresult = new System.Windows.Forms.Button();
            this.LSTresult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNresult
            // 
            this.BTNresult.Location = new System.Drawing.Point(12, 12);
            this.BTNresult.Name = "BTNresult";
            this.BTNresult.Size = new System.Drawing.Size(97, 43);
            this.BTNresult.TabIndex = 0;
            this.BTNresult.Text = "Show Result";
            this.BTNresult.UseVisualStyleBackColor = true;
            this.BTNresult.Click += new System.EventHandler(this.BTNresult_Click);
            // 
            // LSTresult
            // 
            this.LSTresult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTresult.FormattingEnabled = true;
            this.LSTresult.ItemHeight = 14;
            this.LSTresult.Location = new System.Drawing.Point(12, 69);
            this.LSTresult.Name = "LSTresult";
            this.LSTresult.Size = new System.Drawing.Size(830, 298);
            this.LSTresult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 385);
            this.Controls.Add(this.LSTresult);
            this.Controls.Add(this.BTNresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNresult;
        private System.Windows.Forms.ListBox LSTresult;
    }
}

