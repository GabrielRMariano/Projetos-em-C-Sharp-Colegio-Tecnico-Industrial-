namespace proj_final.Views
{
    partial class frmMenu
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
            btJogo = new Button();
            btFuncionario = new Button();
            btFornecedor = new Button();
            btOperacoes = new Button();
            SuspendLayout();
            // 
            // btJogo
            // 
            btJogo.Location = new Point(39, 32);
            btJogo.Margin = new Padding(3, 4, 3, 4);
            btJogo.Name = "btJogo";
            btJogo.Size = new Size(166, 31);
            btJogo.TabIndex = 0;
            btJogo.Text = "Gerenciar Jogo";
            btJogo.UseVisualStyleBackColor = true;
            btJogo.Click += btJogo_Click;
            // 
            // btFuncionario
            // 
            btFuncionario.Location = new Point(39, 97);
            btFuncionario.Margin = new Padding(3, 4, 3, 4);
            btFuncionario.Name = "btFuncionario";
            btFuncionario.Size = new Size(166, 31);
            btFuncionario.TabIndex = 1;
            btFuncionario.Text = "Gerenciar Funcionário";
            btFuncionario.UseVisualStyleBackColor = true;
            btFuncionario.Click += btFuncionario_Click;
            // 
            // btFornecedor
            // 
            btFornecedor.Location = new Point(39, 161);
            btFornecedor.Margin = new Padding(3, 4, 3, 4);
            btFornecedor.Name = "btFornecedor";
            btFornecedor.Size = new Size(166, 31);
            btFornecedor.TabIndex = 2;
            btFornecedor.Text = "Gerenciar Fornecedor";
            btFornecedor.UseVisualStyleBackColor = true;
            btFornecedor.Click += btFornecedor_Click;
            // 
            // btOperacoes
            // 
            btOperacoes.Location = new Point(39, 228);
            btOperacoes.Margin = new Padding(3, 4, 3, 4);
            btOperacoes.Name = "btOperacoes";
            btOperacoes.Size = new Size(166, 32);
            btOperacoes.TabIndex = 3;
            btOperacoes.Text = "Menu de Operações";
            btOperacoes.UseVisualStyleBackColor = true;
            btOperacoes.Click += btOperacoes_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 294);
            Controls.Add(btOperacoes);
            Controls.Add(btFornecedor);
            Controls.Add(btFuncionario);
            Controls.Add(btJogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btJogo;
        private Button btFuncionario;
        private Button btFornecedor;
        private Button btOperacoes;
    }
}