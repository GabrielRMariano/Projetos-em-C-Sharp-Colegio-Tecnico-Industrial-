namespace filmesApp2A
{
    partial class frmNovoFilme
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
            btCadastrar = new Button();
            cbxPais = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            numAno = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(127, 142);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(127, 101);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(169, 23);
            cbxPais.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(127, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(169, 23);
            txtNome.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 61);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Ano de lançamento:";
            // 
            // numAno
            // 
            numAno.Location = new Point(127, 59);
            numAno.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numAno.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(169, 23);
            numAno.TabIndex = 11;
            numAno.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 177);
            Controls.Add(numAno);
            Controls.Add(label3);
            Controls.Add(btCadastrar);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmNovoFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Filme";
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCadastrar;
        private ComboBox cbxPais;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Label label3;
        private NumericUpDown numAno;
    }
}