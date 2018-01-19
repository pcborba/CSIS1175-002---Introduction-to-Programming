namespace CompareString
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblLstSelection = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStartingBalance = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndingBalance = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lstSquare = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCreWri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(247, 90);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Pera",
            "Uva",
            "Banana",
            "Maça",
            "Salada Mixta"});
            this.listBox1.Location = new System.Drawing.Point(247, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 100);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblLstSelection
            // 
            this.lblLstSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLstSelection.Location = new System.Drawing.Point(247, 247);
            this.lblLstSelection.Name = "lblLstSelection";
            this.lblLstSelection.Size = new System.Drawing.Size(329, 23);
            this.lblLstSelection.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fruit Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNames
            // 
            this.btnNames.Location = new System.Drawing.Point(361, 302);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(75, 23);
            this.btnNames.TabIndex = 5;
            this.btnNames.Text = "Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(247, 31);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 6;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Balance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtStartingBalance
            // 
            this.txtStartingBalance.Location = new System.Drawing.Point(748, 91);
            this.txtStartingBalance.Name = "txtStartingBalance";
            this.txtStartingBalance.Size = new System.Drawing.Size(100, 22);
            this.txtStartingBalance.TabIndex = 8;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(748, 120);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 22);
            this.txtMonths.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Starting Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "# of months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ending Balance";
            // 
            // lblEndingBalance
            // 
            this.lblEndingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndingBalance.Location = new System.Drawing.Point(748, 311);
            this.lblEndingBalance.Name = "lblEndingBalance";
            this.lblEndingBalance.Size = new System.Drawing.Size(107, 17);
            this.lblEndingBalance.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(748, 149);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(369, 157);
            this.listBox2.TabIndex = 14;
            // 
            // lstSquare
            // 
            this.lstSquare.FormattingEnabled = true;
            this.lstSquare.ItemHeight = 16;
            this.lstSquare.Location = new System.Drawing.Point(12, 351);
            this.lstSquare.Name = "lstSquare";
            this.lstSquare.Size = new System.Drawing.Size(320, 84);
            this.lstSquare.TabIndex = 15;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(115, 442);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCreWri
            // 
            this.btnCreWri.Location = new System.Drawing.Point(704, 497);
            this.btnCreWri.Name = "btnCreWri";
            this.btnCreWri.Size = new System.Drawing.Size(221, 37);
            this.btnCreWri.TabIndex = 17;
            this.btnCreWri.Text = "Create and Write a file";
            this.btnCreWri.UseVisualStyleBackColor = true;
            this.btnCreWri.Click += new System.EventHandler(this.btnCreWri_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(704, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "append text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(786, 412);
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(100, 22);
            this.txtAppend.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(704, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "READ FILE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 565);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtAppend);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCreWri);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lstSquare);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblEndingBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtStartingBalance);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLstSelection);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblLstSelection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtStartingBalance;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndingBalance;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox lstSquare;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCreWri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.Button button5;
    }
}

