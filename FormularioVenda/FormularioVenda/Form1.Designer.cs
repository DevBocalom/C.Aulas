namespace FormularioVenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCartao = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.gpbDesconto = new System.Windows.Forms.GroupBox();
            this.rdbValorFixo = new System.Windows.Forms.RadioButton();
            this.rdbPercentual = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gpbDesconto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Compra";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(101, 50);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenda.TabIndex = 1;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDinheiro);
            this.groupBox1.Controls.Add(this.rdbCartao);
            this.groupBox1.Controls.Add(this.rdbPix);
            this.groupBox1.Location = new System.Drawing.Point(63, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(18, 79);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(78, 20);
            this.rdbDinheiro.TabIndex = 2;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbCartao
            // 
            this.rdbCartao.AutoSize = true;
            this.rdbCartao.Location = new System.Drawing.Point(18, 53);
            this.rdbCartao.Name = "rdbCartao";
            this.rdbCartao.Size = new System.Drawing.Size(68, 20);
            this.rdbCartao.TabIndex = 1;
            this.rdbCartao.Text = "Cartão";
            this.rdbCartao.UseVisualStyleBackColor = true;
            this.rdbCartao.CheckedChanged += new System.EventHandler(this.rdbCartao_CheckedChanged);
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Checked = true;
            this.rdbPix.Location = new System.Drawing.Point(18, 27);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(46, 20);
            this.rdbPix.TabIndex = 0;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.CheckedChanged += new System.EventHandler(this.rdbPix_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Final";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(63, 353);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(192, 36);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Calcular / Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(43, 64);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 7;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorFinal.Enabled = false;
            this.txtValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtValorFinal.Location = new System.Drawing.Point(81, 309);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(144, 38);
            this.txtValorFinal.TabIndex = 8;
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbDesconto
            // 
            this.gpbDesconto.Controls.Add(this.rdbValorFixo);
            this.gpbDesconto.Controls.Add(this.rdbPercentual);
            this.gpbDesconto.Controls.Add(this.txtDesconto);
            this.gpbDesconto.Location = new System.Drawing.Point(63, 195);
            this.gpbDesconto.Name = "gpbDesconto";
            this.gpbDesconto.Size = new System.Drawing.Size(192, 92);
            this.gpbDesconto.TabIndex = 4;
            this.gpbDesconto.TabStop = false;
            this.gpbDesconto.Text = "Desconto";
            // 
            // rdbValorFixo
            // 
            this.rdbValorFixo.AutoSize = true;
            this.rdbValorFixo.Location = new System.Drawing.Point(18, 43);
            this.rdbValorFixo.Name = "rdbValorFixo";
            this.rdbValorFixo.Size = new System.Drawing.Size(88, 20);
            this.rdbValorFixo.TabIndex = 9;
            this.rdbValorFixo.TabStop = true;
            this.rdbValorFixo.Text = "Valor Fixo";
            this.rdbValorFixo.UseVisualStyleBackColor = true;
            // 
            // rdbPercentual
            // 
            this.rdbPercentual.AutoSize = true;
            this.rdbPercentual.Location = new System.Drawing.Point(18, 21);
            this.rdbPercentual.Name = "rdbPercentual";
            this.rdbPercentual.Size = new System.Drawing.Size(92, 20);
            this.rdbPercentual.TabIndex = 8;
            this.rdbPercentual.TabStop = true;
            this.rdbPercentual.Text = "Percentual";
            this.rdbPercentual.UseVisualStyleBackColor = true;
            this.rdbPercentual.CheckedChanged += new System.EventHandler(this.rdbPercentual_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 423);
            this.Controls.Add(this.gpbDesconto);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbDesconto.ResumeLayout(false);
            this.gpbDesconto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCartao;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.GroupBox gpbDesconto;
        private System.Windows.Forms.RadioButton rdbValorFixo;
        private System.Windows.Forms.RadioButton rdbPercentual;
    }
}

