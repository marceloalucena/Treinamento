namespace MercadinhoWF
{
    partial class frmVendaLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvLista_Vendas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNovo.Location = new System.Drawing.Point(0, 386);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(892, 53);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvLista_Vendas
            // 
            this.dgvLista_Vendas.AllowUserToOrderColumns = true;
            this.dgvLista_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.ClienteNome,
            this.ProdutoDescricao,
            this.Descricao,
            this.ValorVenda,
            this.btnEditar,
            this.btnApagar});
            this.dgvLista_Vendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista_Vendas.Location = new System.Drawing.Point(0, 0);
            this.dgvLista_Vendas.Name = "dgvLista_Vendas";
            this.dgvLista_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista_Vendas.Size = new System.Drawing.Size(892, 439);
            this.dgvLista_Vendas.TabIndex = 7;
            this.dgvLista_Vendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Vendas_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "DataVenda";
            this.Nome.HeaderText = "Data";
            this.Nome.Name = "Nome";
            this.Nome.Width = 80;
            // 
            // ClienteNome
            // 
            this.ClienteNome.DataPropertyName = "ClienteNome";
            this.ClienteNome.HeaderText = "Cliente";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.Width = 130;
            // 
            // ProdutoDescricao
            // 
            this.ProdutoDescricao.DataPropertyName = "ProdutoDescricao";
            this.ProdutoDescricao.HeaderText = "Produto";
            this.ProdutoDescricao.Name = "ProdutoDescricao";
            this.ProdutoDescricao.Width = 130;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "QtdeVenda";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descricao.HeaderText = "Qtde";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 70;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorVenda.HeaderText = "ValorVenda";
            this.ValorVenda.Name = "ValorVenda";
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
            // frmVendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 439);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvLista_Vendas);
            this.Name = "frmVendaLista";
            this.Text = "Listagem de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvLista_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}