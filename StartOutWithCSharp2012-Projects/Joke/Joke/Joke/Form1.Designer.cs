namespace Joke
{
    partial class frmPiada
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
            this.btnPiada = new System.Windows.Forms.Button();
            this.btnResposta = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPiada
            // 
            this.btnPiada.Location = new System.Drawing.Point(170, 193);
            this.btnPiada.Name = "btnPiada";
            this.btnPiada.Size = new System.Drawing.Size(128, 62);
            this.btnPiada.TabIndex = 0;
            this.btnPiada.Text = "Piada";
            this.btnPiada.UseVisualStyleBackColor = true;
            this.btnPiada.Click += new System.EventHandler(this.btnPiada_Click);
            // 
            // btnResposta
            // 
            this.btnResposta.Location = new System.Drawing.Point(331, 193);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(128, 62);
            this.btnResposta.TabIndex = 1;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(170, 94);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(289, 80);
            this.lblResposta.TabIndex = 2;
            // 
            // frmPiada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 290);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.btnPiada);
            this.Name = "frmPiada";
            this.Text = "Piada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiada;
        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.Label lblResposta;
    }
}

