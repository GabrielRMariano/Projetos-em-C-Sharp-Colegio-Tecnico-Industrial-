namespace ecomm1_2A
{
    partial class frmProduto
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
            btAdicionar = new Button();
            btRemover = new Button();
            btBuscar = new Button();
            txtBusca = new TextBox();
            dgvProduto = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorunitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoprodutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            excluidoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataexclusaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtdeestoqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource2 = new BindingSource(components);
            produtoBindingSource1 = new BindingSource(components);
            produtoBindingSource = new BindingSource(components);
            btEditar = new Button();
            btRelEstoque = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 218);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(116, 23);
            btAdicionar.TabIndex = 10;
            btAdicionar.Text = "Adicionar Produto";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(954, 218);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(111, 23);
            btRemover.TabIndex = 9;
            btRemover.Text = "Remover Produto";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(990, 17);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 8;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 17);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite o nome do produto)";
            txtBusca.Size = new Size(972, 23);
            txtBusca.TabIndex = 7;
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { Id, nomeDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, valorunitarioDataGridViewTextBoxColumn, tipoprodutoDataGridViewTextBoxColumn, excluidoDataGridViewCheckBoxColumn, dataexclusaoDataGridViewTextBoxColumn, qtdeestoqueDataGridViewTextBoxColumn });
            dgvProduto.DataSource = produtoBindingSource2;
            dgvProduto.Location = new Point(12, 46);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dgvProduto.RowHeadersWidth = 51;
            dgvProduto.Size = new Size(1053, 166);
            dgvProduto.TabIndex = 6;
            dgvProduto.CellClick += dgvProduto_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorunitarioDataGridViewTextBoxColumn
            // 
            valorunitarioDataGridViewTextBoxColumn.DataPropertyName = "Valor_unitario";
            valorunitarioDataGridViewTextBoxColumn.HeaderText = "Valor_unitario";
            valorunitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorunitarioDataGridViewTextBoxColumn.Name = "valorunitarioDataGridViewTextBoxColumn";
            valorunitarioDataGridViewTextBoxColumn.ReadOnly = true;
            valorunitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoprodutoDataGridViewTextBoxColumn
            // 
            tipoprodutoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_produto";
            tipoprodutoDataGridViewTextBoxColumn.HeaderText = "Tipo_produto";
            tipoprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoprodutoDataGridViewTextBoxColumn.Name = "tipoprodutoDataGridViewTextBoxColumn";
            tipoprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoprodutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // excluidoDataGridViewCheckBoxColumn
            // 
            excluidoDataGridViewCheckBoxColumn.DataPropertyName = "Excluido";
            excluidoDataGridViewCheckBoxColumn.HeaderText = "Excluido";
            excluidoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            excluidoDataGridViewCheckBoxColumn.Name = "excluidoDataGridViewCheckBoxColumn";
            excluidoDataGridViewCheckBoxColumn.ReadOnly = true;
            excluidoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // dataexclusaoDataGridViewTextBoxColumn
            // 
            dataexclusaoDataGridViewTextBoxColumn.DataPropertyName = "Data_exclusao";
            dataexclusaoDataGridViewTextBoxColumn.HeaderText = "Data_exclusao";
            dataexclusaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataexclusaoDataGridViewTextBoxColumn.Name = "dataexclusaoDataGridViewTextBoxColumn";
            dataexclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            dataexclusaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtdeestoqueDataGridViewTextBoxColumn
            // 
            qtdeestoqueDataGridViewTextBoxColumn.DataPropertyName = "Qtde_estoque";
            qtdeestoqueDataGridViewTextBoxColumn.HeaderText = "Qtde_estoque";
            qtdeestoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            qtdeestoqueDataGridViewTextBoxColumn.Name = "qtdeestoqueDataGridViewTextBoxColumn";
            qtdeestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            qtdeestoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoBindingSource2
            // 
            produtoBindingSource2.DataSource = typeof(classes.Produto);
            // 
            // produtoBindingSource1
            // 
            produtoBindingSource1.DataSource = typeof(classes.Produto);
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(classes.Produto);
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(145, 218);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(115, 23);
            btEditar.TabIndex = 11;
            btEditar.Text = "Editar Produto";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRelEstoque
            // 
            btRelEstoque.Enabled = false;
            btRelEstoque.Location = new Point(783, 218);
            btRelEstoque.Name = "btRelEstoque";
            btRelEstoque.Size = new Size(165, 23);
            btRelEstoque.TabIndex = 12;
            btRelEstoque.Text = "Gerar relatório de estoque";
            btRelEstoque.UseVisualStyleBackColor = true;
            btRelEstoque.Click += btRelEstoque_Click;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 250);
            Controls.Add(btRelEstoque);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Controls.Add(btRemover);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvProduto);
            MaximizeBox = false;
            Name = "frmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            FormClosing += frmProduto_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAdicionar;
        private Button btRemover;
        private Button btBuscar;
        private TextBox txtBusca;
        private DataGridView dgvProduto;
        private DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private BindingSource produtoBindingSource;
        private Button btEditar;
        private Button btRelEstoque;
        private BindingSource produtoBindingSource1;
        private BindingSource produtoBindingSource2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorunitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoprodutoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn excluidoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataexclusaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdeestoqueDataGridViewTextBoxColumn;
    }
}