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
    public partial class FormInicial : Form
    {
        public ResumoService resumoService = new ResumoService();
        public FormInicial()
        {
            InitializeComponent();
            ResumoSistema();
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Name)
            {
                case "Produtos":
                    FormProdutos formProdutos = new FormProdutos();
                    formProdutos.ShowDialog();
                    break;
                case "Clientes":
                    FormClientes formClientes = new FormClientes();
                    formClientes.ShowDialog();
                    break;
                case "Notas":
                    FormNotas formNotas = new FormNotas();
                    formNotas.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Selecione um item válido.");
                    break;
            }
        }
        private void ResumoSistema()
        {
            ResumoEntities TotalN = resumoService.TotalNotas();
            ResumoEntities TotalP = resumoService.TotalProdutos();
            ResumoEntities TotalC = resumoService.TotalClientes();
            ResumoEntities NotasE = resumoService.NotasEmitidas();
            ResumoEntities NotasNE = resumoService.NotasNaoEmitidas();
            ResumoEntities TotalV = resumoService.TotalVendido();
            treeView1.ExpandAll();

            lstResumoSistema.Items.Clear();
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Total de Produtos", TotalP.TotalProdutos.ToString() }));
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Total de Clientes", TotalC.TotalClientes.ToString() }));
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Total de Notas", TotalN.TotalNotas.ToString()}));
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Notas Emitidas", NotasE.NotasEmitidas.ToString() }));
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Notas Não Emitidas", NotasNE.NotasNaoEmitidas.ToString() }));
            lstResumoSistema.Items.Add(new ListViewItem(new string[] { "Total Vendido", TotalV.TotaVendido.ToString("C2")}));
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
