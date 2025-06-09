namespace ExPraticoFinal
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
            this.txtFantasiaPesq = new System.Windows.Forms.TextBox();
            this.txtRazaoPesq = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            // txtFantasiaPesq
            // 
            this.txtFantasiaPesq.Location = new System.Drawing.Point(212, 57);
            this.txtFantasiaPesq.Name = "txtFantasiaPesq";
            this.txtFantasiaPesq.Size = new System.Drawing.Size(246, 22);
            this.txtFantasiaPesq.TabIndex = 19;
            // 
            // txtRazaoPesq
            // 
            this.txtRazaoPesq.Location = new System.Drawing.Point(212, 29);
            this.txtRazaoPesq.Name = "txtRazaoPesq";
            this.txtRazaoPesq.Size = new System.Drawing.Size(246, 22);
            this.txtRazaoPesq.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Razão Social";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nome Fantasia";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(605, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 38);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.txtFantasiaPesq);
            this.Controls.Add(this.txtRazaoPesq);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvConsultaCli);
            this.Name = "FormAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormItens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCli;
        private System.Windows.Forms.TextBox txtFantasiaPesq;
        private System.Windows.Forms.TextBox txtRazaoPesq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPesquisar;
    }
}