namespace proj_final.Views
{
    partial class frmVenda
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
            dgvVendas = new DataGridView();
            idvendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datavendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            funcionarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendaBindingSource = new BindingSource(components);
            btAdicionar = new Button();
            btEditar = new Button();
            btRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvVendas
            // 
            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Columns.AddRange(new DataGridViewColumn[] { idvendaDataGridViewTextBoxColumn, datavendaDataGridViewTextBoxColumn, funcionarioDataGridViewTextBoxColumn });
            dgvVendas.DataSource = vendaBindingSource;
            dgvVendas.Location = new Point(12, 12);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.RowHeadersWidth = 51;
            dgvVendas.Size = new Size(651, 188);
            dgvVendas.TabIndex = 0;
            dgvVendas.CellClick += dgvVendas_CellClick;
            // 
            // idvendaDataGridViewTextBoxColumn
            // 
            idvendaDataGridViewTextBoxColumn.DataPropertyName = "Id_venda";
            idvendaDataGridViewTextBoxColumn.HeaderText = "Id_venda";
            idvendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idvendaDataGridViewTextBoxColumn.Name = "idvendaDataGridViewTextBoxColumn";
            idvendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datavendaDataGridViewTextBoxColumn
            // 
            datavendaDataGridViewTextBoxColumn.DataPropertyName = "Data_venda";
            datavendaDataGridViewTextBoxColumn.HeaderText = "Data_venda";
            datavendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            datavendaDataGridViewTextBoxColumn.Name = "datavendaDataGridViewTextBoxColumn";
            datavendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            funcionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario";
            funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            funcionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            funcionarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Classes.Venda);
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 206);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(123, 29);
            btAdicionar.TabIndex = 1;
            btAdicionar.Text = "Realizar Venda";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(395, 206);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(118, 29);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar Venda";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(519, 206);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(144, 29);
            btRemover.TabIndex = 3;
            btRemover.Text = "Remover Venda";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 253);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Controls.Add(dgvVendas);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            FormClosing += frmVenda_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVendas;
        private DataGridViewTextBoxColumn idvendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datavendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private BindingSource vendaBindingSource;
        private Button btAdicionar;
        private Button btEditar;
        private Button btRemover;
    }
}