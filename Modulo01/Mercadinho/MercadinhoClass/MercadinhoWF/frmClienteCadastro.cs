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
    public partial class frmClienteCadastro : Form
    {
        public Cliente ClienteManutencao;
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (txtID.Text != "")
            {
                cliente.Id = Convert.ToInt32(txtID.Text);
            }
            cliente.Nome = txtNome.Text;
            cliente.DataNascimento = dtDataNascimento.Value;
            cliente.Ativo = cbxAtivo.Checked;
            ClienteManutencao = cliente;

            Close();
        }
        public void Preencher(Cliente cliente)
        {
            txtID.Text = Convert.ToString(cliente.Id);
            txtNome.Text = cliente.Nome;
            dtDataNascimento.Value = cliente.DataNascimento;
            cbxAtivo.Checked = cliente.Ativo;
        }
    }
}
