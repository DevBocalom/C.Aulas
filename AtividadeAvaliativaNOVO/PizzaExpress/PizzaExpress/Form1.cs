namespace PizzaExpress
{
    public partial class Form1 : Form
    {
        Pedido p = new Pedido();
        public Form1()
        {
            InitializeComponent();

        }
        

        private void AttItemComanda(CheckBox check, string item)
        {
            
            if (check.Checked)
            {

                if (!p.itensSelecionados.Contains(item))
                    p.itensSelecionados.Add(item);
            }
            else
            {
                p.itensSelecionados.Remove(item);
            }

            foreach (Control controle in gpbSabores.Controls)
            {
                if (controle is CheckBox checkBox && checkBox.Checked)
                {

                }
            }
        }

        private void cbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            AttItemComanda(cbCalabresa, "Calabresa");
        }
    }
}
