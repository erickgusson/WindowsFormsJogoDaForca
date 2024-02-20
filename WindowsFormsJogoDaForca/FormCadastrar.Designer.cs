namespace WindowsFormsJogoDaForca
{
    partial class FormCadastrar
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
            this.listViewCadastro = new System.Windows.Forms.ListView();
            this.txbCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txbIDRemover = new System.Windows.Forms.TextBox();
            this.txbPalavraAtualizada = new System.Windows.Forms.TextBox();
            this.txbIDAtualizar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewCadastro
            // 
            this.listViewCadastro.HideSelection = false;
            this.listViewCadastro.Location = new System.Drawing.Point(12, 12);
            this.listViewCadastro.Name = "listViewCadastro";
            this.listViewCadastro.Size = new System.Drawing.Size(310, 216);
            this.listViewCadastro.TabIndex = 0;
            this.listViewCadastro.UseCompatibleStateImageBehavior = false;
            // 
            // txbCadastro
            // 
            this.txbCadastro.Location = new System.Drawing.Point(12, 247);
            this.txbCadastro.Name = "txbCadastro";
            this.txbCadastro.Size = new System.Drawing.Size(214, 20);
            this.txbCadastro.TabIndex = 1;
            this.txbCadastro.Text = "Nova palavra";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(232, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(232, 276);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(232, 305);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txbIDRemover
            // 
            this.txbIDRemover.Location = new System.Drawing.Point(12, 279);
            this.txbIDRemover.Name = "txbIDRemover";
            this.txbIDRemover.Size = new System.Drawing.Size(214, 20);
            this.txbIDRemover.TabIndex = 5;
            this.txbIDRemover.Text = "ID";
            // 
            // txbPalavraAtualizada
            // 
            this.txbPalavraAtualizada.Location = new System.Drawing.Point(92, 308);
            this.txbPalavraAtualizada.Name = "txbPalavraAtualizada";
            this.txbPalavraAtualizada.Size = new System.Drawing.Size(134, 20);
            this.txbPalavraAtualizada.TabIndex = 6;
            this.txbPalavraAtualizada.Text = "Palavra Atualizada";
            // 
            // txbIDAtualizar
            // 
            this.txbIDAtualizar.Location = new System.Drawing.Point(12, 308);
            this.txbIDAtualizar.Name = "txbIDAtualizar";
            this.txbIDAtualizar.Size = new System.Drawing.Size(76, 20);
            this.txbIDAtualizar.TabIndex = 7;
            this.txbIDAtualizar.Text = "ID";
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 390);
            this.Controls.Add(this.txbIDAtualizar);
            this.Controls.Add(this.txbPalavraAtualizada);
            this.Controls.Add(this.txbIDRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbCadastro);
            this.Controls.Add(this.listViewCadastro);
            this.Name = "FormCadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCadastro;
        private System.Windows.Forms.TextBox txbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txbIDRemover;
        private System.Windows.Forms.TextBox txbPalavraAtualizada;
        private System.Windows.Forms.TextBox txbIDAtualizar;
    }
}