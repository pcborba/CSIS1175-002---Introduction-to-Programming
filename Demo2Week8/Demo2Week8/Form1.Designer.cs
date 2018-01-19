namespace Demo2Week8
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
            this.btnInit = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnInitIO = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.lstStart = new System.Windows.Forms.ListBox();
            this.lstEnd = new System.Windows.Forms.ListBox();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(7, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(109, 50);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Initialize Manual";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lstNames
            // 
            this.lstNames.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 15;
            this.lstNames.Location = new System.Drawing.Point(7, 68);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(109, 154);
            this.lstNames.TabIndex = 1;
            // 
            // btnInitIO
            // 
            this.btnInitIO.Location = new System.Drawing.Point(133, 12);
            this.btnInitIO.Name = "btnInitIO";
            this.btnInitIO.Size = new System.Drawing.Size(109, 50);
            this.btnInitIO.TabIndex = 2;
            this.btnInitIO.Text = "Initialize with IO";
            this.btnInitIO.UseVisualStyleBackColor = true;
            this.btnInitIO.Click += new System.EventHandler(this.btnInitIO_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(133, 68);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 50);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find Max and Min";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(133, 124);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(109, 50);
            this.btnResize.TabIndex = 4;
            this.btnResize.Text = "Resize Array";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lstStart
            // 
            this.lstStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStart.FormattingEnabled = true;
            this.lstStart.ItemHeight = 18;
            this.lstStart.Location = new System.Drawing.Point(259, 53);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(109, 148);
            this.lstStart.Sorted = true;
            this.lstStart.TabIndex = 5;
            // 
            // lstEnd
            // 
            this.lstEnd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnd.FormattingEnabled = true;
            this.lstEnd.ItemHeight = 18;
            this.lstEnd.Location = new System.Drawing.Point(374, 53);
            this.lstEnd.Name = "lstEnd";
            this.lstEnd.Size = new System.Drawing.Size(109, 148);
            this.lstEnd.Sorted = true;
            this.lstEnd.TabIndex = 6;
            // 
            // lstRoute
            // 
            this.lstRoute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.ItemHeight = 18;
            this.lstRoute.Location = new System.Drawing.Point(489, 53);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.Size = new System.Drawing.Size(109, 148);
            this.lstRoute.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ending Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Route";
            // 
            // btnRoute
            // 
            this.btnRoute.Location = new System.Drawing.Point(604, 34);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(109, 50);
            this.btnRoute.TabIndex = 11;
            this.btnRoute.Text = "Route";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(133, 226);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(109, 50);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "List ";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 84);
            this.button1.TabIndex = 13;
            this.button1.Text = "List Max and Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRoute);
            this.Controls.Add(this.lstEnd);
            this.Controls.Add(this.lstStart);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnInitIO);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnInitIO;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.ListBox lstStart;
        private System.Windows.Forms.ListBox lstEnd;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button button1;
    }
}

