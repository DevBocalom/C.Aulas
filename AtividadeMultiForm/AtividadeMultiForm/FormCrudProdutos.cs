using Entities;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeMultiForm
{
    public partial class FormCrudProdutos : Form
    {
        ProdutoService produtoService = new ProdutoService();

        public FormCrudProdutos(ProdutoEntities p)
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtCodigo.Text = p.Id.ToString();
            txtDescricao.Text = p.Descricao.ToString();
            txtFornecedor.Text = p.Fornecedor.ToString();
            cbEstoque.Text = p.Estoque.ToString();
            txtValor.Text = p.Valor.ToString();
            if (p.Ativo)
            {
                rdbSim.Checked = true;
            }
            else
            {
                rdbNao.Checked = true;
            }
        }
        public FormCrudProdutos() // construtor padrão (para cadastro novo)
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoEntities p = new ProdutoEntities();
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
            FormListarProdutos form = new FormListarProdutos();
            form.carregarDados();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
