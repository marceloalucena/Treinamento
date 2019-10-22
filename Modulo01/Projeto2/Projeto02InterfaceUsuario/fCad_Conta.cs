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
    public partial class fCad_Conta : Form
    {
        public Conta ContaManutencao { get; set; }

        public BancoRepository bancoRepository = new BancoRepository();
        public List<Banco> Bancos { get; set; }

        public ClienteRepository clienteRepository = new ClienteRepository();
        public List<Cliente> Clientes { get; set; }
        public void Initialize()
        {
            Bancos = new List<Banco>();
            Bancos = bancoRepository.Obter().ToList();
            cbxBanco.DataSource = Bancos;
            cbxBanco.DisplayMember = "Nome";
            cbxBanco.ValueMember = "Id";

            Clientes = new List<Cliente>();
            Clientes = clienteRepository.Obter().ToList();
            cbxCliente.DataSource = Clientes;
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Id";
        }
        public fCad_Conta()
        {
            InitializeComponent();
            Initialize();
        }

        public void PreencherConta(Conta conta)
        {
            Banco banco;
            Cliente cliente;
            int iBanco;
            int iCliente;

            txtID.Text = Convert.ToString(conta.Id);
            //txtClienteID.Text = conta.ClienteID.ToString();
            //txtBancoID.Text = conta.BancoID.ToString();
            txtAgencia.Text = conta.Agencia;
            txtContaCorrente.Text = conta.ContaCorrente;
            numSaldo.Value = conta.Saldo;
            numLimite.Value = conta.Limite;

            banco = new Banco();
            banco = bancoRepository.Obter(conta.BancoID);
            iBanco = cbxBanco.FindStringExact(banco.Nome);
            cbxBanco.SelectedIndex = iBanco;

            cliente = new Cliente();
            cliente = clienteRepository.Obter(conta.ClienteID);
            iCliente = cbxCliente.FindStringExact(cliente.Nome);
            cbxCliente.SelectedIndex = iCliente;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

        }

        private void fCad_Conta_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            if (txtID.Text != "")
            {
               conta.Id = Convert.ToInt32(txtID.Text);
            }
            conta.ClienteID = Convert.ToInt32(cbxCliente.SelectedValue);
           // conta.BancoID = Convert.ToInt32(cbxBanco.SelectedValue);
            conta.Banco = (Banco)cbxBanco.SelectedItem;
            conta.Agencia = txtAgencia.Text;
            conta.ContaCorrente = txtContaCorrente.Text;
            conta.Saldo = numSaldo.Value;
            conta.Limite = numLimite.Value;
            ContaManutencao = conta;

            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Banco: {cbxBanco.SelectedValue} - {cbxBanco.SelectedIndex} - {cbxBanco.SelectedItem}");
            //MessageBox.Show($"Banco: {cbxBanco.SelectedValue} - {cbxBanco.Text}");
        }
    }
}
