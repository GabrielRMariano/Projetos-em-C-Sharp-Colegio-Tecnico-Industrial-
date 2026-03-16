namespace proj_final.Views
{
    partial class frmJogo
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
            dgvJogo = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datalancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtdeestoqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jogoBindingSource = new BindingSource(components);
            txtBusca = new TextBox();
            btBuscar = new Button();
            btAdicionar = new Button();
            btEditar = new Button();
            btRelEstoque = new Button();
            btRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvJogo
            // 
            dgvJogo.AutoGenerateColumns = false;
            dgvJogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogo.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, generoDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, datalancamentoDataGridViewTextBoxColumn, qtdeestoqueDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn });
            dgvJogo.DataSource = jogoBindingSource;
            dgvJogo.Location = new Point(14, 56);
            dgvJogo.Margin = new Padding(3, 4, 3, 4);
            dgvJogo.Name = "dgvJogo";
            dgvJogo.RowHeadersWidth = 51;
            dgvJogo.Size = new Size(849, 283);
            dgvJogo.TabIndex = 0;
            dgvJogo.CellClick += dgvJogo_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // datalancamentoDataGridViewTextBoxColumn
            // 
            datalancamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_lancamento";
            datalancamentoDataGridViewTextBoxColumn.HeaderText = "Data_lancamento";
            datalancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            datalancamentoDataGridViewTextBoxColumn.Name = "datalancamentoDataGridViewTextBoxColumn";
            datalancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtdeestoqueDataGridViewTextBoxColumn
            // 
            qtdeestoqueDataGridViewTextBoxColumn.DataPropertyName = "Qtde_estoque";
            qtdeestoqueDataGridViewTextBoxColumn.HeaderText = "Qtde_estoque";
            qtdeestoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            qtdeestoqueDataGridViewTextBoxColumn.Name = "qtdeestoqueDataGridViewTextBoxColumn";
            qtdeestoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // jogoBindingSource
            // 
            jogoBindingSource.DataSource = typeof(Classes.Jogo);
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(14, 17);
            txtBusca.Margin = new Padding(3, 4, 3, 4);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite o nome do jogo)";
            txtBusca.Size = new Size(756, 27);
            txtBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(777, 17);
            btBuscar.Margin = new Padding(3, 4, 3, 4);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(86, 31);
            btBuscar.TabIndex = 2;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(14, 347);
            btAdicionar.Margin = new Padding(3, 4, 3, 4);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(122, 31);
            btAdicionar.TabIndex = 3;
            btAdicionar.Text = "Adicionar Jogo";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(143, 347);
            btEditar.Margin = new Padding(3, 4, 3, 4);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(101, 31);
            btEditar.TabIndex = 4;
            btEditar.Text = "Editar Jogo";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRelEstoque
            // 
            btRelEstoque.Enabled = false;
            btRelEstoque.Location = new Point(514, 347);
            btRelEstoque.Margin = new Padding(3, 4, 3, 4);
            btRelEstoque.Name = "btRelEstoque";
            btRelEstoque.Size = new Size(229, 31);
            btRelEstoque.TabIndex = 5;
            btRelEstoque.Text = "Gerar relatório de estoque";
            btRelEstoque.UseVisualStyleBackColor = true;
            btRelEstoque.Click += btRelEstoque_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(750, 347);
            btRemover.Margin = new Padding(3, 4, 3, 4);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(113, 31);
            btRemover.TabIndex = 6;
            btRemover.Text = "Remover Jogo";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // frmJogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 393);
            Controls.Add(btRemover);
            Controls.Add(btRelEstoque);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvJogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogos";
            FormClosing += frmJogo_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvJogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvJogo;
        private DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private BindingSource jogoBindingSource;
        private TextBox txtBusca;
        private Button btBuscar;
        private Button btAdicionar;
        private Button btEditar;
        private Button btRelEstoque;
        private Button btRemover;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datalancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdeestoqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
    }
}