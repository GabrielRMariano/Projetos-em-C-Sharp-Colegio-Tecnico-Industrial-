namespace proj_final.Views
{
    partial class frmNovoJogo
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
            txtTitulo = new TextBox();
            txtGenero = new TextBox();
            numPreco = new NumericUpDown();
            dtpDataLancamento = new DateTimePicker();
            numQtdeEstoque = new NumericUpDown();
            cboFornecedor = new ComboBox();
            btSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtdeEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(143, 18);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(143, 52);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 1;
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Increment = new decimal(new int[] { 15, 0, 0, 65536 });
            numPreco.Location = new Point(143, 81);
            numPreco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(120, 23);
            numPreco.TabIndex = 2;
            // 
            // dtpDataLancamento
            // 
            dtpDataLancamento.Location = new Point(143, 112);
            dtpDataLancamento.Name = "dtpDataLancamento";
            dtpDataLancamento.Size = new Size(231, 23);
            dtpDataLancamento.TabIndex = 3;
            // 
            // numQtdeEstoque
            // 
            numQtdeEstoque.Location = new Point(143, 148);
            numQtdeEstoque.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numQtdeEstoque.Name = "numQtdeEstoque";
            numQtdeEstoque.Size = new Size(120, 23);
            numQtdeEstoque.TabIndex = 4;
            // 
            // cboFornecedor
            // 
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(143, 189);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(121, 23);
            cboFornecedor.TabIndex = 5;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(143, 227);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Gênero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Preço (em R$):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 10;
            label4.Text = "Data de lançamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 11;
            label5.Text = "Qtde em estoque:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Fornecedor:";
            // 
            // frmNovoJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 266);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSalvar);
            Controls.Add(cboFornecedor);
            Controls.Add(numQtdeEstoque);
            Controls.Add(dtpDataLancamento);
            Controls.Add(numPreco);
            Controls.Add(txtGenero);
            Controls.Add(txtTitulo);
            Name = "frmNovoJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Jogo";
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtdeEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtGenero;
        private NumericUpDown numPreco;
        private DateTimePicker dtpDataLancamento;
        private NumericUpDown numQtdeEstoque;
        private ComboBox cboFornecedor;
        private Button btSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}