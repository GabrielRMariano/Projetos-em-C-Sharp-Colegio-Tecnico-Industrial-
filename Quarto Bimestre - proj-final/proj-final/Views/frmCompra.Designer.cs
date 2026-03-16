namespace proj_final.Views
{
    partial class frmCompra
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
            comprasBindingSource = new BindingSource(components);
            btAdicionar = new Button();
            btEditar = new Button();
            btRemover = new Button();
            comprasBindingSource1 = new BindingSource(components);
            dgvCompras = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datacompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comprasBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // comprasBindingSource
            // 
            comprasBindingSource.DataSource = typeof(Classes.Compras);
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 215);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(141, 29);
            btAdicionar.TabIndex = 1;
            btAdicionar.Text = "Realizar Compra";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(305, 215);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(121, 29);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar Compra";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(432, 215);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(153, 29);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover Compra";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // comprasBindingSource1
            // 
            comprasBindingSource1.DataSource = typeof(Classes.Compras);
            // 
            // dgvCompras
            // 
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, datacompraDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn });
            dgvCompras.DataSource = comprasBindingSource2;
            dgvCompras.Location = new Point(12, 12);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.Size = new Size(572, 188);
            dgvCompras.TabIndex = 5;
            dgvCompras.CellClick += dgvCompras_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            datacompraDataGridViewTextBoxColumn.DataPropertyName = "Data_compra";
            datacompraDataGridViewTextBoxColumn.HeaderText = "Data_compra";
            datacompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            datacompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // comprasBindingSource2
            // 
            comprasBindingSource2.DataSource = typeof(Classes.Compras);
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 256);
            Controls.Add(dgvCompras);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            FormClosing += frmCompra_FormClosing;
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource comprasBindingSource;
        private Button btAdicionar;
        private Button btEditar;
        private Button btRemover;
        private BindingSource comprasBindingSource1;
        private DataGridView dgvCompras;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private BindingSource comprasBindingSource2;
    }
}