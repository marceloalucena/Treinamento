using Projeto2;
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
    public partial class FCaixa_Eletronico : Form
    {
        public ContaRepository contaRepository = new ContaRepository();

        public BancoRepository bancoRepository = new BancoRepository();
        public List<Banco> Bancos { get; set; }
        public List<Banco> BancosDest { get; set; }

        public void Initialize()
        {
            tabCaixa.ItemSize = new Size(0, 1);

            Bancos = new List<Banco>();
            Bancos = bancoRepository.Obter().ToList();
            cbxBancoSaque.DataSource = Bancos;
            cbxBancoSaque.DisplayMember = "Nome";
            cbxBancoSaque.ValueMember = "Id";

            cbxBancoDeposito.DataSource = Bancos;
            cbxBancoDeposito.DisplayMember = "Nome";
            cbxBancoDeposito.ValueMember = "Id";

            cbxBancoOrigem.DataSource = Bancos;
            cbxBancoOrigem.DisplayMember = "Nome";
            cbxBancoOrigem.ValueMember = "Id";

            BancosDest = bancoRepository.Obter().ToList();
            cbxBancoDestino.DataSource = BancosDest;
            cbxBancoDestino.DisplayMember = "Nome";
            cbxBancoDestino.ValueMember = "Id";
        }

        public FCaixa_Eletronico()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            tabCaixa.SelectedTab = tpSaque;
        }

        private void FCaixa_Eletronico_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            tabCaixa.SelectedTab = tpDeposito;
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            tabCaixa.SelectedTab = tpTransferencia;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessarSaque_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            string resultado;
            conta = contaRepository.Obter(Convert.ToInt32(cbxBancoSaque.SelectedValue), txtContaSaque.Text, txtAgenciaSaque.Text);
            resultado = contaRepository.RealizarSaque(conta, numValorSaque.Value);
            if (resultado == "")
            {
                MessageBox.Show("Saque Realizado com Sucesso!!!");
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void btnProcessarDeposito_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta = contaRepository.Obter(Convert.ToInt32(cbxBancoDeposito.SelectedValue), txtContaDeposito.Text, txtAgenciaDeposito.Text);
            if (conta != null) 
            { 
                contaRepository.RealizarDeposito(conta, numValorDeposito.Value);
                MessageBox.Show("Depósito Efetuado com Sucesso");
            }
            else
            {
                MessageBox.Show("Conta Não Encontrada");
            }
        }

        private void btnProcessarTransferencia_Click(object sender, EventArgs e)
        {
            string resultado;
            Conta contaOrigem = new Conta();
            Conta contaDestino = new Conta();
            contaOrigem = contaRepository.Obter(Convert.ToInt32(cbxBancoOrigem.SelectedValue),txtContaOrigem.Text, txtAgenciaOrigem.Text);
            contaDestino = contaRepository.Obter(Convert.ToInt32(cbxBancoDestino.SelectedValue),txtContaDestino.Text, txtAgenciaDestino.Text);
            if (contaOrigem == null) 
            {
                MessageBox.Show("Conta Origem Não Encontrada");
                return;
            }
            if (contaDestino == null)
            {
                MessageBox.Show("Conta Destino Não Encontrada");
                return;
            }
            resultado = contaRepository.RealizarTransferencia(contaOrigem, contaDestino, numValorTransferencia.Value);
            if (resultado == "")
            {
                MessageBox.Show("Transferencia Executada com Sucesso");
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }
    }
}
