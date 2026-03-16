namespace proj_final.Views
{
    partial class frmMenuOperacoes
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
            btCompras = new Button();
            btVendas = new Button();
            btVoltar = new Button();
            SuspendLayout();
            // 
            // btCompras
            // 
            btCompras.Location = new Point(34, 30);
            btCompras.Name = "btCompras";
            btCompras.Size = new Size(182, 29);
            btCompras.TabIndex = 0;
            btCompras.Text = "Gerenciar Compras";
            btCompras.UseVisualStyleBackColor = true;
            btCompras.Click += btCompras_Click;
            // 
            // btVendas
            // 
            btVendas.Location = new Point(34, 95);
            btVendas.Name = "btVendas";
            btVendas.Size = new Size(182, 29);
            btVendas.TabIndex = 1;
            btVendas.Text = "Gerenciar Vendas";
            btVendas.UseVisualStyleBackColor = true;
            btVendas.Click += btVendas_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(34, 163);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(182, 29);
            btVoltar.TabIndex = 2;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // frmMenuOperacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 227);
            Controls.Add(btVoltar);
            Controls.Add(btVendas);
            Controls.Add(btCompras);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMenuOperacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operações";
            FormClosing += frmMenuOperacoes_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btCompras;
        private Button btVendas;
        private Button btVoltar;
    }
}