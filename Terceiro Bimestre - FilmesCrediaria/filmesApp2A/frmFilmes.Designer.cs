namespace filmesApp2A
{
    partial class frmFilmes
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
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            btRemover = new Button();
            btEditar = new Button();
            btCadastrar = new Button();
            btBuscar = new Button();
            txtBusca = new TextBox();
            btGerenciar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(12, 67);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(690, 270);
            dgvFilmes.TabIndex = 11;
            dgvFilmes.CellClick += dgvFilmes_CellClick;
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
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(607, 354);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(95, 23);
            btRemover.TabIndex = 10;
            btRemover.Text = "Remover Filme";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(513, 354);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(88, 23);
            btEditar.TabIndex = 9;
            btEditar.Text = "Editar Filme";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 354);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(111, 23);
            btCadastrar.TabIndex = 8;
            btCadastrar.Text = "Cadastrar Filme";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(627, 29);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 7;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 29);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(609, 23);
            txtBusca.TabIndex = 6;
            // 
            // btGerenciar
            // 
            btGerenciar.Enabled = false;
            btGerenciar.Location = new Point(129, 354);
            btGerenciar.Name = "btGerenciar";
            btGerenciar.Size = new Size(106, 23);
            btGerenciar.TabIndex = 12;
            btGerenciar.Text = "Gerenciar Elenco";
            btGerenciar.UseVisualStyleBackColor = true;
            btGerenciar.Click += btGerenciar_Click;
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 396);
            Controls.Add(btGerenciar);
            Controls.Add(dgvFilmes);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btCadastrar);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            MaximizeBox = false;
            Name = "frmFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filmes";
            FormClosing += frmFilmes_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFilmes;
        private Button btRemover;
        private Button btEditar;
        private Button btCadastrar;
        private Button btBuscar;
        private TextBox txtBusca;
        private Button btGerenciar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}