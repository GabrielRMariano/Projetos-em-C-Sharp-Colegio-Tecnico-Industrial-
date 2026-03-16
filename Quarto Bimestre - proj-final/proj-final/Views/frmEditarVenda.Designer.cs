namespace proj_final.Views
{
    partial class frmEditarVenda
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
            label2 = new Label();
            dtpDataVenda = new DateTimePicker();
            numQtd = new NumericUpDown();
            label1 = new Label();
            btSalvarVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 57);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 9;
            label2.Text = "Data de venda:";
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Location = new Point(182, 57);
            dtpDataVenda.Margin = new Padding(3, 4, 3, 4);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(263, 27);
            dtpDataVenda.TabIndex = 8;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(182, 12);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(263, 27);
            numQtd.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 6;
            label1.Text = "Quantidade de jogos:";
            // 
            // btSalvarVenda
            // 
            btSalvarVenda.Location = new Point(182, 91);
            btSalvarVenda.Name = "btSalvarVenda";
            btSalvarVenda.Size = new Size(94, 29);
            btSalvarVenda.TabIndex = 10;
            btSalvarVenda.Text = "Salvar";
            btSalvarVenda.UseVisualStyleBackColor = true;
            btSalvarVenda.Click += btSalvarVenda_Click;
            // 
            // frmEditarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 133);
            Controls.Add(btSalvarVenda);
            Controls.Add(label2);
            Controls.Add(dtpDataVenda);
            Controls.Add(numQtd);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarVenda";
            Text = "Editar Venda";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dtpDataVenda;
        private NumericUpDown numQtd;
        private Label label1;
        private Button btSalvarVenda;
    }
}