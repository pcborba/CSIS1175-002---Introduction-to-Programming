namespace Demo2Week3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnVariable = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewResult = new System.Windows.Forms.TextBox();
            this.btnNewCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(8, 6);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(75, 23);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "Show Msg";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(242, 42);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(229, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnVariable
            // 
            this.btnVariable.Location = new System.Drawing.Point(8, 39);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(75, 23);
            this.btnVariable.TabIndex = 5;
            this.btnVariable.Text = "Show Msg";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(8, 92);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(75, 23);
            this.btnComputer.TabIndex = 6;
            this.btnComputer.Text = "Calc";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value 1";
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(172, 69);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(100, 20);
            this.txtVar1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value 2";
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(325, 68);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(100, 20);
            this.txtVar2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Value 3";
            // 
            // txtNewResult
            // 
            this.txtNewResult.Enabled = false;
            this.txtNewResult.Location = new System.Drawing.Point(478, 68);
            this.txtNewResult.Name = "txtNewResult";
            this.txtNewResult.Size = new System.Drawing.Size(100, 20);
            this.txtNewResult.TabIndex = 8;
            // 
            // btnNewCalc
            // 
            this.btnNewCalc.Location = new System.Drawing.Point(8, 121);
            this.btnNewCalc.Name = "btnNewCalc";
            this.btnNewCalc.Size = new System.Drawing.Size(75, 55);
            this.btnNewCalc.TabIndex = 9;
            this.btnNewCalc.Text = "Calc with error trapping";
            this.btnNewCalc.UseVisualStyleBackColor = true;
            this.btnNewCalc.Click += new System.EventHandler(this.btnNewCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(126, 121);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(75, 23);
            this.btnDateTime.TabIndex = 12;
            this.btnDateTime.Text = "Date Time Type";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hrs worked";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(336, 124);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pay Rate";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(336, 150);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtPayRate.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(267, 182);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewCalc);
            this.Controls.Add(this.txtNewResult);
            this.Controls.Add(this.txtVar2);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewResult;
        private System.Windows.Forms.Button btnNewCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button btnPayment;
    }
}

