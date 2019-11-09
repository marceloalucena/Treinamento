using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadinhoClass;

namespace MercadinhoWF
{
    public partial class frmProdutoCadastro : Form
    {
        public Produto ProdutoManutencao; 
        public frmProdutoCadastro()
        {
            InitializeComponent();
        }
 
        private void frmProdutoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (txtID.Text != "")
            {
                produto.Id = Convert.ToInt32(txtID.Text);
            }
            produto.Descricao = txtDescricao.Text;
            produto.ValorCusto = numValorCusto.Value;
            produto.FatorPreco = numFatorPreco.Value;
            produto.Ativo = cbxAtivo.Checked;
            ProdutoManutencao = produto;

            Close();
        }
        public void Preencher(Produto produto)
        {
            txtID.Text = Convert.ToString(produto.Id);
            txtDescricao.Text = produto.Descricao;
            numValorCusto.Value = produto.ValorCusto;
            numFatorPreco.Value = produto.FatorPreco;
            cbxAtivo.Checked = produto.Ativo;
            if (produto.Estoque != null)
            {
              numEstoqueMinimo.Value = produto.Estoque.QtdeEstoqueMinimo;
              numEstoqueAtual.Value  = produto.Estoque.QtdeEstoqueAtual;
            }
        }

    }
}
