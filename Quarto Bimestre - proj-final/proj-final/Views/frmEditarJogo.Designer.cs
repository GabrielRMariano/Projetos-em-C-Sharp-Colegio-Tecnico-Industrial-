namespace proj_final.Views
{
    partial class frmEditarJogo
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btSalvar = new Button();
            cboFornecedor = new ComboBox();
            numQtdeEstoque = new NumericUpDown();
            dtpDataLancamento = new DateTimePicker();
            numPreco = new NumericUpDown();
            txtGenero = new TextBox();
            txtTitulo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQtdeEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 189);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 25;
            label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 150);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 24;
            label5.Text = "Qtde em estoque:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 118);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 23;
            label4.Text = "Data de lançamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 83);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 22;
            label3.Text = "Preço (em R$):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 21;
            label2.Text = "Gênero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 20;
            label1.Text = "Titulo:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(142, 227);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 19;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cboFornecedor
            // 
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(142, 189);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(121, 23);
            cboFornecedor.TabIndex = 18;
            // 
            // numQtdeEstoque
            // 
            numQtdeEstoque.Location = new Point(142, 148);
            numQtdeEstoque.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numQtdeEstoque.Name = "numQtdeEstoque";
            numQtdeEstoque.Size = new Size(120, 23);
            numQtdeEstoque.TabIndex = 17;
            // 
            // dtpDataLancamento
            // 
            dtpDataLancamento.Location = new Point(142, 112);
            dtpDataLancamento.Name = "dtpDataLancamento";
            dtpDataLancamento.Size = new Size(231, 23);
            dtpDataLancamento.TabIndex = 16;
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Increment = new decimal(new int[] { 15, 0, 0, 65536 });
            numPreco.Location = new Point(142, 81);
            numPreco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(120, 23);
            numPreco.TabIndex = 15;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(142, 52);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 14;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(142, 18);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 13;
            // 
            // frmEditarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 266);
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
            Name = "frmEditarJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Jogo";
            ((System.ComponentModel.ISupportInitialize)numQtdeEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btSalvar;
        private ComboBox cboFornecedor;
        private NumericUpDown numQtdeEstoque;
        private DateTimePicker dtpDataLancamento;
        private NumericUpDown numPreco;
        private TextBox txtGenero;
        private TextBox txtTitulo;
    }
}