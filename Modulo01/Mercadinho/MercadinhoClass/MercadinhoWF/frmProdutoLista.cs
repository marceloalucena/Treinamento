using MercadinhoClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadinhoWF
{
    public partial class frmProdutoLista : Form
    {
        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public List<Produto> Produtos { get; set; }
        public void Initialize()
        {
            Produtos = new List<Produto>();
            dgvLista_Produto.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Produtos = produtoRepository.Obter().ToList();
            dgvLista_Produto.DataSource = null;
            dgvLista_Produto.DataSource = Produtos.OrderBy(a => a.Descricao).ToList();
        }
        public frmProdutoLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void dgvLista_Produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produto = (Produto)(dgvLista_Produto.SelectedRows[0].DataBoundItem);
            if (dgvLista_Produto.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Produto.SelectedRows.Count > 0)
                {
                    frmProdutoCadastro frm = new frmProdutoCadastro();
                    frm.Preencher(produto);
                    frm.ShowDialog();
                    if (frm.ProdutoManutencao != null)
                    {
                        produtoRepository.Editar(frm.ProdutoManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Produto.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    produtoRepository.Apagar(produto.Id);
                    AtualizarGrid();
                    MessageBox.Show("Item Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro frm = new frmProdutoCadastro();
            frm.ShowDialog();

            produtoRepository.Inserir(frm.ProdutoManutencao);
            AtualizarGrid();
        }

        private void dgvLista_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
