namespace ecomm1_2A
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btUsuario = new Button();
            btCompra = new Button();
            btProduto = new Button();
            SuspendLayout();
            // 
            // btUsuario
            // 
            btUsuario.Location = new Point(48, 49);
            btUsuario.Margin = new Padding(3, 4, 3, 4);
            btUsuario.Name = "btUsuario";
            btUsuario.Size = new Size(169, 31);
            btUsuario.TabIndex = 0;
            btUsuario.Text = "Gerenciar Usuário";
            btUsuario.UseVisualStyleBackColor = true;
            btUsuario.Click += btUsuario_Click;
            // 
            // btCompra
            // 
            btCompra.Location = new Point(48, 128);
            btCompra.Margin = new Padding(3, 4, 3, 4);
            btCompra.Name = "btCompra";
            btCompra.Size = new Size(169, 31);
            btCompra.TabIndex = 3;
            btCompra.Text = "Gerenciar Compra";
            btCompra.UseVisualStyleBackColor = true;
            btCompra.Click += btCompra_Click;
            // 
            // btProduto
            // 
            btProduto.Location = new Point(48, 208);
            btProduto.Margin = new Padding(3, 4, 3, 4);
            btProduto.Name = "btProduto";
            btProduto.Size = new Size(169, 31);
            btProduto.TabIndex = 4;
            btProduto.Text = "Gerenciar Produto";
            btProduto.UseVisualStyleBackColor = true;
            btProduto.Click += btProduto_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 284);
            Controls.Add(btProduto);
            Controls.Add(btCompra);
            Controls.Add(btUsuario);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btUsuario;
        private Button btCompra;
        private Button btProduto;
    }
}
