namespace WindowsFormsApp1
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
            this.lbComanda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbComanda
            // 
            this.lbComanda.BackColor = System.Drawing.SystemColors.Control;
            this.lbComanda.FormattingEnabled = true;
            this.lbComanda.ItemHeight = 16;
            this.lbComanda.Location = new System.Drawing.Point(12, 12);
            this.lbComanda.Name = "lbComanda";
            this.lbComanda.Size = new System.Drawing.Size(289, 180);
            this.lbComanda.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 418);
            this.Controls.Add(this.lbComanda);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbComanda;
    }
}