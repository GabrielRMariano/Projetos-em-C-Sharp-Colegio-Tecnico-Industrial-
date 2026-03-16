namespace proj_final.Views
{
    partial class frmNovaCompra
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
            label1 = new Label();
            dtpDataCompra = new DateTimePicker();
            btSalvar = new Button();
            jogoBindingSource = new BindingSource(components);
            label2 = new Label();
            cbxJogo = new ComboBox();
            label4 = new Label();
            numQtd = new NumericUpDown();
            label3 = new Label();
            cbxFornecedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)jogoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 130);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 12;
            label1.Text = "Data da compra:";
            // 
            // dtpDataCompra
            // 
            dtpDataCompra.Location = new Point(144, 125);
            dtpDataCompra.Margin = new Padding(3, 4, 3, 4);
            dtpDataCompra.Name = "dtpDataCompra";
            dtpDataCompra.Size = new Size(263, 27);
            dtpDataCompra.TabIndex = 11;
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(183, 172);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(94, 29);
            btSalvar.TabIndex = 16;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // jogoBindingSource
            // 
            jogoBindingSource.DataSource = typeof(Classes.Jogo);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 20;
            label2.Text = "Jogo:";
            // 
            // cbxJogo
            // 
            cbxJogo.FormattingEnabled = true;
            cbxJogo.Location = new Point(144, 56);
            cbxJogo.Margin = new Padding(3, 4, 3, 4);
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(263, 28);
            cbxJogo.TabIndex = 21;
            cbxJogo.SelectedIndexChanged += cbxJogo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 93);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 22;
            label4.Text = "Quantidade:";
            // 
            // numQtd
            // 
            numQtd.Location = new Point(144, 91);
            numQtd.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(263, 27);
            numQtd.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 23);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 14;
            label3.Text = "Fornecedor:";
            // 
            // cbxFornecedor
            // 
            cbxFornecedor.FormattingEnabled = true;
            cbxFornecedor.Location = new Point(144, 20);
            cbxFornecedor.Margin = new Padding(3, 4, 3, 4);
            cbxFornecedor.Name = "cbxFornecedor";
            cbxFornecedor.Size = new Size(263, 28);
            cbxFornecedor.TabIndex = 15;
            cbxFornecedor.SelectedValueChanged += cbxFornecedor_SelectedValueChanged;
            // 
            // frmNovaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 213);
            Controls.Add(numQtd);
            Controls.Add(label4);
            Controls.Add(cbxJogo);
            Controls.Add(label2);
            Controls.Add(btSalvar);
            Controls.Add(cbxFornecedor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dtpDataCompra);
            Name = "frmNovaCompra";
            Text = "Nova Compra";
            ((System.ComponentModel.ISupportInitialize)jogoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDataCompra;
        private Button btSalvar;
        private BindingSource jogoBindingSource;
        private Label label2;
        private ComboBox cbxJogo;
        private Label label4;
        private NumericUpDown numQtd;
        private Label label3;
        private ComboBox cbxFornecedor;
    }
}