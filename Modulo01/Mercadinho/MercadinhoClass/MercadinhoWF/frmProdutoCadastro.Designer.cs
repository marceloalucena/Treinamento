namespace MercadinhoWF
{
    partial class frmProdutoCadastro
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numValorCusto = new System.Windows.Forms.NumericUpDown();
            this.numFatorPreco = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numValorCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFatorPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor de Custo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(317, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(317, 158);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(274, 20);
            this.txtDescricao.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(317, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 20);
            this.txtID.TabIndex = 26;
            // 
            // numValorCusto
            // 
            this.numValorCusto.DecimalPlaces = 2;
            this.numValorCusto.Location = new System.Drawing.Point(317, 188);
            this.numValorCusto.Name = "numValorCusto";
            this.numValorCusto.Size = new System.Drawing.Size(120, 20);
            this.numValorCusto.TabIndex = 33;
            // 
            // numFatorPreco
            // 
            this.numFatorPreco.DecimalPlaces = 2;
            this.numFatorPreco.Location = new System.Drawing.Point(317, 214);
            this.numFatorPreco.Name = "numFatorPreco";
            this.numFatorPreco.Size = new System.Drawing.Size(120, 20);
            this.numFatorPreco.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fator de Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Estoque Mínimo";
            // 
            // numEstoqueMinimo
            // 
            this.numEstoqueMinimo.Location = new System.Drawing.Point(317, 240);
            this.numEstoqueMinimo.Name = "numEstoqueMinimo";
            this.numEstoqueMinimo.Size = new System.Drawing.Size(120, 20);
            this.numEstoqueMinimo.TabIndex = 36;
            // 
            // frmProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numEstoqueMinimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFatorPreco);
            this.Controls.Add(this.numValorCusto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Name = "frmProdutoCadastro";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmProdutoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValorCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFatorPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown numValorCusto;
        private System.Windows.Forms.NumericUpDown numFatorPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numEstoqueMinimo;
    }
}