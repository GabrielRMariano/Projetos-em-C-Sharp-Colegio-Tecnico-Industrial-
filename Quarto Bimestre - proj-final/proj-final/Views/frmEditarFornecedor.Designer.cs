namespace proj_final.Views
{
    partial class frmEditarFornecedor
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
            btSalvar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(70, 90);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // frmEditarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 137);
            Controls.Add(btSalvar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "frmEditarFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private TextBox txtNome;
        private Label label1;
    }
}