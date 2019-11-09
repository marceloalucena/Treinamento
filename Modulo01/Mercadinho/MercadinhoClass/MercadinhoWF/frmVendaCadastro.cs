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
    public partial class frmVendaCadastro : Form
    {
        public ClienteRepository clienteRepository = new ClienteRepository();

        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public Venda VendaManutencao { get; set; }
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
        public frmVendaCadastro()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            if (txtID.Text != "")
            {
                venda.Id = Convert.ToInt32(txtID.Text);
                venda.DataVenda = dtpDataVenda.Value;
            }
            else
            {
                venda.DataVenda = DateTime.Now;
            }
            venda.ProdutoId = Convert.ToInt32(cbxProduto.SelectedValue);
            venda.ClienteId = Convert.ToInt32(cbxCliente.SelectedValue);
            venda.QtdeVenda = Convert.ToInt32(numQtde.Value);
            
            VendaManutencao = venda;

            Close();
        }
        public void Preencher(Venda venda)
        {
            txtID.Text = Convert.ToString(venda.Id);
            cbxProduto.SelectedValue = venda.ProdutoId;
            cbxCliente.SelectedValue = venda.ClienteId;
            numQtde.Value = venda.QtdeVenda;
            dtpDataVenda.Value = venda.DataVenda;
        }
    }
}
