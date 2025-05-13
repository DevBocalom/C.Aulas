using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Repository;
using Service;

namespace AtividadeMultiForm
{
    public partial class FormListarProdutos: Form
    {
        ProdutoService produtoService = new ProdutoService();
        public string idselecionado = "";

        public FormListarProdutos()
        {
            InitializeComponent();
            carregarDados();
        }
        public void carregarDados()
        {
            List<ProdutoEntities> produtos = produtoService.GetAll();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;
            dgvProdutos.Refresh();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCrudProdutos form = new FormCrudProdutos();
            form.ShowDialog();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idselecionado))
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show("Tem certeza que deseja excluir o produto?",
                                              "Confirmar exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                this.produtoService.Delete(idselecionado);
                MessageBox.Show("Produto excluído com sucesso!");
                carregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir: {ex.Message}");
            }
        }
        public void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idselecionado = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var produto = (ProdutoEntities)dgvProdutos.CurrentRow.DataBoundItem;

            FormCrudProdutos form = new FormCrudProdutos(produto);
            form.ShowDialog();
        }
    }
}
