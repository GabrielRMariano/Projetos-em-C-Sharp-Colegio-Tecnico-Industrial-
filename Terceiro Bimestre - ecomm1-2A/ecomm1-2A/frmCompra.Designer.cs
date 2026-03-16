namespace ecomm1_2A
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
            btEditar = new Button();
            btRemover = new Button();
            btBuscar = new Button();
            txtBusca = new TextBox();
            dgvCompra = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acrescimototalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sessaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idtransacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            compraBindingSource3 = new BindingSource(components);
            compraBindingSource2 = new BindingSource(components);
            compraBindingSource1 = new BindingSource(components);
            compraBindingSource = new BindingSource(components);
            compraBindingSource4 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource4).BeginInit();
            SuspendLayout();
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(12, 221);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(111, 23);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar Compra";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(900, 221);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(111, 23);
            btRemover.TabIndex = 9;
            btRemover.Text = "Remover Compra";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(936, 20);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 8;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 20);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite a sessão da compra)";
            txtBusca.Size = new Size(918, 23);
            txtBusca.TabIndex = 7;
            // 
            // dgvCompra
            // 
            dgvCompra.AllowUserToAddRows = false;
            dgvCompra.AllowUserToDeleteRows = false;
            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Columns.AddRange(new DataGridViewColumn[] { Id, statusDataGridViewTextBoxColumn, acrescimototalDataGridViewTextBoxColumn, sessaoDataGridViewTextBoxColumn, idtransacaoDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, Total });
            dgvCompra.DataSource = compraBindingSource4;
            dgvCompra.Location = new Point(12, 49);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.ReadOnly = true;
            dgvCompra.RowHeadersWidth = 51;
            dgvCompra.Size = new Size(999, 166);
            dgvCompra.TabIndex = 6;
            dgvCompra.CellClick += dgvCompra_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimototalDataGridViewTextBoxColumn
            // 
            acrescimototalDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo_total";
            acrescimototalDataGridViewTextBoxColumn.HeaderText = "Acrescimo_total";
            acrescimototalDataGridViewTextBoxColumn.MinimumWidth = 6;
            acrescimototalDataGridViewTextBoxColumn.Name = "acrescimototalDataGridViewTextBoxColumn";
            acrescimototalDataGridViewTextBoxColumn.ReadOnly = true;
            acrescimototalDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessaoDataGridViewTextBoxColumn
            // 
            sessaoDataGridViewTextBoxColumn.DataPropertyName = "Sessao";
            sessaoDataGridViewTextBoxColumn.HeaderText = "Sessao";
            sessaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            sessaoDataGridViewTextBoxColumn.Name = "sessaoDataGridViewTextBoxColumn";
            sessaoDataGridViewTextBoxColumn.ReadOnly = true;
            sessaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtransacaoDataGridViewTextBoxColumn
            // 
            idtransacaoDataGridViewTextBoxColumn.DataPropertyName = "Id_transacao";
            idtransacaoDataGridViewTextBoxColumn.HeaderText = "Id_transacao";
            idtransacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idtransacaoDataGridViewTextBoxColumn.Name = "idtransacaoDataGridViewTextBoxColumn";
            idtransacaoDataGridViewTextBoxColumn.ReadOnly = true;
            idtransacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // compraBindingSource3
            // 
            compraBindingSource3.DataSource = typeof(classes.Compra);
            // 
            // compraBindingSource2
            // 
            compraBindingSource2.DataSource = typeof(classes.Compra);
            // 
            // compraBindingSource1
            // 
            compraBindingSource1.DataSource = typeof(classes.Compra);
            // 
            // compraBindingSource
            // 
            compraBindingSource.DataSource = typeof(classes.Compra);
            // 
            // compraBindingSource4
            // 
            compraBindingSource4.DataSource = typeof(classes.Compra);
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 256);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvCompra);
            MaximizeBox = false;
            Name = "frmCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            FormClosing += frmCompra_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraBindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditar;
        private Button btRemover;
        private Button btBuscar;
        private TextBox txtBusca;
        private DataGridView dgvCompra;
        private DataGridViewTextBoxColumn idcompraDataGridViewTextBoxColumn;
        private BindingSource compraBindingSource;
        private BindingSource compraBindingSource1;
        private BindingSource compraBindingSource2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fkidusuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimototalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idtransacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Total;
        private BindingSource compraBindingSource3;
        private BindingSource compraBindingSource4;
    }
}