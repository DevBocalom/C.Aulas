using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioVenda
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularVenda()
        {
            float valorVenda = float.Parse(txtValorVenda.Text);
            float valorDesconto = 0.0f;
            try
            {
                valorDesconto = float.Parse(txtDesconto.Text);
            }
            catch { }

            if(rdbPercentual.Checked == true){
                valorDesconto = float.Parse(txtDesconto.Text)/100;
                float valorFinal = valorVenda - (valorVenda * valorDesconto);
                txtValorFinal.Text = "R$ " + valorFinal.ToString();
            }
            else if(rdbValorFixo.Checked == true){
                float valorFinal = valorVenda - valorDesconto;
                txtValorFinal.Text = "R$ " + valorFinal.ToString();
            }
        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            gpbDesconto.Enabled = true;
        }

        private void rdbCartao_CheckedChanged(object sender, EventArgs e)
        {
            gpbDesconto.Enabled = false;
            txtDesconto.Clear();
            calcularVenda();
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            gpbDesconto.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           calcularVenda();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            calcularVenda();
        }

        private void rdbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "")
            { }
            else
            {
                calcularVenda();
            }
        }
    }
}
