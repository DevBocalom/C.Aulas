namespace MultiForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirForm1_Click(object sender, EventArgs e)
        {
            //Cria o Formulario na memoria
            Form1 f1 = new Form1();

            //Abrir o formulario
            f1.ShowDialog();
        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.TipoEntrega = "Entrega iFood";
            List<string> itens = new List<string>();
            itens.Add("Pizza Calabresa");
            itens.Add("Pizza Mussarela");
            itens.Add("Pizza Chocolate");
            itens.Add("Refrigerante");

            p.Sabores = itens;

            Form2 f2 = new Form2(p);
            f2.ShowDialog();
        }
    }
}
