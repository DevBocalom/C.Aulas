using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
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
        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtValor.Clear();
            txtFornecedor.Clear();
            chkStatus.Checked = true;
        }
        public void LiberarCampos()
        {
            txtDescricao.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtValor.ReadOnly = false;
            txtFornecedor.ReadOnly = false;
            chkStatus.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
        }
        public void BloquearCampos()
        {
            txtDescricao.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtValor.ReadOnly = true;
            txtFornecedor.ReadOnly = true;
            chkStatus.Enabled = false;

            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
        }
        public void PesquisaGrid()
        {
            string nome = txtDescricaoPesq.Text.Trim();
            List<ProdutosGridDTO> pesqGrid = produtosService.GetByName(nome);
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = pesqGrid;
            dgvProdutos.Refresh();
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
            if (txtDescricaoPesq.Text.Trim() == "")
            {
                CarregarDados();
            }
            else
            {
                PesquisaGrid();
            }
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idselecionado == 0)
            {
                MessageBox.Show("Selecione um produto para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LiberarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idselecionado != 0)
            {
                BloquearCampos();
            }
            else
            {
                idselecionado = 0;
                BloquearCampos();
                LimparCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idselecionado == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                produtosService.Delete(idselecionado);
                CarregarDados();
                LimparCampos();
                idselecionado = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Trim() == "" || txtMarca.Text.Trim() == "" || txtValor.Text.Trim() == "" || txtFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (idselecionado == 0)
                {
                    ProdutosEntities p = new ProdutosEntities();
                    p.Descricao = txtDescricao.Text.Trim();
                    p.Marca = txtMarca.Text.Trim();
                    p.Valor = Convert.ToDecimal(txtValor.Text.Trim());
                    p.Fornecedor = txtFornecedor.Text.Trim();
                    p.Status = chkStatus.Checked;
                    produtosService.Insert(p);
                    LimparCampos();
                    BloquearCampos();
                    CarregarDados();
                    tabControl1.SelectedTab = tbpConsulta;
                }
                else
                {
                    ProdutosEntities p = new ProdutosEntities();
                    p.Id = idselecionado;
                    p.Descricao = txtDescricao.Text.Trim();
                    p.Marca = txtMarca.Text.Trim();
                    p.Valor = Convert.ToDecimal(txtValor.Text.Trim());
                    p.Fornecedor = txtFornecedor.Text.Trim();
                    p.Status = chkStatus.Checked;
                    produtosService.Update(p);
                    BloquearCampos();
                    CarregarDados();
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            idselecionado = 0;
            LiberarCampos();
            LimparCampos();
        }
    }
}
