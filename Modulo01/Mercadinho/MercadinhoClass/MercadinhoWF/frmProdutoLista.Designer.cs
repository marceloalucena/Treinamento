namespace MercadinhoWF
{
    partial class frmProdutoLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvLista_Produto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatorPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNovo.Location = new System.Drawing.Point(0, 430);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(969, 53);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvLista_Produto
            // 
            this.dgvLista_Produto.AllowUserToOrderColumns = true;
            this.dgvLista_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descricao,
            this.Nome,
            this.FatorPreco,
            this.PrecoVenda,
            this.EstoqueAtual,
            this.EstoqueMinimo,
            this.btnEditar,
            this.btnApagar});
            this.dgvLista_Produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista_Produto.Location = new System.Drawing.Point(0, 0);
            this.dgvLista_Produto.Name = "dgvLista_Produto";
            this.dgvLista_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista_Produto.Size = new System.Drawing.Size(969, 483);
            this.dgvLista_Produto.TabIndex = 3;
            this.dgvLista_Produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Produto_CellClick);
            this.dgvLista_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Produto_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle7;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 25;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 130;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "ValorCusto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nome.HeaderText = "ValorCusto";
            this.Nome.Name = "Nome";
            this.Nome.Width = 70;
            // 
            // FatorPreco
            // 
            this.FatorPreco.DataPropertyName = "FatorPreco";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FatorPreco.DefaultCellStyle = dataGridViewCellStyle9;
            this.FatorPreco.HeaderText = "FatorPreco";
            this.FatorPreco.Name = "FatorPreco";
            this.FatorPreco.Width = 70;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.DataPropertyName = "PrecoVenda";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PrecoVenda.DefaultCellStyle = dataGridViewCellStyle10;
            this.PrecoVenda.HeaderText = "PrecoVenda";
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.Width = 70;
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.DataPropertyName = "QtdeEstoqueAtual";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EstoqueAtual.DefaultCellStyle = dataGridViewCellStyle11;
            this.EstoqueAtual.HeaderText = "EstoqueAtual";
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.Width = 85;
            // 
            // EstoqueMinimo
            // 
            this.EstoqueMinimo.DataPropertyName = "QtdeEstoqueMinimo";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EstoqueMinimo.DefaultCellStyle = dataGridViewCellStyle12;
            this.EstoqueMinimo.HeaderText = "EstoqueMinimo";
            this.EstoqueMinimo.Name = "EstoqueMinimo";
            this.EstoqueMinimo.Width = 85;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnApagar
            // 
            this.btnApagar.HeaderText = "Apagar";
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseColumnTextForButtonValue = true;
            // 
            // frmProdutoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 483);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvLista_Produto);
            this.Name = "frmProdutoLista";
            this.Text = "Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvLista_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatorPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMinimo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}