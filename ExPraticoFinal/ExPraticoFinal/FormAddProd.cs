using Entitties;
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

namespace ExPraticoFinal
{
    public partial class FormAddProd : Form
    {

        public ProdutosService produtosService = new ProdutosService();
        public ItensService itensService = new ItensService();
        public NotasService notasService = new NotasService();
        int idselecionado = 0;
        int idselecionadoAdd = 0;
        int nf = FormNotas.getInstancia().idselecionado;
        public FormAddProd()
        {
            InitializeComponent();
            CarregarDados();
            CarregarItens();
        }
        public void LiberarCampos()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
        }
        public void BloquearCampos()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
        }
        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtValor.Clear();
            txtFornecedor.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            idselecionado = 0;
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
            List<ProdutosGridDTO> produtos = itensService.AddDGV(FormNotas.getInstancia().idselecionado);
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
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
        }
        public void attValor()
        {
            FormNotas.getInstancia().txtTotal.Text = notasService.attValor(FormNotas.getInstancia().idselecionado).ToString("C2");
        }
        public void CarregarItens()
        {
            List<ItensEntities> itens = itensService.GetAll(FormNotas.getInstancia().idselecionado);
            dgvItensAdd.DataSource = null;
            dgvItensAdd.DataSource = itens;
            dgvItensAdd.Refresh();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (idselecionado == 0)
            {
                MessageBox.Show("Selecione um produto para adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtQuantidade.Text.Trim() == "" || txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ItensEtitiesAdd i = new ItensEtitiesAdd();

                i.IdProduto = idselecionado;
                i.Descricao = txtDescricao.Text;
                i.IdNota = FormNotas.getInstancia().idselecionado;
                i.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                i.ValorUnitario = Convert.ToDecimal(txtValor.Text);

                itensService.Insert(i);
                FormNotas.getInstancia().CarregarItens();
                notasService.AdicionarvValor(FormNotas.getInstancia().idselecionado);
                attValor();
                CarregarItens();


                DialogResult result = MessageBox.Show("Item adicionado com sucesso! Deseja adicionar outro item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    LimparCampos();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idselecionadoAdd <= 0)
            {
                MessageBox.Show("Selecione uma item para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LiberarCampos();
            }
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int qtd = 0;
            float vr = 0;
            float total = 0;

            if (int.TryParse(txtQuantidade.Text, out qtd))
            {
                if (!string.IsNullOrWhiteSpace(txtValor.Text) && float.TryParse(txtValor.Text, out vr))
                {
                    total = qtd * vr;
                }
                txtTotal.Text = total.ToString("F2");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void dgvItensAdd_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idselecionadoAdd = Convert.ToInt32(dgvItensAdd.Rows[e.RowIndex].Cells[0].Value);

            List<ItensEtitiesAdd> item = itensService.GetById(nf, idselecionadoAdd);
            txtCodigo.Text = item[0].IdProduto.ToString();
            txtDescricao.Text = item[0].Descricao;
            txtQuantidade.Text = item[0].Quantidade.ToString();
            txtValor.Text = item[0].ValorUnitario.ToString("F2");
            txtMarca.Text = item[0].Marca;
            txtFornecedor.Text = item[0].Fornecedor;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            if (idselecionadoAdd <= 0)
            {
                LimparCampos();
            }
            else
            {
                List<ItensEtitiesAdd> item = itensService.GetById(nf,idselecionadoAdd);

                txtCodigo.Text = item[0].IdProduto.ToString();
                txtDescricao.Text = item[0].Descricao;
                txtMarca.Text = item[0].Marca;
                txtValor.Text = item[0].ValorUnitario.ToString("F2");
                txtFornecedor.Text = item[0].Fornecedor;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idselecionadoAdd <= 0)
            {
                MessageBox.Show("Selecione uma nota para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    itensService.Delete(nf, idselecionadoAdd);
                    LimparCampos();
                    FormNotas.getInstancia().CarregarItens();
                    notasService.AdicionarvValor(FormNotas.getInstancia().idselecionado);
                    attValor();
                    CarregarItens();
                    LimparCampos();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Trim() == "" || txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ItensEtitiesAdd i = new ItensEtitiesAdd();

                i.IdProduto = idselecionadoAdd;
                i.IdNota = nf;
                i.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                i.ValorUnitario = Convert.ToDecimal(txtValor.Text);
                itensService.Update(i);

                FormNotas.getInstancia().CarregarItens();
                notasService.AdicionarvValor(FormNotas.getInstancia().idselecionado);
                attValor();
                CarregarItens();
                LimparCampos();
                BloquearCampos();
            }
        }
    }
}
