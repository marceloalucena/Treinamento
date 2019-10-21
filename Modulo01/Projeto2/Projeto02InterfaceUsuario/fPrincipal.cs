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
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            fLista_Banco frm = new fLista_Banco();
            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            fLista_Cliente frm = new fLista_Cliente();
            frm.ShowDialog();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            fLista_Conta frm = new fLista_Conta();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCaixaEletronico_Click(object sender, EventArgs e)
        {
            FCaixa_Eletronico frm = new FCaixa_Eletronico();
            frm.ShowDialog();
        }
    }
}
