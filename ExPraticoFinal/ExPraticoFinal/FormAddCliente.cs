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
    public partial class FormAddCliente : Form
    {
        public ClientesService clientesService = new ClientesService();
        int idselecionado = 0;
        public FormAddCliente()
        {
            InitializeComponent();
            carregarDados();
        }
        public void carregarDados()
        {
            List<ClientesGridDTO> clientes = clientesService.ClientesDTO();
            dgvConsultaCli.DataSource = null;
            dgvConsultaCli.DataSource = clientes;
            dgvConsultaCli.Refresh();
        }

        private void dgvConsultaCli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormNotas.getInstancia().txtCodigo.Text = dgvConsultaCli.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
        public void pesquisarDados()
        {
            string nome = "";
            string fantasia = "";
            if (txtRazaoPesq.Text.Trim() != "")
            {
                nome = txtRazaoPesq.Text.Trim();
                nome = "%" + nome + "%";
            }
            else if (txtFantasiaPesq.Text.Trim() != "")
            {
                fantasia = txtFantasiaPesq.Text.Trim();
                fantasia = "%" + fantasia + "%";
            }
            List<ClientesGridDTO> clientes = clientesService.GetByName(nome, fantasia);
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
    }
}
