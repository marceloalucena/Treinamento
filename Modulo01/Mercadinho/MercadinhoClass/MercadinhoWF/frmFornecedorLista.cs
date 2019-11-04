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
    public partial class frmFornecedorLista : Form
    {
        public FornecedorRepository fornecedorRepository = new FornecedorRepository();
        public List<Fornecedor> Fornecedores { get; set; }
        public void Initialize()
        {
            Fornecedores = new List<Fornecedor>();
            dgvLista_Fornecedor.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Fornecedores = fornecedorRepository.Obter().ToList();
            dgvLista_Fornecedor.DataSource = null;
            dgvLista_Fornecedor.DataSource = Fornecedores.OrderBy(a => a.Nome).ToList();
        }

        public frmFornecedorLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastro frm = new frmFornecedorCadastro();
            frm.ShowDialog();

            fornecedorRepository.Inserir(frm.FornecedorManutencao);
            AtualizarGrid();
        }

        private void dgvLista_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fornecedor fornecedor = (Fornecedor)(dgvLista_Fornecedor.SelectedRows[0].DataBoundItem);
            if (dgvLista_Fornecedor.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Fornecedor.SelectedRows.Count > 0)
                {
                    frmFornecedorCadastro frm = new frmFornecedorCadastro();
                    frm.Preencher(fornecedor);
                    frm.ShowDialog();
                    if (frm.FornecedorManutencao != null)
                    {
                        fornecedorRepository.Editar(frm.FornecedorManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Fornecedor.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    fornecedorRepository.Apagar(fornecedor.Id);
                    AtualizarGrid();
                    MessageBox.Show("Item Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }

        }
    }
}
