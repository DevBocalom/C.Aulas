using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitties;
using Service;


namespace ExPraticoFinal
{
    public partial class FormLogin : Form
    {
        public LoginService loginService = new LoginService();

        public FormLogin()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            Senha.Parent = pictureBox1;
            linkLabel1.Parent = pictureBox1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (login == "" || senha == "")
            {
                MessageBox.Show("Preencha os campos de login e senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(loginService.ValidarLogin(login, senha).Count > 0)
            {
                this.Hide();
                FormInicial formInicial = new FormInicial();
                formInicial.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}
