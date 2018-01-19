namespace AverageScore
{
    partial class frmAverage
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
            this.lstAverage = new System.Windows.Forms.ListBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAverage
            // 
            this.lstAverage.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAverage.FormattingEnabled = true;
            this.lstAverage.ItemHeight = 20;
            this.lstAverage.Location = new System.Drawing.Point(13, 13);
            this.lstAverage.Name = "lstAverage";
            this.lstAverage.Size = new System.Drawing.Size(1287, 344);
            this.lstAverage.TabIndex = 0;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.Black;
            this.btnCompute.Location = new System.Drawing.Point(501, 386);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(328, 41);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // frmAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 449);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lstAverage);
            this.Name = "frmAverage";
            this.Text = "Average Score";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAverage;
        private System.Windows.Forms.Button btnCompute;
    }
}

