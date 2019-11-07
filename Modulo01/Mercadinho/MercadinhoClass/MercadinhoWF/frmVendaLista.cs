using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadinhoClass;

namespace MercadinhoWF
{
    public partial class frmVendaLista : Form
    {
        public VendaRepository vendaRepository = new VendaRepository();

        public List<Venda> Vendas { get; set; }
        public void Initialize()
        {
            Vendas = new List<Venda>();
            dgvLista_Vendas.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Vendas = vendaRepository.Obter().ToList();
            dgvLista_Vendas.DataSource = null;
            dgvLista_Vendas.DataSource = Vendas.OrderBy(a => a.DataVenda).ToList();
        }

        public frmVendaLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmVendaCadastro frm = new frmVendaCadastro();
            frm.ShowDialog();

            if (frm.VendaManutencao != null)
            {
                vendaRepository.Inserir(frm.VendaManutencao);
                AtualizarGrid();
            }
        }

        private void dgvLista_Vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Venda venda = (Venda)(dgvLista_Vendas.SelectedRows[0].DataBoundItem);
            if (dgvLista_Vendas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Vendas.SelectedRows.Count > 0)
                {
                    frmVendaCadastro frm = new frmVendaCadastro();
                    frm.Preencher(venda);
                    frm.ShowDialog();
                    if (frm.VendaManutencao != null)
                    {
                        vendaRepository.Editar(frm.VendaManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Vendas.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    vendaRepository.Apagar(venda.Id);
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
