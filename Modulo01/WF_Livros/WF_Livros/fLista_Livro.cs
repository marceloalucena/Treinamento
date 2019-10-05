using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Livros
{
    public partial class fLista_Livro : Form
    {
        public List<Livro> Livros { get; set; }
        private void AtualizarGrid()
        {
           dgvLista_Livro.DataSource = null;
           dgvLista_Livro.DataSource = Livros.OrderBy(a=>a.Titulo).ToList();
        }
        public fLista_Livro()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Livros = new List<Livro>();
            int i = 1;

            Livros.Add(new Livro(
                "Teste de Titulo"+i,
                "Teste de Autor" + i,
                DateTime.Now.AddDays(-5d-i),
                50+i
                )
            );
            i += 1;
            Livros.Add(new Livro(
                "Teste de Titulo" + i,
                "Teste de Autor" + i,
                DateTime.Now.AddDays(-5d-i),
                50 + i
                )
            );
            i += 1;
            Livros.Add(new Livro(
                "Teste de Titulo" + i,
                "Teste de Autor" + i,
                DateTime.Now.AddDays(-5d-i),
                50 + i
                )
            );

            dgvLista_Livro.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fCad_Livro frm = new fCad_Livro();
            frm.ShowDialog();
            Livros.Add(frm.LivroManutencao);
            AtualizarGrid();
        }

        private void dgvLista_Livro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Livro livro = (Livro)(dgvLista_Livro.SelectedRows[0].DataBoundItem);
            //MessageBox.Show(dgvLista_Livro.Columns[e.ColumnIndex].Name);
            if (dgvLista_Livro.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Livro.SelectedRows.Count > 0)
                {

                    fCad_Livro frm = new fCad_Livro();
                    frm.PreencherLivro(livro);
                    frm.ShowDialog();
                    Livros.Remove(livro);
                    Livros.Add(frm.LivroManutencao);

                    AtualizarGrid();
                }
            }
            else if (dgvLista_Livro.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Livros.Remove(livro);
                    AtualizarGrid();
                    MessageBox.Show("Item Removido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }

            }
        }

        private void dgvLista_Livro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvLista_Livro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
