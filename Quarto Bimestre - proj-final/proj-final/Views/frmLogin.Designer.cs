namespace proj_final.Views
{
    partial class frmLogin
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
            mtxtSenha = new MaskedTextBox();
            txtUsuario = new TextBox();
            btLogar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // mtxtSenha
            // 
            mtxtSenha.Location = new Point(101, 72);
            mtxtSenha.Margin = new Padding(3, 2, 3, 2);
            mtxtSenha.Name = "mtxtSenha";
            mtxtSenha.Size = new Size(110, 23);
            mtxtSenha.TabIndex = 2;
            mtxtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(101, 33);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(110, 23);
            txtUsuario.TabIndex = 1;
            // 
            // btLogar
            // 
            btLogar.Location = new Point(86, 125);
            btLogar.Margin = new Padding(3, 2, 3, 2);
            btLogar.Name = "btLogar";
            btLogar.Size = new Size(82, 22);
            btLogar.TabIndex = 3;
            btLogar.Text = "Logar";
            btLogar.UseVisualStyleBackColor = true;
            btLogar.Click += btLogar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 179);
            Controls.Add(btLogar);
            Controls.Add(txtUsuario);
            Controls.Add(mtxtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += frmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox mtxtSenha;
        private TextBox txtUsuario;
        private Button btLogar;
    }
}