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
        ProdutoService produtoService;

        public FormCrudProdutos(ProdutoEntities p, ProdutoService produtoService)
        {
            InitializeComponent();
            this.produtoService = produtoService;
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
        public FormCrudProdutos(ProdutoService produtoService) // construtor padrão (para cadastro novo)
        {
            InitializeComponent();
            this.produtoService = produtoService;
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

            // usa alunoService que foi injetado via dependencia
            this.produtoService.Insert(p);

            FormListarProdutos.getInstancia().carregarDados();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
