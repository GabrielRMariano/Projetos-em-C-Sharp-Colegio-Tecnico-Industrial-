namespace filmesApp2A
{
    partial class frmEditarFilme
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
            components = new System.ComponentModel.Container();
            btSalvar = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            cbxPais = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            filmeBindingSource = new BindingSource(components);
            numAno = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(214, 133);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 13;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = atorBindingSource;
            dgvFilmes.Location = new Point(25, 190);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(491, 216);
            dgvFilmes.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(214, 96);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(197, 23);
            cbxPais.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(214, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Elenco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // numAno
            // 
            numAno.Location = new Point(214, 64);
            numAno.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numAno.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(197, 23);
            numAno.TabIndex = 15;
            numAno.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 66);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 14;
            label4.Text = "Ano de lançamento:";
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 416);
            Controls.Add(numAno);
            Controls.Add(label4);
            Controls.Add(btSalvar);
            Controls.Add(dgvFilmes);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Filme";
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private DataGridView dgvFilmes;
        private ComboBox cbxPais;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
        private NumericUpDown numAno;
        private Label label4;
        private BindingSource atorBindingSource;
    }
}