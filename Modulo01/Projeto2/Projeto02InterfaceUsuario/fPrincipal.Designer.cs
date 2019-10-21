namespace Projeto02InterfaceUsuario
{
    partial class fPrincipal
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
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnCaixaEletronico = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(54, 39);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(300, 54);
            this.btnBanco.TabIndex = 0;
            this.btnBanco.Text = "Banco";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(54, 125);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(301, 54);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(54, 217);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(301, 54);
            this.btnConta.TabIndex = 2;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnCaixaEletronico
            // 
            this.btnCaixaEletronico.Location = new System.Drawing.Point(54, 304);
            this.btnCaixaEletronico.Name = "btnCaixaEletronico";
            this.btnCaixaEletronico.Size = new System.Drawing.Size(301, 54);
            this.btnCaixaEletronico.TabIndex = 3;
            this.btnCaixaEletronico.Text = "Caixa Eletrônico";
            this.btnCaixaEletronico.UseVisualStyleBackColor = true;
            this.btnCaixaEletronico.Click += new System.EventHandler(this.btnCaixaEletronico_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(54, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(301, 54);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 489);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCaixaEletronico);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnBanco);
            this.Name = "fPrincipal";
            this.Text = "Projeto 02 - Interface com o Usuário";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnCaixaEletronico;
        private System.Windows.Forms.Button btnSair;
    }
}

