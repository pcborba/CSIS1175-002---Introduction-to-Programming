namespace demo2Week8
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lstStart = new System.Windows.Forms.ListBox();
            this.lstEnd = new System.Windows.Forms.ListBox();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRoute = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initialze Manually";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(16, 101);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(114, 134);
            this.lstNames.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Initialze with IO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Find Max and Min";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 56);
            this.button4.TabIndex = 4;
            this.button4.Text = "Resize Array";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstStart
            // 
            this.lstStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStart.FormattingEnabled = true;
            this.lstStart.ItemHeight = 20;
            this.lstStart.Location = new System.Drawing.Point(352, 92);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(114, 164);
            this.lstStart.Sorted = true;
            this.lstStart.TabIndex = 5;
            // 
            // lstEnd
            // 
            this.lstEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnd.FormattingEnabled = true;
            this.lstEnd.ItemHeight = 20;
            this.lstEnd.Location = new System.Drawing.Point(507, 92);
            this.lstEnd.Name = "lstEnd";
            this.lstEnd.Size = new System.Drawing.Size(114, 164);
            this.lstEnd.Sorted = true;
            this.lstEnd.TabIndex = 6;
            // 
            // lstRoute
            // 
            this.lstRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.ItemHeight = 20;
            this.lstRoute.Location = new System.Drawing.Point(662, 92);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.Size = new System.Drawing.Size(114, 124);
            this.lstRoute.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Starting Pt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ending Pt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Route";
            // 
            // btnRoute
            // 
            this.btnRoute.Location = new System.Drawing.Point(352, 281);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(128, 56);
            this.btnRoute.TabIndex = 11;
            this.btnRoute.Text = "Find the route";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 56);
            this.button5.TabIndex = 12;
            this.button5.Text = "List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(157, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 56);
            this.button6.TabIndex = 13;
            this.button6.Text = "List max and min";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 455);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRoute);
            this.Controls.Add(this.lstEnd);
            this.Controls.Add(this.lstStart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstStart;
        private System.Windows.Forms.ListBox lstEnd;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

