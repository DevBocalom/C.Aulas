namespace MultiForm
{
    partial class Form2
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
            lstSabores = new ListBox();
            lblEntrega = new Label();
            lblValor = new Label();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lstSabores
            // 
            lstSabores.FormattingEnabled = true;
            lstSabores.Items.AddRange(new object[] { "Pizza Calabresa", "Pizza Mussarela", "Pizza Portuguesa" });
            lstSabores.Location = new Point(12, 12);
            lstSabores.Name = "lstSabores";
            lstSabores.Size = new Size(227, 164);
            lstSabores.TabIndex = 0;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(79, 231);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(54, 20);
            lblEntrega.TabIndex = 1;
            lblEntrega.Text = "Balcão";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(79, 263);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(73, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "R$ 139,00";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(76, 354);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 450);
            Controls.Add(btnFechar);
            Controls.Add(lblValor);
            Controls.Add(lblEntrega);
            Controls.Add(lstSabores);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSabores;
        private Label lblEntrega;
        private Label lblValor;
        private Button btnFechar;
    }
}