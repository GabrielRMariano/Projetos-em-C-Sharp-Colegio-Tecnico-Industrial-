namespace ecomm1_2A
{
    partial class frmNovoProduto
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
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTipo = new TextBox();
            label4 = new Label();
            txtDesc = new TextBox();
            label5 = new Label();
            numQtd = new NumericUpDown();
            numValor = new NumericUpDown();
            btSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(194, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 27);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 280);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor unitário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 338);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Qtd em estoque:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(194, 225);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(278, 27);
            txtTipo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 228);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipo do produto:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(194, 103);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(278, 99);
            txtDesc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 103);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Descrição:";
            // 
            // numQtd
            // 
            numQtd.Location = new Point(194, 336);
            numQtd.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(150, 27);
            numQtd.TabIndex = 10;
            numQtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numValor.Location = new Point(194, 278);
            numValor.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numValor.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numValor.Name = "numValor";
            numValor.Size = new Size(150, 27);
            numValor.TabIndex = 11;
            numValor.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(225, 400);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(94, 29);
            btSalvar.TabIndex = 12;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // frmNovoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 465);
            Controls.Add(btSalvar);
            Controls.Add(numValor);
            Controls.Add(numQtd);
            Controls.Add(txtDesc);
            Controls.Add(label5);
            Controls.Add(txtTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmNovoProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Produto";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtTipo;
        private Label label4;
        private TextBox txtDesc;
        private Label label5;
        private NumericUpDown numQtd;
        private NumericUpDown numValor;
        private Button btSalvar;
    }
}