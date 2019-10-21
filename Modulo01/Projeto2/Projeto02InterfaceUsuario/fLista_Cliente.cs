using Projeto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto02InterfaceUsuario
{
    public partial class fLista_Cliente : Form
    {
        public ClienteRepository cliRepository = new ClienteRepository();
        public List<Cliente> Clientes { get; set; }
        public void Initialize()
        {
            Clientes = cliRepository.Obter();
            dgvLista_Cliente.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Clientes = cliRepository.Obter().ToList();
            dgvLista_Cliente.DataSource = null;
            dgvLista_Cliente.DataSource = Clientes.OrderBy(a => a.Nome).ToList();
        }

        public fLista_Cliente()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fCad_Cliente frm = new fCad_Cliente();
            frm.ShowDialog();
            cliRepository.Inserir(frm.ClienteManutencao);
            AtualizarGrid();
        }

        private void dgvLista_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)(dgvLista_Cliente.SelectedRows[0].DataBoundItem);
            if (dgvLista_Cliente.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Cliente.SelectedRows.Count > 0)
                {

                    fCad_Cliente frm = new fCad_Cliente();
                    frm.PreencherCliente(cliente);
                    frm.ShowDialog();
                    cliRepository.Editar(frm.ClienteManutencao);

                    AtualizarGrid();
                }
            }
            else if (dgvLista_Cliente.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cliRepository.Apagar(cliente.Id);
                    AtualizarGrid();
                    MessageBox.Show("Item Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }
        }

        private void fLista_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
