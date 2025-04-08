namespace PizzaExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            float preco = float.Parse(lblCalabresa.Text);

            lblGuarana.Text = preco.ToString("F2");
        }
    }
}
