namespace station
{
    partial class frmStytrain
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
            this.lstStart = new System.Windows.Forms.ListBox();
            this.lstEnd = new System.Windows.Forms.ListBox();
            this.btnRoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstStart
            // 
            this.lstStart.FormattingEnabled = true;
            this.lstStart.ItemHeight = 16;
            this.lstStart.Location = new System.Drawing.Point(66, 36);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(120, 196);
            this.lstStart.Sorted = true;
            this.lstStart.TabIndex = 0;
            this.lstStart.SelectedIndexChanged += new System.EventHandler(this.lstStart_SelectedIndexChanged);
            // 
            // lstEnd
            // 
            this.lstEnd.FormattingEnabled = true;
            this.lstEnd.ItemHeight = 16;
            this.lstEnd.Location = new System.Drawing.Point(212, 36);
            this.lstEnd.Name = "lstEnd";
            this.lstEnd.Size = new System.Drawing.Size(120, 196);
            this.lstEnd.Sorted = true;
            this.lstEnd.TabIndex = 1;
            // 
            // btnRoute
            // 
            this.btnRoute.Location = new System.Drawing.Point(397, 36);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(75, 23);
            this.btnRoute.TabIndex = 2;
            this.btnRoute.Text = "Route";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lstRoute
            // 
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.ItemHeight = 16;
            this.lstRoute.Location = new System.Drawing.Point(516, 36);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.Size = new System.Drawing.Size(120, 196);
            this.lstRoute.TabIndex = 4;
            // 
            // frmStytrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 321);
            this.Controls.Add(this.lstRoute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.lstEnd);
            this.Controls.Add(this.lstStart);
            this.Name = "frmStytrain";
            this.Text = "Skytrain Station";
            this.Load += new System.EventHandler(this.frmStytrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStart;
        private System.Windows.Forms.ListBox lstEnd;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRoute;
    }
}

