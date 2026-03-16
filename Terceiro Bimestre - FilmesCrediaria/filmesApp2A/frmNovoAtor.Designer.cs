namespace filmesApp2A
{
    partial class frmNovoAtor
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            cbxPais = new ComboBox();
            btCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 82);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nacionalidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(169, 23);
            txtNome.TabIndex = 2;
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(113, 79);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(169, 23);
            cbxPais.TabIndex = 3;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(113, 127);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 174);
            Controls.Add(btCadastrar);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNovoAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Ator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private ComboBox cbxPais;
        private Button btCadastrar;
    }
}