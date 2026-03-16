namespace CaixaEletronico
{
    partial class frmInicial
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
            btAdm = new Button();
            btCaixa = new Button();
            SuspendLayout();
            // 
            // btAdm
            // 
            btAdm.Location = new Point(43, 29);
            btAdm.Name = "btAdm";
            btAdm.Size = new Size(185, 68);
            btAdm.TabIndex = 0;
            btAdm.Text = "Acesso Administrativo";
            btAdm.UseVisualStyleBackColor = true;
            btAdm.Click += btAdm_Click;
            // 
            // btCaixa
            // 
            btCaixa.Location = new Point(43, 116);
            btCaixa.Name = "btCaixa";
            btCaixa.Size = new Size(185, 74);
            btCaixa.TabIndex = 1;
            btCaixa.Text = "Caixa Eletrônico";
            btCaixa.UseVisualStyleBackColor = true;
            btCaixa.Click += btCaixa_Click;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 231);
            Controls.Add(btCaixa);
            Controls.Add(btAdm);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CTiBank";
            FormClosed += frmInicial_FormClosed;
            Load += frmInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btAdm;
        private Button btCaixa;
    }
}
