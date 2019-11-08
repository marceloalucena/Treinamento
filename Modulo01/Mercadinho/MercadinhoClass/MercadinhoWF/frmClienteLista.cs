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
    public partial class frmClienteLista : Form
    {
        public ClienteRepository clienteRepository = new ClienteRepository();
        public List<Cliente> Clientes { get; set; }
        public void Initialize()
        {
            Clientes = new List<Cliente>();
            dgvLista_Cliente.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Clientes = clienteRepository.Obter().ToList();
            dgvLista_Cliente.DataSource = null;
            dgvLista_Cliente.DataSource = Clientes.OrderBy(a => a.Nome).ToList();
        }

        public frmClienteLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void dgvLista_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)(dgvLista_Cliente.SelectedRows[0].DataBoundItem);
            if (dgvLista_Cliente.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Cliente.SelectedRows.Count > 0)
                {
                    frmClienteCadastro frm = new frmClienteCadastro();
                    frm.Preencher(cliente);
                    frm.ShowDialog();
                    if (frm.ClienteManutencao != null)
                    {
                        clienteRepository.Editar(frm.ClienteManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Cliente.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clienteRepository.Apagar(cliente);
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
            frmClienteCadastro frm = new frmClienteCadastro();
            frm.ShowDialog();
            if (frm.ClienteManutencao != null) 
            {
               clienteRepository.Inserir(frm.ClienteManutencao);
               AtualizarGrid();
            }
        }
    }
}
