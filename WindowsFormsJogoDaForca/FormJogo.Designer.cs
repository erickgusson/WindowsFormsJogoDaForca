namespace WindowsFormsJogoDaForca
{
    partial class FormJogo
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
            this.lbPalavraSecreta = new System.Windows.Forms.Label();
            this.txbTentativa = new System.Windows.Forms.TextBox();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPalavraSecreta
            // 
            this.lbPalavraSecreta.AutoSize = true;
            this.lbPalavraSecreta.Location = new System.Drawing.Point(46, 44);
            this.lbPalavraSecreta.Name = "lbPalavraSecreta";
            this.lbPalavraSecreta.Size = new System.Drawing.Size(35, 13);
            this.lbPalavraSecreta.TabIndex = 0;
            this.lbPalavraSecreta.Text = "label1";
            // 
            // txbTentativa
            // 
            this.txbTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTentativa.Location = new System.Drawing.Point(43, 239);
            this.txbTentativa.MaxLength = 1;
            this.txbTentativa.Name = "txbTentativa";
            this.txbTentativa.Size = new System.Drawing.Size(38, 49);
            this.txbTentativa.TabIndex = 1;
            this.txbTentativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(114, 249);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarLetra.TabIndex = 2;
            this.btnVerificarLetra.Text = "Verificar";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 301);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.txbTentativa);
            this.Controls.Add(this.lbPalavraSecreta);
            this.Name = "FormJogo";
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalavraSecreta;
        private System.Windows.Forms.TextBox txbTentativa;
        private System.Windows.Forms.Button btnVerificarLetra;
    }
}