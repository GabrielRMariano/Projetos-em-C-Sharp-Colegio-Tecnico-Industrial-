namespace filmesApp2A
{
    partial class frmGerenciarElenco
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
            dgvElenco = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btRemover = new Button();
            btInserir = new Button();
            cbxAtor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvElenco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvElenco
            // 
            dgvElenco.AutoGenerateColumns = false;
            dgvElenco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElenco.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvElenco.DataSource = atorBindingSource;
            dgvElenco.Location = new Point(12, 84);
            dgvElenco.Name = "dgvElenco";
            dgvElenco.Size = new Size(489, 239);
            dgvElenco.TabIndex = 18;
            dgvElenco.CellClick += dgvElenco_CellClick;
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
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(406, 329);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(95, 23);
            btRemover.TabIndex = 17;
            btRemover.Text = "Remover Ator";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btInserir
            // 
            btInserir.Location = new Point(202, 55);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(111, 23);
            btInserir.TabIndex = 15;
            btInserir.Text = "Inserir Ator";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // cbxAtor
            // 
            cbxAtor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtor.FormattingEnabled = true;
            cbxAtor.Location = new Point(176, 26);
            cbxAtor.Name = "cbxAtor";
            cbxAtor.Size = new Size(170, 23);
            cbxAtor.TabIndex = 19;
            // 
            // frmGerenciarElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 360);
            Controls.Add(cbxAtor);
            Controls.Add(dgvElenco);
            Controls.Add(btRemover);
            Controls.Add(btInserir);
            MaximizeBox = false;
            Name = "frmGerenciarElenco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Elenco";
            ((System.ComponentModel.ISupportInitialize)dgvElenco).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvElenco;
        private Button btRemover;
        private Button btInserir;
        private ComboBox cbxAtor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
    }
}