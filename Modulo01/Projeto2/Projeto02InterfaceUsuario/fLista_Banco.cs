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
    public partial class fLista_Banco : Form
    {
        public BancoRepository bancoRepository = new BancoRepository();
        public List<Banco> Bancos { get; set; }
        public void Initialize()
        {
            Bancos = new List<Banco>(); 
            dgvLista_Banco.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Bancos = bancoRepository.Obter().ToList();
            dgvLista_Banco.DataSource = null;
            dgvLista_Banco.DataSource = Bancos.OrderBy(a => a.Codigo).ToList();
        }
        public fLista_Banco()
        {
            InitializeComponent();
            Initialize();
        }

        private void dgvLista_Banco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Banco banco = (Banco)(dgvLista_Banco.SelectedRows[0].DataBoundItem);
            if (dgvLista_Banco.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Banco.SelectedRows.Count > 0)
                {
                    fCad_Banco frm = new fCad_Banco();
                    frm.PreencherBanco(banco);
                    frm.ShowDialog();
                    bancoRepository.Editar(frm.BancoManutencao);
                    AtualizarGrid();
                }
            }
            else if (dgvLista_Banco.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bancoRepository.Apagar(banco.Id);
                    AtualizarGrid();
                    MessageBox.Show("Item Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }
                  
        }

        private void fLista_Banco_Load(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fCad_Banco frm = new fCad_Banco();
            frm.ShowDialog();
            bancoRepository.Inserir(frm.BancoManutencao);
            AtualizarGrid();
        }
    }
}
