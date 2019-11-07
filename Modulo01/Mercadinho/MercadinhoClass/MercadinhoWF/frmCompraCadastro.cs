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
        public ClienteRepository clienteRepository = new ClienteRepository();

        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public Compra CompraManutencao { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Produto> Produtos { get; set; }

        public void Initialize()
        {
            Clientes = new List<Cliente>();
            Clientes = clienteRepository.Obter().ToList();
            cbxCliente.DataSource = Clientes;
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Id";

            Produtos = new List<Produto>();
            Produtos = produtoRepository.Obter().ToList();
            cbxProduto.DataSource = Produtos;
            cbxProduto.DisplayMember = "Descricao";
            cbxProduto.ValueMember = "Id";
        }

        public frmCompraCadastro()
        {
            InitializeComponent();
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
            compra.FornecedorId = Convert.ToInt32(cbxCliente.SelectedValue);
            compra.QtdeCompra = Convert.ToInt32(numQtde.Value);
            
            CompraManutencao = compra;

            Close();
        }
    }
}
