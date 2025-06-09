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
    public partial class FormNotas : Form
    {
        private static FormNotas instancia;
        public static FormNotas getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormNotas();
            }
            return instancia;
        }

        public NotasService notasService = new NotasService();
        public ItensService itensService = new ItensService();

        public int idselecionado = 0;
        public int novaNF = 0;

        public FormNotas()
        {
            InitializeComponent();

            instancia = this;
        }
        public void carregarDados()
        {
            List<NotasGridDTO> notas = notasService.NotasDTO();
            dgvConsultaNotas.DataSource = null;
            dgvConsultaNotas.DataSource = notas;
            dgvConsultaNotas.Refresh();
        }

        public void CarregarItens()
        {
            List<ItensEntities> itens = itensService.GetAll(idselecionado);
            dgvItens.DataSource = null;
            dgvItens.DataSource = itens;
            dgvItens.Refresh();
        }
        public void LiberarCampos()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            dtpDataDigitacao.Enabled = true;
            dtpDataEmissao.Enabled = true;
            btnAddCliente.Enabled = true;

            txtInformacao.ReadOnly = false;
        }
        public void BloquearCampos()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
            dtpDataDigitacao.Enabled = false;
            dtpDataEmissao.Enabled = false;
            btnAddCliente.Enabled = false;

            txtInformacao.ReadOnly = true;
        }
        public void limparCampos()
        {
            txtNF.Clear();
            txtCodigo.Clear();
            txtRazao.Clear();
            txtFantasia.Clear();
            txtCGC.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtTelefone.Clear();
            dtpDataEmissao.Value = DateTime.Now;
            dtpDataDigitacao.Value = DateTime.Now;
            txtTotal.Clear();
            txtInformacao.Clear();
            chkEmitida.Checked = false;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            limparCampos();
            idselecionado = 0;
            btnEmitir.Enabled = false;
            dgvItens.DataSource = null;
            dgvItens.Refresh();
            btnEmitir.Enabled = false;
        }
        private void dgvConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BloquearCampos();

            idselecionado = Convert.ToInt32(dgvConsultaNotas.Rows[e.RowIndex].Cells[0].Value);

            tabControl1.SelectedTab = tbpManutencao;

            List<NotasEntities> notas = notasService.GetAll(idselecionado);

            txtNF.Text = notas[0].Nota.ToString();
            txtCodigo.Text = notas[0].IdCliente.ToString();
            txtRazao.Text = notas[0].Razao;
            txtFantasia.Text = notas[0].Fantasia;
            txtCGC.Text = notas[0].CGC;
            txtLogradouro.Text = notas[0].Endereco;
            txtNumero.Text = notas[0].Numero.ToString();
            txtBairro.Text = notas[0].Bairro;
            txtCidade.Text = notas[0].Cidade;
            txtUF.Text = notas[0].UF;
            txtTelefone.Text = notas[0].Telefone;
            dtpDataEmissao.Value = notas[0].DataEmissao;
            dtpDataDigitacao.Value = notas[0].DataDigitao;
            txtTotal.Text = notas[0].Valor.ToString("C2");
            txtInformacao.Text = notas[0].Observacao;
            chkEmitida.Checked = notas[0].Valida;
            CarregarItens();

            if (notasService.Valida(idselecionado).Count > 0)
            {
                btnEmitir.Enabled = false;
            }
            else
            {
                btnEmitir.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idselecionado <= 0)
            {
                MessageBox.Show("Selecione uma nota para Alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (notasService.Valida(idselecionado).Count > 0)
                {
                    MessageBox.Show("Não é possível excluir esta nota, pois ela já foi emitida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    LiberarCampos();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            if (idselecionado <= 0)
            {
                limparCampos();
                dgvItens.DataSource = null;
                dgvItens.Refresh();
                btnEmitir.Enabled = false;
            }
            else
            {
                List<NotasEntities> notas = notasService.GetAll(idselecionado);

                txtNF.Text = notas[0].Nota.ToString();
                txtCodigo.Text = notas[0].IdCliente.ToString();
                txtRazao.Text = notas[0].Razao;
                txtFantasia.Text = notas[0].Fantasia;
                txtCGC.Text = notas[0].CGC;
                txtLogradouro.Text = notas[0].Endereco;
                txtNumero.Text = notas[0].Numero.ToString();
                txtBairro.Text = notas[0].Bairro;
                txtCidade.Text = notas[0].Cidade;
                txtUF.Text = notas[0].UF;
                txtTelefone.Text = notas[0].Telefone;
                dtpDataEmissao.Value = notas[0].DataEmissao;
                dtpDataDigitacao.Value = notas[0].DataDigitao;
                txtTotal.Text = notas[0].Valor.ToString("C2");
                txtInformacao.Text = notas[0].Observacao;
                chkEmitida.Checked = notas[0].Valida;
                CarregarItens();
            }
        }
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormAddCliente formAddCliente = new FormAddCliente();
            formAddCliente.ShowDialog();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idselecionado <= 0)
            {
                MessageBox.Show("Selecione uma nota para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (notasService.Valida(idselecionado).Count > 0)
                {
                    MessageBox.Show("Não é possível excluir esta nota, pois ela já foi emitida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir esta nota?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        notasService.Delete(idselecionado);
                        carregarDados();
                        BloquearCampos();
                        limparCampos();
                        idselecionado = 0;
                        dgvItens.DataSource = null;
                        dgvItens.Refresh();
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (idselecionado == 0)
            {
                novaNF = notasService.NovaNota();
                NotasEntities n = new NotasEntities();
                n.Nota = novaNF;
                n.IdCliente = Convert.ToInt32(txtCodigo.Text);
                n.DataEmissao = dtpDataEmissao.Value;
                n.DataDigitao = dtpDataDigitacao.Value;
                if (!string.IsNullOrWhiteSpace(txtTotal.Text) && decimal.TryParse(txtTotal.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), out decimal valor))
                {
                    n.Valor = valor;
                }
                else
                {
                    n.Valor = 0.00m;
                }
                n.Observacao = txtInformacao.Text;
                n.Valida = chkEmitida.Checked;
                notasService.Insert(n);
                txtNF.Text = Convert.ToString(n.Nota + 1);
                idselecionado = n.Nota + 1;
                carregarDados();
                BloquearCampos();
                btnEmitir.Enabled = true;
            }
            else
            {
                NotasEntities n = new NotasEntities();
                n.Nota = idselecionado;
                n.IdCliente = Convert.ToInt32(txtCodigo.Text);
                n.DataEmissao = dtpDataEmissao.Value;
                n.DataDigitao = dtpDataDigitacao.Value;
                if (!string.IsNullOrWhiteSpace(txtTotal.Text) && decimal.TryParse(txtTotal.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), out decimal valor))
                {
                    n.Valor = valor;
                }
                else
                {
                    n.Valor = 0.00m;
                }
                n.Observacao = txtInformacao.Text;
                n.Valida = chkEmitida.Checked;
                notasService.Update(n);
                carregarDados();
                BloquearCampos();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                limparCampos();
                return;
            }
            else
            {
                int cliID = Convert.ToInt32(txtCodigo.Text);

                ClientesService clientesService = new ClientesService();
                ClientesEntities c = clientesService.GetById(cliID).FirstOrDefault();

                txtRazao.Text = c.Razao;
                txtFantasia.Text = c.Fantasia;
                txtCGC.Text = c.CGC;
                txtLogradouro.Text = c.Endereco;
                txtNumero.Text = c.Numero.ToString();
                txtBairro.Text = c.Bairro;
                txtCidade.Text = c.Cidade;
                txtUF.Text = c.UF;
                txtTelefone.Text = c.Telefone;
            }
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            if (idselecionado <= 0)
            {
                MessageBox.Show("Selecione uma nota para adicionar produtos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (notasService.Valida(idselecionado).Count > 0)
            {
                MessageBox.Show("Não é possível adicionar produtos a esta nota, pois ela já foi emitida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FormAddProd formAddProd = new FormAddProd();
                formAddProd.ShowDialog();
            }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente emitir esta nota? Esse processo será irrevercivel.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                notasService.Emitir(idselecionado, true);
                chkEmitida.Checked = true;
            }
        }
    }
}
