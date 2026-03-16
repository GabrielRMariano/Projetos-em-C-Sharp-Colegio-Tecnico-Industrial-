namespace proj_final.Views
{
    partial class frmEditarCompra
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
            label1 = new Label();
            numQtd = new NumericUpDown();
            dtpDataCompra = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(216, 110);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(94, 29);
            btSalvar.TabIndex = 0;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Quantidade de jogos:";
            // 
            // numQtd
            // 
            numQtd.Location = new Point(206, 21);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(263, 27);
            numQtd.TabIndex = 2;
            // 
            // dtpDataCompra
            // 
            dtpDataCompra.Location = new Point(206, 66);
            dtpDataCompra.Margin = new Padding(3, 4, 3, 4);
            dtpDataCompra.Name = "dtpDataCompra";
            dtpDataCompra.Size = new Size(263, 27);
            dtpDataCompra.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 66);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Data de compra:";
            // 
            // frmEditarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 163);
            Controls.Add(label2);
            Controls.Add(dtpDataCompra);
            Controls.Add(numQtd);
            Controls.Add(label1);
            Controls.Add(btSalvar);
            MaximizeBox = false;
            Name = "frmEditarCompra";
            Text = "Editar Compra";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvar;
        private Label label1;
        private NumericUpDown numQtd;
        private DateTimePicker dtpDataCompra;
        private Label label2;
    }
}