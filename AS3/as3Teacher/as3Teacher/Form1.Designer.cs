namespace as3Teacher
{
    partial class frmAssignment3
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
            this.btnResult = new System.Windows.Forms.Button();
            this.lsrResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(4, 13);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Show Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lsrResult
            // 
            this.lsrResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsrResult.FormattingEnabled = true;
            this.lsrResult.ItemHeight = 15;
            this.lsrResult.Location = new System.Drawing.Point(4, 42);
            this.lsrResult.Name = "lsrResult";
            this.lsrResult.Size = new System.Drawing.Size(905, 259);
            this.lsrResult.TabIndex = 1;
            // 
            // frmAssignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 337);
            this.Controls.Add(this.lsrResult);
            this.Controls.Add(this.btnResult);
            this.Name = "frmAssignment3";
            this.Text = "Assignment 3";
            this.Load += new System.EventHandler(this.frmAssignment3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ListBox lsrResult;
    }
}

