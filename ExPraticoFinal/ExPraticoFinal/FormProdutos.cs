using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitties;
using Service;

namespace ExPraticoFinal
{
    public partial class FormProdutos : Form
    {
        public ProdutosService produtosService = new ProdutosService();
        int idselecionado = 0;

        public FormProdutos()
        {
            InitializeComponent();
        }

        public void CarregarDados()
        {
            List<ProdutosGridDTO> produtos = produtosService.GetAll();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;
            dgvProdutos.Refresh();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idselecionado = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);

            tabControl1.SelectedTab = tbpManutencao;
            List<ProdutosEntities> produto = produtosService.GetById(idselecionado);

            txtCodigo.Text = produto[0].Id.ToString();
            txtDescricao.Text = produto[0].Descricao;
            txtMarca.Text = produto[0].Marca;
            txtValor.Text = produto[0].Valor.ToString("F2");
            txtFornecedor.Text = produto[0].Fornecedor;
            chkStatus.Checked = produto[0].Status;
        }
    }
}
