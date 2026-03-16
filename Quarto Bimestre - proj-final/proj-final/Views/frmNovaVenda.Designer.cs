namespace proj_final.Views
{
    partial class frmNovaVenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btSalvar = new Button();
            cbxFornecedor = new ComboBox();
            cbxJogo = new ComboBox();
            numQtd = new NumericUpDown();
            dtpDataVenda = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 116);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Data da venda:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 48);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Jogo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 84);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantidade:";
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(184, 150);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(94, 29);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cbxFornecedor
            // 
            cbxFornecedor.FormattingEnabled = true;
            cbxFornecedor.Location = new Point(157, 14);
            cbxFornecedor.Name = "cbxFornecedor";
            cbxFornecedor.Size = new Size(263, 28);
            cbxFornecedor.TabIndex = 5;
            cbxFornecedor.SelectedValueChanged += cbxFornecedor_SelectedValueChanged;
            // 
            // cbxJogo
            // 
            cbxJogo.FormattingEnabled = true;
            cbxJogo.Location = new Point(157, 48);
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(263, 28);
            cbxJogo.TabIndex = 6;
            cbxJogo.SelectedIndexChanged += cbxJogo_SelectedIndexChanged;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(157, 82);
            numQtd.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(263, 27);
            numQtd.TabIndex = 24;
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Location = new Point(157, 116);
            dtpDataVenda.Margin = new Padding(3, 4, 3, 4);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(263, 27);
            dtpDataVenda.TabIndex = 25;
            // 
            // frmNovaVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 192);
            Controls.Add(dtpDataVenda);
            Controls.Add(numQtd);
            Controls.Add(cbxJogo);
            Controls.Add(cbxFornecedor);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaVenda";
            Text = "Nova Venda";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btSalvar;
        private ComboBox cbxFornecedor;
        private ComboBox cbxJogo;
        private NumericUpDown numQtd;
        private DateTimePicker dtpDataVenda;
    }
}