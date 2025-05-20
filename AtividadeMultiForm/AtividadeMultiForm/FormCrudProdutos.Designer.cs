namespace AtividadeMultiForm
{
    partial class FormCrudProdutos
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
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.cbEstoque = new System.Windows.Forms.ComboBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.gbAtivo = new System.Windows.Forms.GroupBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(17, 152);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(335, 22);
            this.txtFornecedor.TabIndex = 15;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(13, 132);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.lblFornecedor.TabIndex = 14;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(17, 88);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(335, 22);
            this.txtDescricao.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 68);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(138, 16);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição do Produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(13, 9);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(51, 16);
            this.lblCódigo.TabIndex = 10;
            this.lblCódigo.Text = "Código";
            // 
            // cbEstoque
            // 
            this.cbEstoque.FormattingEnabled = true;
            this.cbEstoque.Items.AddRange(new object[] {
            "Central",
            "Filial 1",
            "Filial 2",
            "Filial 3"});
            this.cbEstoque.Location = new System.Drawing.Point(174, 27);
            this.cbEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstoque.Name = "cbEstoque";
            this.cbEstoque.Size = new System.Drawing.Size(187, 24);
            this.cbEstoque.TabIndex = 20;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(171, 9);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(57, 16);
            this.lblEstoque.TabIndex = 19;
            this.lblEstoque.Text = "Estoque";
            // 
            // gbAtivo
            // 
            this.gbAtivo.Controls.Add(this.rdbNao);
            this.gbAtivo.Controls.Add(this.rdbSim);
            this.gbAtivo.Location = new System.Drawing.Point(201, 186);
            this.gbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.gbAtivo.Name = "gbAtivo";
            this.gbAtivo.Padding = new System.Windows.Forms.Padding(4);
            this.gbAtivo.Size = new System.Drawing.Size(151, 55);
            this.gbAtivo.TabIndex = 18;
            this.gbAtivo.TabStop = false;
            this.gbAtivo.Text = "Ativo (S/N)";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(83, 20);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(54, 20);
            this.rdbNao.TabIndex = 1;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Checked = true;
            this.rdbSim.Location = new System.Drawing.Point(8, 20);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(51, 20);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 219);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(171, 22);
            this.txtValor.TabIndex = 17;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(13, 196);
            this.lblvalor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(59, 16);
            this.lblvalor.TabIndex = 16;
            this.lblvalor.Text = "Valor R$";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(51, 271);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 271);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCrudProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.gbAtivo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCódigo);
            this.Name = "FormCrudProdutos";
            this.Text = "Cadastro de Produtos";
            this.gbAtivo.ResumeLayout(false);
            this.gbAtivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.ComboBox cbEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.GroupBox gbAtivo;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}