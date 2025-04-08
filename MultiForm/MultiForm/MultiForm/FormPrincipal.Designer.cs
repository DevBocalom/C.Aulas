namespace MultiForm
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrirForm1 = new Button();
            btnAbrirForm2 = new Button();
            SuspendLayout();
            // 
            // btnAbrirForm1
            // 
            btnAbrirForm1.Location = new Point(52, 63);
            btnAbrirForm1.Name = "btnAbrirForm1";
            btnAbrirForm1.Size = new Size(153, 70);
            btnAbrirForm1.TabIndex = 0;
            btnAbrirForm1.Text = "Abrir Form1";
            btnAbrirForm1.UseVisualStyleBackColor = true;
            btnAbrirForm1.Click += btnAbrirForm1_Click;
            // 
            // btnAbrirForm2
            // 
            btnAbrirForm2.Location = new Point(52, 139);
            btnAbrirForm2.Name = "btnAbrirForm2";
            btnAbrirForm2.Size = new Size(153, 70);
            btnAbrirForm2.TabIndex = 1;
            btnAbrirForm2.Text = "Abrir Form2";
            btnAbrirForm2.UseVisualStyleBackColor = true;
            btnAbrirForm2.Click += btnAbrirForm2_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 275);
            Controls.Add(btnAbrirForm2);
            Controls.Add(btnAbrirForm1);
            Name = "FormPrincipal";
            Text = "Form Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirForm1;
        private Button btnAbrirForm2;
    }
}
