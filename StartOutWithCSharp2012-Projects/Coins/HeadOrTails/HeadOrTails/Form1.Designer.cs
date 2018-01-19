namespace HeadOrTails
{
    partial class frmHeadOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeadOrTails));
            this.btnHead = new System.Windows.Forms.Button();
            this.btnTail = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.picTail = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(86, 177);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(142, 70);
            this.btnHead.TabIndex = 0;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // btnTail
            // 
            this.btnTail.Location = new System.Drawing.Point(387, 177);
            this.btnTail.Name = "btnTail";
            this.btnTail.Size = new System.Drawing.Size(142, 70);
            this.btnTail.TabIndex = 1;
            this.btnTail.Text = "Tail";
            this.btnTail.UseVisualStyleBackColor = true;
            this.btnTail.Click += new System.EventHandler(this.btnTail_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picHead
            // 
            this.picHead.Image = ((System.Drawing.Image)(resources.GetObject("picHead.Image")));
            this.picHead.Location = new System.Drawing.Point(86, 12);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(150, 150);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHead.TabIndex = 3;
            this.picHead.TabStop = false;
            this.picHead.Visible = false;
            // 
            // picTail
            // 
            this.picTail.Image = ((System.Drawing.Image)(resources.GetObject("picTail.Image")));
            this.picTail.Location = new System.Drawing.Point(379, 12);
            this.picTail.Name = "picTail";
            this.picTail.Size = new System.Drawing.Size(150, 150);
            this.picTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTail.TabIndex = 4;
            this.picTail.TabStop = false;
            this.picTail.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Toss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHeadOrTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picTail);
            this.Controls.Add(this.picHead);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTail);
            this.Controls.Add(this.btnHead);
            this.Name = "frmHeadOrTails";
            this.Text = "Head or Tail";
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Button btnTail;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.PictureBox picTail;
        private System.Windows.Forms.Button button1;
    }
}

