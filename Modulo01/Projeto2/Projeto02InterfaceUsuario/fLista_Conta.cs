using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto2;

namespace Projeto02InterfaceUsuario
{
    public partial class fLista_Conta : Form
    {
        public ContaRepository contaRepository = new ContaRepository();
        public List<Conta> Contas { get; set; }
        public void Initialize()
        {
            Contas = new List<Conta>();
            dgvLista_Contas.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Contas = contaRepository.Obter().ToList();
            dgvLista_Contas.DataSource = null;
            dgvLista_Contas.DataSource = Contas.OrderBy(a => a.Id).ToList();
        }
        public fLista_Conta()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fCad_Conta frm = new fCad_Conta();
            frm.ShowDialog();
            
            contaRepository.Inserir(frm.ContaManutencao);
            AtualizarGrid();
        }

        private void dgvLista_Contas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conta conta = (Conta)(dgvLista_Contas.SelectedRows[0].DataBoundItem);
            if (dgvLista_Contas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Contas.SelectedRows.Count > 0)
                {
                    fCad_Conta frm = new fCad_Conta();
                    frm.PreencherConta(conta);
                    frm.ShowDialog();
                    if (frm.ContaManutencao != null)
                    {
                        contaRepository.Editar(frm.ContaManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Contas.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    contaRepository.Apagar(conta.Id);
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
