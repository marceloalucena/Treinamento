namespace MercadinhoWF
{
    partial class frmCompraLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvLista_Compras = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNovo.Location = new System.Drawing.Point(0, 397);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(800, 53);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvLista_Compras
            // 
            this.dgvLista_Compras.AllowUserToOrderColumns = true;
            this.dgvLista_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.FornecedorNome,
            this.ProdutoDescricao,
            this.Descricao,
            this.ValorCompra,
            this.btnEditar,
            this.btnApagar});
            this.dgvLista_Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista_Compras.Location = new System.Drawing.Point(0, 0);
            this.dgvLista_Compras.Name = "dgvLista_Compras";
            this.dgvLista_Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista_Compras.Size = new System.Drawing.Size(800, 450);
            this.dgvLista_Compras.TabIndex = 9;
            this.dgvLista_Compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Compras_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "DataCompra";
            this.Nome.HeaderText = "Data Compra";
            this.Nome.Name = "Nome";
            this.Nome.Width = 80;
            // 
            // FornecedorNome
            // 
            this.FornecedorNome.DataPropertyName = "FornecedorNome";
            this.FornecedorNome.HeaderText = "FornecedorNome";
            this.FornecedorNome.Name = "FornecedorNome";
            // 
            // ProdutoDescricao
            // 
            this.ProdutoDescricao.DataPropertyName = "ProdutoDescricao";
            this.ProdutoDescricao.HeaderText = "ProdutoDescricao";
            this.ProdutoDescricao.Name = "ProdutoDescricao";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "QtdeVenda";
            this.Descricao.HeaderText = "Qtde Venda";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 130;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "ValorCompra";
            this.ValorCompra.Name = "ValorCompra";
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
            // frmCompraLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvLista_Compras);
            this.Name = "frmCompraLista";
            this.Text = "Listagem de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvLista_Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}