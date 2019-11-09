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
    public partial class frmCompraCadastro : Form
    {
        public FornecedorRepository fornecedorRepository = new FornecedorRepository();

        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public Compra CompraManutencao { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }
        public List<Produto> Produtos { get; set; }

        public void Initialize()
        {
            Fornecedores = new List<Fornecedor>();
            Fornecedores = fornecedorRepository.Obter().ToList();
            cbxFornecedor.DataSource = Fornecedores;
            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.ValueMember = "Id";

            Produtos = new List<Produto>();
            Produtos = produtoRepository.Obter().ToList();
            cbxProduto.DataSource = Produtos;
            cbxProduto.DisplayMember = "Descricao";
            cbxProduto.ValueMember = "Id";
        }

        public frmCompraCadastro()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            if (txtID.Text != "")
            {
                compra.Id = Convert.ToInt32(txtID.Text);
                compra.DataCompra = dtpDataCompra.Value;
            }
            else
            {
                compra.DataCompra = DateTime.Now;
            }
            compra.ProdutoId = Convert.ToInt32(cbxProduto.SelectedValue);
            compra.FornecedorId = Convert.ToInt32(cbxFornecedor.SelectedValue);
            compra.QtdeCompra = Convert.ToInt32(numQtde.Value);
            
            CompraManutencao = compra;

            Close();
        }
        public void Preencher(Compra compra)
        {
            txtID.Text = Convert.ToString(compra.Id);
            cbxProduto.SelectedValue = compra.ProdutoId;
            cbxFornecedor.SelectedValue = compra.FornecedorId;
            numQtde.Value = compra.QtdeCompra;
            dtpDataCompra.Value = compra.DataCompra;
        }


    }
}
