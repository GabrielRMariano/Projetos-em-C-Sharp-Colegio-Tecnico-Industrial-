namespace proj_final.Views
{
    partial class frmFornecedor
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
            btRemover = new Button();
            btEditar = new Button();
            btAdicionar = new Button();
            btBuscar = new Button();
            txtBusca = new TextBox();
            dgvFornecedor = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(583, 347);
            btRemover.Margin = new Padding(3, 4, 3, 4);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(163, 31);
            btRemover.TabIndex = 13;
            btRemover.Text = "Remover Fornecedor";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(184, 347);
            btEditar.Margin = new Padding(3, 4, 3, 4);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(131, 31);
            btEditar.TabIndex = 11;
            btEditar.Text = "Editar Fornecedor";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(14, 347);
            btAdicionar.Margin = new Padding(3, 4, 3, 4);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(163, 31);
            btAdicionar.TabIndex = 10;
            btAdicionar.Text = "Adicionar Fornecedor";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(661, 16);
            btBuscar.Margin = new Padding(3, 4, 3, 4);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(86, 31);
            btBuscar.TabIndex = 9;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(14, 17);
            txtBusca.Margin = new Padding(3, 4, 3, 4);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite o nome do fornecedor)";
            txtBusca.Size = new Size(630, 27);
            txtBusca.TabIndex = 8;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AutoGenerateColumns = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { Id, nomeDataGridViewTextBoxColumn });
            dgvFornecedor.DataSource = fornecedorBindingSource;
            dgvFornecedor.Location = new Point(14, 56);
            dgvFornecedor.Margin = new Padding(3, 4, 3, 4);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.RowHeadersWidth = 51;
            dgvFornecedor.Size = new Size(733, 283);
            dgvFornecedor.TabIndex = 7;
            dgvFornecedor.CellClick += dgvFornecedor_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorBindingSource
            // 
            fornecedorBindingSource.DataSource = typeof(Classes.Fornecedor);
            // 
            // frmFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 392);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvFornecedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedores";
            FormClosing += frmFornecedor_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRemover;
        private Button btEditar;
        private Button btAdicionar;
        private Button btBuscar;
        private TextBox txtBusca;
        private DataGridView dgvFornecedor;
        private DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private BindingSource fornecedorBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}