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
using Service;

namespace ProvaEspecifica1
{
    public partial class Form1 : Form
    {
        ProdutoService produtoService = new ProdutoService();
        string idselecionado = "";

        public Form1()
        {
            InitializeComponent();
            carregarDados();
        }
        public void carregarDados()
        {
            List<Produto> produtos = produtoService.GetAll();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;
            dgvProdutos.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Id = txtCodigo.Text;
            p.Descricao = txtDescricao.Text;
            p.Fornecedor = txtFornecedor.Text;
            p.Estoque = cbEstoque.Text;
            p.Valor = float.Parse(txtValor.Text);
            if (rdbSim.Checked)
            {
                p.Ativo = true;
            }
            else
            {
                p.Ativo = false;
            }
            produtoService.Insert(p);
            carregarDados();

            txtCodigo.Clear();
            txtDescricao.Clear();
            txtFornecedor.Clear();
            cbEstoque.Text = "";
            txtValor.Clear();
            rdbSim.Checked = true;
            txtCodigo.Enabled = true;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarProduto(e);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.produtoService.Delete(idselecionado);
            carregarDados();
        }
        private void atualizarProduto(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProdutos.Rows.Count)
            {
                idselecionado = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataGridViewRow row = this.dgvProdutos.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Id"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                txtFornecedor.Text = row.Cells["Fornecedor"].Value.ToString();
                cbEstoque.Text = row.Cells["Estoque"].Value.ToString();
                txtValor.Text = row.Cells["Valor"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["Ativo"].Value))
                {
                    rdbSim.Checked = true;
                }
                else
                {
                    rdbNao.Checked = true;
                }
                DialogResult resultado = MessageBox.Show(
                $"Produto *{row.Cells["Descricao"].Value.ToString()}* já cadastrado. Deseja editar os dados desse produto?",
                "Produto Selecionado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    txtCodigo.Clear();
                    txtDescricao.Clear();
                    txtFornecedor.Clear();
                    cbEstoque.Text = "";
                    txtValor.Clear();
                    rdbSim.Checked = true;
                    rdbNao.Checked = false;
                    return;
                }
                else
                {
                    txtCodigo.Enabled = false;
                }
            }
        }

    }
}
