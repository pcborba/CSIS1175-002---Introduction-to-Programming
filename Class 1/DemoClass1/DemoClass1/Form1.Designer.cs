namespace DemoClass1
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
            this.btnMsg = new System.Windows.Forms.Button();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(12, 23);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(117, 54);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "Click here for message";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // picFish
            // 
            this.picFish.ImageLocation = "c:\\temp\\jellyfish.jpg";
            this.picFish.Location = new System.Drawing.Point(179, 23);
            this.picFish.Name = "picFish";
            this.picFish.Size = new System.Drawing.Size(255, 152);
            this.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFish.TabIndex = 2;
            this.picFish.TabStop = false;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(12, 83);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(117, 58);
            this.btnImg.TabIndex = 3;
            this.btnImg.Text = "Show LightHouse";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(13, 148);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(116, 47);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide image";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(330, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter your name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.picFish);
            this.Controls.Add(this.btnMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.PictureBox picFish;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

