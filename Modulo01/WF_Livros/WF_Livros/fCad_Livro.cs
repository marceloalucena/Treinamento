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
    public partial class fCad_Livro : Form
    {
        public Livro LivroManutencao { get; private set; }
        public fCad_Livro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivroManutencao = new Livro(
                txtTitulo.Text,
                cbxAutor.Text,
                dtpDataLancamento.Value,
                Convert.ToInt32(numPaginas.Value)
            );

            Close();
        }

        public void PreencherLivro (Livro livro)
        {
            txtID.Text = Convert.ToString(livro.id);
            txtTitulo.Text = livro.Titulo;
            cbxAutor.Text = livro.Autor;
            dtpDataLancamento.Value = livro.DataLancamento;
            numPaginas.Value = Convert.ToDecimal(livro.NumeroPaginas);
        }
    }
}
