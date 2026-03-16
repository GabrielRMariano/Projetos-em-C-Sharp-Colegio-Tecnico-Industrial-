namespace CaixaEletronico
{
    partial class frmAdm
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
            dgvContas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            chbEspecial = new CheckBox();
            chbStatus = new CheckBox();
            label3 = new Label();
            txtNum = new TextBox();
            numLimite = new NumericUpDown();
            numSaldo = new NumericUpDown();
            cbxTipo = new ComboBox();
            btVoltar = new Button();
            btCancelar = new Button();
            btCadastar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // dgvContas
            // 
            dgvContas.AllowUserToAddRows = false;
            dgvContas.AllowUserToDeleteRows = false;
            dgvContas.AllowUserToResizeColumns = false;
            dgvContas.AllowUserToResizeRows = false;
            dgvContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvContas.Location = new Point(12, 12);
            dgvContas.Name = "dgvContas";
            dgvContas.Size = new Size(349, 392);
            dgvContas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Número da conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 57);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 114);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Limite:";
            // 
            // chbEspecial
            // 
            chbEspecial.AutoSize = true;
            chbEspecial.Location = new Point(496, 141);
            chbEspecial.Name = "chbEspecial";
            chbEspecial.Size = new Size(68, 19);
            chbEspecial.TabIndex = 5;
            chbEspecial.Text = "Especial";
            chbEspecial.UseVisualStyleBackColor = true;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(496, 166);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(58, 19);
            chbStatus.TabIndex = 6;
            chbStatus.Text = "Status";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 85);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Saldo:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(496, 25);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(120, 23);
            txtNum.TabIndex = 1;
            // 
            // numLimite
            // 
            numLimite.Location = new Point(497, 112);
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(120, 23);
            numLimite.TabIndex = 4;
            // 
            // numSaldo
            // 
            numSaldo.Enabled = false;
            numSaldo.Location = new Point(496, 83);
            numSaldo.Name = "numSaldo";
            numSaldo.Size = new Size(120, 23);
            numSaldo.TabIndex = 3;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Conta Corrente", "Conta Poupança" });
            cbxTipo.Location = new Point(496, 54);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(121, 23);
            cbxTipo.TabIndex = 2;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 415);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(75, 23);
            btVoltar.TabIndex = 8;
            btVoltar.Text = "&Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(107, 415);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Ca&ncelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btCadastar
            // 
            btCadastar.Location = new Point(418, 221);
            btCadastar.Name = "btCadastar";
            btCadastar.Size = new Size(88, 59);
            btCadastar.TabIndex = 10;
            btCadastar.Text = "&Cadastrar";
            btCadastar.UseVisualStyleBackColor = true;
            btCadastar.Click += btCadastar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(523, 221);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(93, 59);
            btSalvar.TabIndex = 11;
            btSalvar.Text = "&Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(627, 221);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(88, 59);
            btExcluir.TabIndex = 12;
            btExcluir.Text = "E&xcluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // frmAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btExcluir);
            Controls.Add(btSalvar);
            Controls.Add(btCadastar);
            Controls.Add(btCancelar);
            Controls.Add(btVoltar);
            Controls.Add(cbxTipo);
            Controls.Add(numSaldo);
            Controls.Add(numLimite);
            Controls.Add(txtNum);
            Controls.Add(label3);
            Controls.Add(chbStatus);
            Controls.Add(chbEspecial);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvContas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdm";
            Text = "CTiBank - Painel Administrativo";
            Load += frmAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContas;
        private Label label1;
        private Label label2;
        private Label label4;
        private CheckBox chbEspecial;
        private CheckBox chbStatus;
        private Label label3;
        private TextBox txtNum;
        private NumericUpDown numLimite;
        private NumericUpDown numSaldo;
        private ComboBox cbxTipo;
        private Button btVoltar;
        private Button btCancelar;
        private Button btCadastar;
        private Button btSalvar;
        private Button btExcluir;
    }
}