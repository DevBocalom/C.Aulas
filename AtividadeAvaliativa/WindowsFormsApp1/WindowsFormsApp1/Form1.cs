using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularVenda()
        {
            double valorVenda = 0.0;
            string saboresSelect = "";

            if (cbMussarela.Checked == true)
            {
                valorVenda = valorVenda + 49.00;
                saboresSelect += "Mussarela \n";
            }
            if (cbPortuguesa.Checked == true)
            {
                valorVenda = valorVenda + 55.00;
                saboresSelect += "Portugesa \n";
            }
            if (cbQuatroQueijos.Checked == true)
            {
                valorVenda = valorVenda + 60.00;
                saboresSelect += "Quatro Queijos \n";
            }
            if (cbCalabresa.Checked == true)
            {
                valorVenda = valorVenda + 52.00;
                saboresSelect += "Calabresa \n";
            }
            if (cbChocoMorango.Checked == true)
            {
                valorVenda = valorVenda + 55.00;
                saboresSelect += "Chocolate com Morango \n";
            }
            if (rdbDelevery.Checked == true)
            {
                valorVenda = valorVenda + 5.00;
            }
            if (valorVenda <= 5.0)
            {
                MessageBox.Show("Favor selecionar uma pizza");
            }
            else
            {
                if (rdbDelevery.Checked == true)
                {
                    MessageBox.Show("Sabores selecionados :\n" + saboresSelect + "\nTaxa adcional de entrega: R$ 5,00 \n \nO valor total do seu pedido é de R$ " + valorVenda);
                }
                else
                {
                    MessageBox.Show("Sabores selecionados :\n" + saboresSelect + "\n \nO valor total do seu pedido é de R$ " + valorVenda);
                }
            }
        }

        List<string> itensSelecionados = new List<string>();
        Dictionary<string, decimal> precos = new Dictionary<string, decimal>
        {
            { "Mussarela", 49.00m },
            { "Portuguesa", 55.00m },
            { "Quatro Queijos", 60.00m },
            { "Calabresa", 52.00m },
            { "Chocolate com Morango", 55.00m }
        };
        decimal taxaEntrega = 5.00m;
        bool isDelivery = false;
        private void AttItemComanda(CheckBox check, string item)
        {
            if (check.Checked)
            {
                if (!itensSelecionados.Contains(item))
                    itensSelecionados.Add(item);
            }
            else
            {
                itensSelecionados.Remove(item);
            }

            AtualizaComanda();
        }

        private void AtualizaComanda()
        {
            lbComanda.Items.Clear();
            decimal total = 0;

            lbComanda.Items.Add("======= PIZZARIA EXPRESS =======");
            lbComanda.Items.Add("Item                         Preço");
            lbComanda.Items.Add("--------------------------------------------------------------------");

            foreach (string item in itensSelecionados)
            {
                decimal preco = precos[item];
                string linha = $"{item.PadRight(28)} R$ {preco:0.00}";
                lbComanda.Items.Add(linha);
                total += preco;
            }
            if (isDelivery)
            {
                lbComanda.Items.Add("--------------------\n");
                lbComanda.Items.Add($"Entrega (Delivery)          R$ {taxaEntrega:0.00}\n");
                total += taxaEntrega;
            }
            else
            {
                lbComanda.Items.Add("--------------------\n");
                lbComanda.Items.Add("Retirada no Balcão\n");
            }

            lbComanda.Items.Add("--------------------------------------------------------------------");
            lbComanda.Items.Add($"Total:                      R$ {total:0.00}");
            lbComanda.Items.Add("==================================");
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            calcularVenda();   
        }

        private void cbMussarela_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbMussarela, "Mussarela");
        }

        private void cbPortuguesa_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbPortuguesa, "Portuguesa");
        }

        private void cbQuatroQueijos_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbQuatroQueijos, "Quatro Queijos");
        }

        private void cbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbCalabresa, "Calabresa");
        }

        private void cbChocoMorango_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbChocoMorango, "Chocolate com Morango");
        }

        private void rdbBalcao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBalcao.Checked)
            {
                isDelivery = false;
                AtualizaComanda();
            }
        }

        private void rdbDelevery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDelevery.Checked)
            {
                isDelivery = true;
                AtualizaComanda();
            }
        }
    }
}
