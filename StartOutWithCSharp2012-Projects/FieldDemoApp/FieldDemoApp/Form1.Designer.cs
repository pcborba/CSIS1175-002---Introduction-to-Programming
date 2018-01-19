namespace FieldDemoApp
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
            this.btnShowName = new System.Windows.Forms.Button();
            this.btnNameChris = new System.Windows.Forms.Button();
            this.btnNameCarmem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowName
            // 
            this.btnShowName.Location = new System.Drawing.Point(216, 26);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(115, 71);
            this.btnShowName.TabIndex = 0;
            this.btnShowName.Text = "Show Name";
            this.btnShowName.UseVisualStyleBackColor = true;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // btnNameChris
            // 
            this.btnNameChris.Location = new System.Drawing.Point(105, 132);
            this.btnNameChris.Name = "btnNameChris";
            this.btnNameChris.Size = new System.Drawing.Size(115, 71);
            this.btnNameChris.TabIndex = 0;
            this.btnNameChris.Text = "Change name to Chris";
            this.btnNameChris.UseVisualStyleBackColor = true;
            this.btnNameChris.Click += new System.EventHandler(this.btnNameChris_Click);
            // 
            // btnNameCarmem
            // 
            this.btnNameCarmem.Location = new System.Drawing.Point(327, 132);
            this.btnNameCarmem.Name = "btnNameCarmem";
            this.btnNameCarmem.Size = new System.Drawing.Size(115, 71);
            this.btnNameCarmem.TabIndex = 0;
            this.btnNameCarmem.Text = "Change name to Carmem";
            this.btnNameCarmem.UseVisualStyleBackColor = true;
            this.btnNameCarmem.Click += new System.EventHandler(this.btnNameCarmem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 307);
            this.Controls.Add(this.btnNameCarmem);
            this.Controls.Add(this.btnNameChris);
            this.Controls.Add(this.btnShowName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.Button btnNameChris;
        private System.Windows.Forms.Button btnNameCarmem;
    }
}

