﻿using System;
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
        List<Aluno> database = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {

            Aluno a1 = new Aluno();
            a1.Ra = "11111";
            a1.Nome = "João";
            a1.Curso = "Nutrição";

            Aluno a2 = new Aluno();
            a2.Ra = "22222";
            a2.Nome = "Joaquim";
            a2.Curso = "Ciencia de Dados";

            Aluno a3 = new Aluno();
            a3.Ra = "33333";
            a3.Nome = "José";
            a3.Curso = "Ciencia da Computação";

            database.Add(a1);
            database.Add(a2);
            database.Add(a3);

            dgvAlunos.DataSource = database;
        }

        private void addAluno(Aluno a)
        {
            database.Add(a);
            dgvAlunos.DataSource = null;
            //dgvAlunos.Refresh();
            //ou
            dgvAlunos.DataSource = database;
        }

        private void atualizarAluno(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAlunos.Rows.Count)
            {
                string ra = dgvAlunos.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string nome = dgvAlunos.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string curso = dgvAlunos.Rows[e.RowIndex].Cells[2].Value?.ToString();

                txtRA.Text = ra;
                txtNome.Text = nome;
                txtCurso.Text = curso;

                string raDigitado = txtRA.Text;

                DialogResult resultado = MessageBox.Show(
                $"RA {raDigitado} já cadastrado. Deseja editar os dados desse aluno?",
                "RA já existente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Carrega os dados para edição nos TextBoxes
                    txtNome.Text = nome;
                    txtCurso.Text = curso;
                    // Você pode também desabilitar o campo RA se quiser evitar mudanças no RA
                    txtRA.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
                else
                {
                    txtRA.Clear();
                    txtNome.Clear();
                    txtCurso.Clear();
                    return;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRA.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Aluno a = new Aluno
            {
                Ra = txtRA.Text,
                Nome = txtNome.Text,
                Curso = txtCurso.Text
            };

            if (database.Any(aluno => aluno.Ra == a.Ra))
            {
                atualizarAluno(e);
            }

            addAluno(a);
            txtRA.Clear();
            txtNome.Clear();
            txtCurso.Clear();
        }

        private void dgvAlunos_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"Clicou na linha {e.ColumnIndex} e o RA: {ra}");
            atualizarAluno(e);
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
    public class Aluno
    {
        public string Ra { set; get; }
        public string Nome { set; get; }
        public string Curso { set; get; }
    }

}
