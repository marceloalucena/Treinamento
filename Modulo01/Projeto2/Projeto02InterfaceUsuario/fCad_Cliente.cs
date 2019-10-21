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
    public partial class fCad_Cliente : Form
    {
        public Cliente ClienteManutencao { get; set; }
        public fCad_Cliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.Nascimento = dtpNascimento.Value;
            cliente.Telefone = txtTelefone.Text;
            ClienteManutencao = cliente;

            Close();
        }
        public void PreencherCliente(Cliente cliente)
        {
            txtID.Text = Convert.ToString(cliente.Id);
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF;
            dtpNascimento.Value = cliente.Nascimento;
            txtTelefone.Text = cliente.Telefone;
        }

        private void fCad_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
