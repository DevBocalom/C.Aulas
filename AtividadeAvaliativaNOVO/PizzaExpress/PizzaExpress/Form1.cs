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
            nudCalabresa.Enabled = true;
        }

        private void cbMussarela_CheckedChanged(object sender, EventArgs e)
        {
            nudmMussarela.Enabled = true;
        }

        private void cbPortuguesa_CheckedChanged(object sender, EventArgs e)
        {
            nudPortuguesa.Enabled = true;
        }

        private void cbMarguerita_CheckedChanged(object sender, EventArgs e)
        {
            nudMarguerita.Enabled = true;
        }

        private void cbChocolate_CheckedChanged(object sender, EventArgs e)
        {
            nudChocolate.Enabled = true;
        }

        private void cbCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            nudCocaCola.Enabled = true;
        }

        private void cbGuarana_CheckedChanged(object sender, EventArgs e)
        {
            nudGuarana.Enabled = true;
        }
    }
}
