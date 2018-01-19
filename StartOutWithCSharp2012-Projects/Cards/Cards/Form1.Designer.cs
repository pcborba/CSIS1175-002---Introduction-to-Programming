namespace Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCards = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picAce = new System.Windows.Forms.PictureBox();
            this.picKing = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCards
            // 
            this.lstCards.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCards.FormattingEnabled = true;
            this.lstCards.ItemHeight = 20;
            this.lstCards.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.lstCards.Location = new System.Drawing.Point(346, 264);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(165, 84);
            this.lstCards.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(250, 367);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Card";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picAce
            // 
            this.picAce.Image = ((System.Drawing.Image)(resources.GetObject("picAce.Image")));
            this.picAce.Location = new System.Drawing.Point(58, 19);
            this.picAce.Name = "picAce";
            this.picAce.Size = new System.Drawing.Size(165, 217);
            this.picAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAce.TabIndex = 3;
            this.picAce.TabStop = false;
            this.picAce.Visible = false;
            // 
            // picKing
            // 
            this.picKing.Image = ((System.Drawing.Image)(resources.GetObject("picKing.Image")));
            this.picKing.Location = new System.Drawing.Point(346, 19);
            this.picKing.Name = "picKing";
            this.picKing.Size = new System.Drawing.Size(165, 217);
            this.picKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKing.TabIndex = 4;
            this.picKing.TabStop = false;
            this.picKing.Visible = false;
            // 
            // pic10
            // 
            this.pic10.Image = ((System.Drawing.Image)(resources.GetObject("pic10.Image")));
            this.pic10.Location = new System.Drawing.Point(632, 19);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(165, 217);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic10.TabIndex = 5;
            this.pic10.TabStop = false;
            this.pic10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 466);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.picKing);
            this.Controls.Add(this.picAce);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstCards);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picAce;
        private System.Windows.Forms.PictureBox picKing;
        private System.Windows.Forms.PictureBox pic10;
    }
}

