namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChocoMorango = new System.Windows.Forms.CheckBox();
            this.cbCalabresa = new System.Windows.Forms.CheckBox();
            this.cbQuatroQueijos = new System.Windows.Forms.CheckBox();
            this.cbPortuguesa = new System.Windows.Forms.CheckBox();
            this.cbMussarela = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDelevery = new System.Windows.Forms.RadioButton();
            this.rdbBalcao = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lbComanda = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaria Express";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChocoMorango);
            this.groupBox1.Controls.Add(this.cbCalabresa);
            this.groupBox1.Controls.Add(this.cbQuatroQueijos);
            this.groupBox1.Controls.Add(this.cbPortuguesa);
            this.groupBox1.Controls.Add(this.cbMussarela);
            this.groupBox1.Location = new System.Drawing.Point(43, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(375, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabores";
            // 
            // cbChocoMorango
            // 
            this.cbChocoMorango.AutoSize = true;
            this.cbChocoMorango.Location = new System.Drawing.Point(27, 218);
            this.cbChocoMorango.Margin = new System.Windows.Forms.Padding(4);
            this.cbChocoMorango.Name = "cbChocoMorango";
            this.cbChocoMorango.Size = new System.Drawing.Size(217, 20);
            this.cbChocoMorango.TabIndex = 4;
            this.cbChocoMorango.Text = "Chocolate com Morango - 55,00";
            this.cbChocoMorango.UseVisualStyleBackColor = true;
            // 
            // cbCalabresa
            // 
            this.cbCalabresa.AutoSize = true;
            this.cbCalabresa.Location = new System.Drawing.Point(27, 175);
            this.cbCalabresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbCalabresa.Name = "cbCalabresa";
            this.cbCalabresa.Size = new System.Drawing.Size(133, 20);
            this.cbCalabresa.TabIndex = 3;
            this.cbCalabresa.Text = "Calabresa - 52,00";
            this.cbCalabresa.UseVisualStyleBackColor = true;
            // 
            // cbQuatroQueijos
            // 
            this.cbQuatroQueijos.AutoSize = true;
            this.cbQuatroQueijos.Location = new System.Drawing.Point(27, 130);
            this.cbQuatroQueijos.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuatroQueijos.Name = "cbQuatroQueijos";
            this.cbQuatroQueijos.Size = new System.Drawing.Size(159, 20);
            this.cbQuatroQueijos.TabIndex = 2;
            this.cbQuatroQueijos.Text = "Quatro Queijos - 60,00";
            this.cbQuatroQueijos.UseVisualStyleBackColor = true;
            // 
            // cbPortuguesa
            // 
            this.cbPortuguesa.AutoSize = true;
            this.cbPortuguesa.Location = new System.Drawing.Point(27, 87);
            this.cbPortuguesa.Margin = new System.Windows.Forms.Padding(4);
            this.cbPortuguesa.Name = "cbPortuguesa";
            this.cbPortuguesa.Size = new System.Drawing.Size(139, 20);
            this.cbPortuguesa.TabIndex = 1;
            this.cbPortuguesa.Text = "Portuguesa - 55,00";
            this.cbPortuguesa.UseVisualStyleBackColor = true;
            // 
            // cbMussarela
            // 
            this.cbMussarela.AutoSize = true;
            this.cbMussarela.Location = new System.Drawing.Point(27, 47);
            this.cbMussarela.Margin = new System.Windows.Forms.Padding(4);
            this.cbMussarela.Name = "cbMussarela";
            this.cbMussarela.Size = new System.Drawing.Size(133, 20);
            this.cbMussarela.TabIndex = 0;
            this.cbMussarela.Text = "Mussarela - 49,00";
            this.cbMussarela.UseVisualStyleBackColor = true;
            this.cbMussarela.CheckedChanged += new System.EventHandler(this.cbMussarela_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbDelevery);
            this.groupBox2.Controls.Add(this.rdbBalcao);
            this.groupBox2.Location = new System.Drawing.Point(43, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(375, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retirada";
            // 
            // rdbDelevery
            // 
            this.rdbDelevery.AutoSize = true;
            this.rdbDelevery.Location = new System.Drawing.Point(31, 84);
            this.rdbDelevery.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDelevery.Name = "rdbDelevery";
            this.rdbDelevery.Size = new System.Drawing.Size(112, 20);
            this.rdbDelevery.TabIndex = 1;
            this.rdbDelevery.Text = "Delivery - 5,00";
            this.rdbDelevery.UseVisualStyleBackColor = true;
            // 
            // rdbBalcao
            // 
            this.rdbBalcao.AutoSize = true;
            this.rdbBalcao.Checked = true;
            this.rdbBalcao.Location = new System.Drawing.Point(31, 42);
            this.rdbBalcao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBalcao.Name = "rdbBalcao";
            this.rdbBalcao.Size = new System.Drawing.Size(71, 20);
            this.rdbBalcao.TabIndex = 0;
            this.rdbBalcao.TabStop = true;
            this.rdbBalcao.Text = "Balcão";
            this.rdbBalcao.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(241, 507);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(276, 49);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lbComanda
            // 
            this.lbComanda.BackColor = System.Drawing.SystemColors.Control;
            this.lbComanda.FormattingEnabled = true;
            this.lbComanda.ItemHeight = 16;
            this.lbComanda.Location = new System.Drawing.Point(468, 89);
            this.lbComanda.Name = "lbComanda";
            this.lbComanda.Size = new System.Drawing.Size(265, 372);
            this.lbComanda.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 569);
            this.Controls.Add(this.lbComanda);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbChocoMorango;
        private System.Windows.Forms.CheckBox cbCalabresa;
        private System.Windows.Forms.CheckBox cbQuatroQueijos;
        private System.Windows.Forms.CheckBox cbPortuguesa;
        private System.Windows.Forms.CheckBox cbMussarela;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbDelevery;
        private System.Windows.Forms.RadioButton rdbBalcao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox lbComanda;
    }
}

