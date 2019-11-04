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
    public partial class frmFornecedorCadastro : Form
    {
        public Fornecedor FornecedorManutencao;

        public frmFornecedorCadastro()
        {
            InitializeComponent();
        }

        private void frmFornecedorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            if (txtID.Text != "")
            {
                fornecedor.Id = Convert.ToInt32(txtID.Text);
            }
            fornecedor.Nome = txtNome.Text;
            fornecedor.Ativo = cbxAtivo.Checked;
            FornecedorManutencao = fornecedor;

            Close();
        }
        public void Preencher(Fornecedor fornecedor)
        {
            txtID.Text = Convert.ToString(fornecedor.Id);
            txtNome.Text = fornecedor.Nome;
            cbxAtivo.Checked = fornecedor.Ativo;
        }
    }
}
