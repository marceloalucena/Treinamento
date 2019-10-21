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
    public partial class fCad_Banco : Form
    {
        public Banco BancoManutencao { get; set; }
        public fCad_Banco()
        {
            InitializeComponent();
        }

        private void fCad_Banco_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (txtID.Text != "")
            {
                banco.Id = Convert.ToInt32(txtID.Text);
            }
            banco.Codigo = Convert.ToInt32(txtCodigo.Text);
            banco.Nome = txtNome.Text;
            BancoManutencao = banco;

            Close();
        }
        public void PreencherBanco(Banco banco)
        {
            txtID.Text = Convert.ToString(banco.Id);
            txtCodigo.Text = banco.Codigo.ToString();
            txtNome.Text = banco.Nome;
        }

    }
}
