﻿namespace ExPraticoFinal
{
    partial class FormAddCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultaCli = new System.Windows.Forms.DataGridView();
            this.txtRazaoPesq = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCli
            // 
            this.dgvConsultaCli.AllowUserToOrderColumns = true;
            this.dgvConsultaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaCli.ColumnHeadersHeight = 29;
            this.dgvConsultaCli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsultaCli.Location = new System.Drawing.Point(12, 106);
            this.dgvConsultaCli.Name = "dgvConsultaCli";
            this.dgvConsultaCli.RowHeadersWidth = 51;
            this.dgvConsultaCli.RowTemplate.Height = 24;
            this.dgvConsultaCli.Size = new System.Drawing.Size(758, 332);
            this.dgvConsultaCli.TabIndex = 1;
            this.dgvConsultaCli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCli_CellDoubleClick);
            // 
            // txtRazaoPesq
            // 
            this.txtRazaoPesq.Location = new System.Drawing.Point(267, 40);
            this.txtRazaoPesq.Name = "txtRazaoPesq";
            this.txtRazaoPesq.Size = new System.Drawing.Size(246, 22);
            this.txtRazaoPesq.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Razão Social";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(605, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 38);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // FormAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.txtRazaoPesq);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvConsultaCli);
            this.Name = "FormAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCli;
        private System.Windows.Forms.TextBox txtRazaoPesq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPesquisar;
    }
}