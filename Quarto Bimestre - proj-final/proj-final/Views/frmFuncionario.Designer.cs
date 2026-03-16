namespace proj_final.Views
{
    partial class frmFuncionario
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
            dgvFuncionario = new DataGridView();
            funcionarioBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            senhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(510, 256);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(143, 23);
            btRemover.TabIndex = 19;
            btRemover.Text = "Remover Funcionário";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(161, 256);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(115, 23);
            btEditar.TabIndex = 18;
            btEditar.Text = "Editar Funcionário";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 256);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(143, 23);
            btAdicionar.TabIndex = 17;
            btAdicionar.Text = "Adicionar Funcionário";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(578, 8);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 16;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 9);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "(Digite o nome do funcionário)";
            txtBusca.Size = new Size(552, 23);
            txtBusca.TabIndex = 15;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adminDataGridViewCheckBoxColumn, senhaDataGridViewTextBoxColumn });
            dgvFuncionario.DataSource = funcionarioBindingSource;
            dgvFuncionario.Location = new Point(12, 38);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.Size = new Size(641, 212);
            dgvFuncionario.TabIndex = 14;
            dgvFuncionario.CellClick += dgvFuncionario_CellClick;
            // 
            // funcionarioBindingSource
            // 
            funcionarioBindingSource.DataSource = typeof(Classes.Funcionario);
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
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // frmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 285);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btAdicionar);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dgvFuncionario);
            Name = "frmFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            FormClosing += frmFuncionario_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRemover;
        private Button btEditar;
        private Button btAdicionar;
        private Button btBuscar;
        private TextBox txtBusca;
        private DataGridView dgvFuncionario;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private BindingSource funcionarioBindingSource;
    }
}