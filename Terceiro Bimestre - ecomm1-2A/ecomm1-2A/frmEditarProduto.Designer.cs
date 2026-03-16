namespace ecomm1_2A
{
    partial class frmEditarProduto
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
            btSalvar = new Button();
            txtTipo = new TextBox();
            txtDesc = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            numValor = new NumericUpDown();
            numQtd = new NumericUpDown();
            cbExcluido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(122, 211);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 20;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(142, 93);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(157, 23);
            txtTipo.TabIndex = 18;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(142, 57);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(157, 23);
            txtDesc.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(157, 23);
            txtNome.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 130);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 14;
            label4.Text = "Valor unitário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 95);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 59);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 24);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 167);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 22;
            label6.Text = "Qtd em estoque:";
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numValor.Location = new Point(142, 128);
            numValor.Margin = new Padding(3, 2, 3, 2);
            numValor.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numValor.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numValor.Name = "numValor";
            numValor.Size = new Size(131, 23);
            numValor.TabIndex = 23;
            numValor.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numQtd
            // 
            numQtd.Location = new Point(142, 162);
            numQtd.Margin = new Padding(3, 2, 3, 2);
            numQtd.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(131, 23);
            numQtd.TabIndex = 24;
            numQtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbExcluido
            // 
            cbExcluido.AutoSize = true;
            cbExcluido.Location = new Point(24, 199);
            cbExcluido.Name = "cbExcluido";
            cbExcluido.Size = new Size(71, 19);
            cbExcluido.TabIndex = 25;
            cbExcluido.Text = "Excluído";
            cbExcluido.UseVisualStyleBackColor = true;
            // 
            // frmEditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 256);
            Controls.Add(cbExcluido);
            Controls.Add(numQtd);
            Controls.Add(numValor);
            Controls.Add(label6);
            Controls.Add(btSalvar);
            Controls.Add(txtTipo);
            Controls.Add(txtDesc);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Produto";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btSalvar;
        private TextBox txtTelefone;
        private TextBox txtTipo;
        private TextBox txtDesc;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private NumericUpDown numValor;
        private NumericUpDown numQtd;
        private CheckBox cbExcluido;
    }
}