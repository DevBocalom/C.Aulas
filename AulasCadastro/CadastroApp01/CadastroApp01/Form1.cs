using Entities; //em cima do erro pode dar ctrl+space para importar o a classe correto (entidadde aluno)
using Services;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroApp01
{
    public partial class Form1 : Form
    {
        AlunoService alunoService = new AlunoService();
        string raSelecionado = "";

        public Form1()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            List<Aluno> alunos = alunoService.GetAlunos();
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = alunos;
            dgvAlunos.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.Ra = txtRA.Text;
            a.Nome = txtNome.Text;
            a.Curso = txtCurso.Text;

            this.alunoService.Insert(a);
            carregarDados();

            txtRA.Clear();
            txtNome.Clear();
            txtCurso.Clear();
            txtRA.Enabled = true;
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarAluno(e);

            Aluno a = this.alunoService.GetByRa(raSelecionado);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.alunoService.delete(raSelecionado);
            carregarDados();
            raSelecionado = "";
            txtRA.Clear();
            txtNome.Clear();
            txtCurso.Clear();
        }

        private void atualizarAluno(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAlunos.Rows.Count)
            {
                raSelecionado = dgvAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nome = dgvAlunos.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string curso = dgvAlunos.Rows[e.RowIndex].Cells[2].Value?.ToString();

                txtRA.Text = raSelecionado;
                txtNome.Text = nome;
                txtCurso.Text = curso;

                DialogResult resultado = MessageBox.Show(
                $"RA {raSelecionado} já cadastrado. Deseja editar os dados desse aluno?",
                "RA já existente",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    txtRA.Clear();
                    txtNome.Clear();
                    txtCurso.Clear();
                    txtRA.Enabled = true;
                    return;

                }
                else
                {
                    // Carrega os dados para edição nos TextBoxes
                    txtNome.Text = nome;
                    txtCurso.Text = curso;
                    // Você pode também desabilitar o campo RA se quiser evitar mudanças no RA
                    txtRA.Enabled = false;
                }
            }
        }
    }
}