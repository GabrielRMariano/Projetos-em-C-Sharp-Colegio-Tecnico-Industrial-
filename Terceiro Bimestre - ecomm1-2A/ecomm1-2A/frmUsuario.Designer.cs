namespace ecomm1_2A
{
    partial class frmUsuario
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
            usuarioBindingSource = new BindingSource(components);
            txtBusca = new TextBox();
            btBuscar = new Button();
            btRemover = new Button();
            btEditar = new Button();
            dgvUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            senhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            usuarioBindingSource3 = new BindingSource(components);
            usuarioBindingSource1 = new BindingSource(components);
            usuarioBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(classes.Usuario);
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 28);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite o nome do usuário)";
            txtBusca.Size = new Size(846, 23);
            txtBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(864, 28);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 2;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(828, 229);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(111, 23);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover Usuário";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(12, 229);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(111, 23);
            btEditar.TabIndex = 5;
            btEditar.Text = "Editar Usuário";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, nomeDataGridViewTextBoxColumn, cpfDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, senhaDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, adminDataGridViewCheckBoxColumn });
            dgvUsuario.DataSource = usuarioBindingSource3;
            dgvUsuario.Location = new Point(11, 57);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersWidth = 51;
            dgvUsuario.Size = new Size(928, 166);
            dgvUsuario.TabIndex = 0;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
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
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            cpfDataGridViewTextBoxColumn.ReadOnly = true;
            cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            senhaDataGridViewTextBoxColumn.MinimumWidth = 6;
            senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            senhaDataGridViewTextBoxColumn.ReadOnly = true;
            senhaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            adminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            adminDataGridViewCheckBoxColumn.ReadOnly = true;
            adminDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuarioBindingSource3
            // 
            usuarioBindingSource3.DataSource = typeof(classes.Usuario);
            // 
            // usuarioBindingSource1
            // 
            usuarioBindingSource1.DataSource = typeof(classes.Usuario);
            // 
            // usuarioBindingSource2
            // 
            usuarioBindingSource2.DataSource = typeof(classes.Usuario);
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 264);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvUsuario);
            MaximizeBox = false;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            FormClosing += frmUsuario_FormClosing;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource usuarioBindingSource;
        private TextBox txtBusca;
        private Button btBuscar;
        private Button btRemover;
        private Button btEditar;
        private DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private DataGridView dgvUsuario;
        private BindingSource usuarioBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private BindingSource usuarioBindingSource3;
        private BindingSource usuarioBindingSource2;
    }
}