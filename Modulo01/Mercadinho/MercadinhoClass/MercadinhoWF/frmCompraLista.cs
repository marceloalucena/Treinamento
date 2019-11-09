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
    public partial class frmCompraLista : Form
    {
        public CompraRepository compraRepository = new CompraRepository();
        public EstoqueRepository estoqueRepository = new EstoqueRepository();
        public List<Compra> Compras { get; set; }
        public void Initialize()
        {
            Compras = new List<Compra>();
            dgvLista_Compras.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            Compras = compraRepository.Obter().ToList();
            dgvLista_Compras.DataSource = null;
            dgvLista_Compras.DataSource = Compras.OrderBy(a => a.DataCompra).ToList();
        }

        public frmCompraLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCompraCadastro frm = new frmCompraCadastro();
            frm.ShowDialog();

            if (frm.CompraManutencao != null)
            {
                Estoque estoque;
                estoque = estoqueRepository.Obter(frm.CompraManutencao.ProdutoId);
                if (estoque == null)
                {
                    estoque = new Estoque();
                    estoque.Id = frm.CompraManutencao.ProdutoId;
                    estoque.QtdeEstoqueAtual  = 0;
                    estoque.QtdeEstoqueMinimo = 0;
                    estoqueRepository.Inserir(estoque);
                }

                String resultado;
                resultado = estoqueRepository.RealizarRecebimento(estoque, frm.CompraManutencao.QtdeCompra);
                if (resultado == "")
                {
                    compraRepository.Inserir(frm.CompraManutencao);
                    AtualizarGrid();
                    MessageBox.Show("Venda Executada Com Sucesso!");
                }
                else
                {
                    MessageBox.Show(resultado);
                }

            }

        }

        private void dgvLista_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Compra compra = (Compra)(dgvLista_Compras.SelectedRows[0].DataBoundItem);
            if (dgvLista_Compras.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgvLista_Compras.SelectedRows.Count > 0)
                {
                    frmCompraCadastro frm = new frmCompraCadastro();
                    frm.Preencher(compra);
                    frm.ShowDialog();
                    if (frm.CompraManutencao != null)
                    {
                        compraRepository.Editar(frm.CompraManutencao);
                        AtualizarGrid();
                    }
                }
            }
            else if (dgvLista_Compras.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Estoque estoque;
                    String resultado;
                    estoque = estoqueRepository.Obter(compra.ProdutoId);
                    resultado = estoqueRepository.RealizarBaixa(estoque, compra.QtdeCompra);
                    if (resultado == "")
                    {
                        compraRepository.Apagar(compra);
                        AtualizarGrid();
                        MessageBox.Show("Item Removido com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível remover o item. Detalhe: " + resultado);
                    }

                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }

        }
    }
}
