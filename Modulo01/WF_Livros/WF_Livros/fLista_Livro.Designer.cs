namespace WF_Livros
{
    partial class fLista_Livro
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
            this.dgvLista_Livro = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Livro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista_Livro
            // 
            this.dgvLista_Livro.AllowUserToOrderColumns = true;
            this.dgvLista_Livro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Livro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titulo,
            this.Autor,
            this.DataLancamento,
            this.NumeroPaginas,
            this.btnEditar,
            this.btnApagar});
            this.dgvLista_Livro.Location = new System.Drawing.Point(44, 90);
            this.dgvLista_Livro.Name = "dgvLista_Livro";
            this.dgvLista_Livro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista_Livro.Size = new System.Drawing.Size(744, 204);
            this.dgvLista_Livro.TabIndex = 0;
            this.dgvLista_Livro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Livro_CellClick);
            this.dgvLista_Livro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Livro_CellContentClick);
            this.dgvLista_Livro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_Livro_CellDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(413, 348);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 53);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 130;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 130;
            // 
            // DataLancamento
            // 
            this.DataLancamento.DataPropertyName = "DataLancamento";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DataLancamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataLancamento.HeaderText = "Data Lanc.";
            this.DataLancamento.Name = "DataLancamento";
            this.DataLancamento.Width = 90;
            // 
            // NumeroPaginas
            // 
            this.NumeroPaginas.DataPropertyName = "NumeroPaginas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NumeroPaginas.DefaultCellStyle = dataGridViewCellStyle6;
            this.NumeroPaginas.HeaderText = "NumPags";
            this.NumeroPaginas.Name = "NumeroPaginas";
            this.NumeroPaginas.Width = 60;
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
            // fLista_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvLista_Livro);
            this.Name = "fLista_Livro";
            this.Text = "Lista de LIvros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Livro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista_Livro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPaginas;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}