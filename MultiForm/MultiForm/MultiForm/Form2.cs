using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Pedido pedido)
        {
            InitializeComponent();
            lblEntrega.Text = pedido.TipoEntrega;
            lstSabores.Items.Clear();
            foreach (var item in pedido.Sabores)
            {
               lstSabores.Items.Add(item);
            }
        }
    }
}
