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
        public NotasService notasService = new NotasService();
        public ItensService itensService = new ItensService();

        int idselecionado = 0;

        public FormNotas()
        {
            InitializeComponent();
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
        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
        private void dgvConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
            dtpDataDigitacao.Value = notas[0].DataEmissao;
            dtpDataDigitacao.Value = notas[0].DataDigitao;
            txtTotal.Text = notas[0].Valor.ToString("C2");
            txtInformacao.Text = notas[0].Observacao;
            CarregarItens();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
