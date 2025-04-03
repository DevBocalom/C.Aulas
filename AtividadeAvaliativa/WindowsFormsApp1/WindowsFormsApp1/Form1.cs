using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void comandaPizzas()
        {
            List<string> pizzasSelec = new List<string>();

            if (cbMussarela.Checked == true)

                pizzasSelec.Add("Mussarela");
                foreach (string pizza in pizzasSelec)
                {   
                    lbComanda.Items.Add(pizza);
                }
            else { }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            calcularVenda();   
        }

        private void cbMussarela_CheckedChanged(object sender, EventArgs e)
        {
            comandaPizzas();
        }
    }
}
