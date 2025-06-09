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
    public partial class FormClientes : Form
    {
        public ClientesService clientesService = new ClientesService();
        int idselecionado = 0;

        public FormClientes()
        {
            InitializeComponent();
        }
        public void carregarDados()
        {
            List<ClientesGridDTO> clientes = clientesService.ClientesDTO();
            dgvConsultaCli.DataSource = null;
            dgvConsultaCli.DataSource = clientes;
            dgvConsultaCli.Refresh();
        }
        public void pesquisarDados()
        {
            string nome = "";
            if (txtRazaoPesq.Text.Trim() != "")
            {
                nome = txtRazaoPesq.Text.Trim();
                nome = "%" + nome + "%";
            }
            List<ClientesGridDTO> clientes = clientesService.GetByName(nome);
            dgvConsultaCli.DataSource = null;
            dgvConsultaCli.DataSource = clientes;
            dgvConsultaCli.Refresh();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtRazaoPesq.Text.Trim() == "" && txtFantasiaPesq.Text.Trim() == "")
            {
                carregarDados();
            }
            else
            {
                pesquisarDados();
            }
        }
        private void dgvConsultaCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idselecionado = Convert.ToInt32(dgvConsultaCli.Rows[e.RowIndex].Cells[0].Value);
        }
        private void dgvConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bloquearCampos();
            idselecionado = Convert.ToInt32(dgvConsultaCli.Rows[e.RowIndex].Cells[0].Value);

            ClientesEntities cliente = clientesService.GetById(idselecionado).FirstOrDefault();
            tabControl1.SelectedTab = tbpManutencao;

            txtCodigo.Text = cliente.Id.ToString();
            txtRazao.Text = cliente.Razao;
            txtFantasia.Text = cliente.Fantasia;
            txtCGC.Text = cliente.CGC;
            txtLogradouro.Text = cliente.Endereco;
            txtNumero.Text = cliente.Numero.ToString();
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtUF.Text = cliente.UF;
            txtTelefone.Text = cliente.Telefone;
            chkStatus.Checked = cliente.Status;
        }
        public void liberarCampos()
        {
            txtRazao.ReadOnly = false;
            txtFantasia.ReadOnly = false;
            txtCGC.ReadOnly = false;
            txtLogradouro.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtUF.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            chkStatus.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnInserir.Enabled = false;
        }
        public void bloquearCampos()
        {
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            txtRazao.ReadOnly = true;
            txtFantasia.ReadOnly = true;
            txtCGC.ReadOnly = true;
            txtLogradouro.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtUF.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            chkStatus.Enabled = false;
        }
        public void limparCampos()
        {
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
            chkStatus.Checked = true;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            idselecionado = 0;
            liberarCampos();
            limparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idselecionado != 0)
            {
                bloquearCampos();
                ClientesEntities cliente = clientesService.GetById(idselecionado).FirstOrDefault();

                txtCodigo.Text = cliente.Id.ToString();
                txtRazao.Text = cliente.Razao;
                txtFantasia.Text = cliente.Fantasia;
                txtCGC.Text = cliente.CGC;
                txtLogradouro.Text = cliente.Endereco;
                txtNumero.Text = cliente.Numero.ToString();
                txtBairro.Text = cliente.Bairro;
                txtCidade.Text = cliente.Cidade;
                txtUF.Text = cliente.UF;
                txtTelefone.Text = cliente.Telefone;
                chkStatus.Checked = cliente.Status;
            }
            else
            {
                idselecionado = 0;
                bloquearCampos();
                limparCampos();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtRazao.Text == "" || txtFantasia.Text == "" || txtCGC.Text == "" ||
                txtLogradouro.Text == "" || txtNumero.Text == "" || txtBairro.Text == "" ||
                txtCidade.Text == "" || txtUF.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ClientesEntities c = new ClientesEntities();
                if (idselecionado != 0)
                {
                    c.Id = idselecionado;
                    c.Razao = txtRazao.Text.Trim();
                    c.Fantasia = txtFantasia.Text.Trim();
                    c.CGC = txtCGC.Text.Trim();
                    c.Endereco = txtLogradouro.Text.Trim();
                    c.Numero = Convert.ToInt32(txtNumero.Text.Trim());
                    c.Bairro = txtBairro.Text.Trim();
                    c.Cidade = txtCidade.Text.Trim();
                    c.UF = txtUF.Text.Trim();
                    c.Telefone = txtTelefone.Text.Trim();
                    c.Status = chkStatus.Checked;
                    this.clientesService.Update(c);

                    bloquearCampos();
                    carregarDados();
                }
                else
                {
                    c.Razao = txtRazao.Text.Trim();
                    c.Fantasia = txtFantasia.Text.Trim();
                    c.CGC = txtCGC.Text.Trim();
                    c.Endereco = txtLogradouro.Text.Trim();
                    c.Numero = Convert.ToInt32(txtNumero.Text.Trim());
                    c.Bairro = txtBairro.Text.Trim();
                    c.Cidade = txtCidade.Text.Trim();
                    c.UF = txtUF.Text.Trim();
                    c.Telefone = txtTelefone.Text.Trim();
                    c.Status = chkStatus.Checked;
                    this.clientesService.Insert(c);

                    idselecionado = 0;
                    bloquearCampos();
                    limparCampos();
                    carregarDados();
                    tabControl1.SelectedTab = tbpConsulta;
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idselecionado == 0)
            {
                MessageBox.Show("Selecione um cliente para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                liberarCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Verifica = clientesService.CountCli(idselecionado);

            if (Verifica > 0)
            {
                MessageBox.Show("Não é possível excluir este cliente, pois ele possui registros vinculados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (idselecionado == 0)
                {
                    MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    clientesService.Delete(idselecionado);
                    limparCampos();
                    carregarDados();
                }
            }
        }
    }
}
